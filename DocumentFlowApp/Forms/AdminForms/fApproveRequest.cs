using DocumentFlowApp.DataAccess.Repositories;
using DocumentFlowApp.DataAccess;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DocumentFlowApp.UI.Forms.AdminForms
{
    public partial class fApproveRequest : Form
    {
        private readonly IFormFactory _formFactory;
        private readonly NotificationRepository _notificationRepository;
        private readonly RequestRepository _requestRepository;

        public fApproveRequest(IFormFactory formFactory,
            NotificationRepository notificationRepository,
            RequestRepository requestRepository)
        {
            _requestRepository = requestRepository;
            _formFactory = formFactory;
            _notificationRepository = notificationRepository;
            InitializeComponent();
        }

        private async void fApproveRequest_Load(object sender, EventArgs e)
        {
            await FillGrid();
        }

        private async Task FillGrid()
        {
            dataGridView1.Rows.Clear();
            var data = await _requestRepository.GetRequestsForApprove();

            if (!data.Any())
            {
                MessageBox.Show("Нет запросов на согласование");
                this.Close();
            }

            foreach (var request in data)
            {
                dataGridView1.Rows.Add(request.Id,
                    request.CreatedDateTime,
                    request.UpdatedDateTime,
                    request.Message,
                    request.RequestStatus.GetAttribute<DisplayAttribute>().Name,
                    request.CreatedByUserName,
                    request.CreatedByUserId,
                    request.SelectedFileCount,
                    request.SelectedFileCount > 0 ? "Файлы" : null);
            }
        }

        private T GetCellValue<T>(int rowIndex, string cellName) => (T)dataGridView1.Rows[rowIndex].Cells[cellName].Value;

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var senderGrid = (DataGridView)sender;
            var id = GetCellValue<long>(e.RowIndex, "id");

            if (senderGrid.Columns[e.ColumnIndex].Name == "showfiles")
            {
                var allow = GetCellValue<string>(e.RowIndex, "showfiles") != null;

                if (allow)
                {
                    var form = _formFactory.Create<fFileManager>();
                    form?.SetShowOnlyMode(id);
                }
            }
        }

        private async void bApprove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0)
            {
                MessageBox.Show("Не выбрана строка");
                return;
            }

            var id = GetCellValue<long>(dataGridView1.CurrentRow.Index, "id");
            await _requestRepository.ApproveRequest(id, Main.CurrentUser.Id);

            var userId = GetCellValue<long>(dataGridView1.CurrentRow.Index, "user_id");
            await _notificationRepository.NotificateUser($"Запрос с ид {id} был подтвержден пользователем {Main.CurrentUser.Name}", userId);
            await FillGrid();
        }

        private async void bDecline_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0)
            {
                MessageBox.Show("Не выбрана строка");
                return;
            }

            var id = GetCellValue<long>(dataGridView1.CurrentRow.Index, "id");
            await _requestRepository.DeclineRequest(id, textBox1.Text, Main.CurrentUser.Id);

            var userId = GetCellValue<long>(dataGridView1.CurrentRow.Index, "user_id");
            await _notificationRepository.NotificateUser($"Запрос с ид {id} был отклонен пользователем {Main.CurrentUser.Name}. Комментарий: {textBox1.Text}", userId);
            await FillGrid();
        }
    }
}
