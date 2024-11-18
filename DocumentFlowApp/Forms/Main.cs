using DocumentFlowApp.Common.Entities;
using DocumentFlowApp.Common.Enums;
using DocumentFlowApp.DataAccess.Repositories;
using DocumentFlowApp.UI.Forms;
using DocumentFlowApp.UI.Forms.AdminForms;
using DocumentFlowApp.DataAccess;
using System.ComponentModel.DataAnnotations;
using DocumentFlowApp.Common.Dtos;

namespace DocumentFlowApp
{
    public partial class Main : Form
    {
        public static User? CurrentUser;
        private readonly IFormFactory _formFactory;
        private readonly NotificationRepository _notificationRepository;
        private readonly RequestRepository _requestRepository;

        private List<RequestDto> requestDtos = new List<RequestDto>();

        public Main(IFormFactory formFactory,
            NotificationRepository notificationRepository,
            RequestRepository requestRepository)
        {
            _requestRepository = requestRepository;
            _formFactory = formFactory;
            _notificationRepository = notificationRepository;
            InitializeComponent();
        }

        private async void Main_Load(object sender, EventArgs e)
        {
            CurrentUser = new User
            {
                IsAdmin = true,
                UserName = "admin",
                Name = "Администратор",
                Id = 1,
                PasswordHash = "",
            };

            //_formFactory.Create<fAuth>()?.ShowDialog();

            if (CurrentUser == null)
            {
                this.Close();
            }

            if (!CurrentUser.IsAdmin)
            {
                adminStrip.Visible = false;
            }

            tNotifyCountRefresh_Tick(null, null);
            tNotifyCountRefresh.Enabled = true;
            lUserHello.Text = $"Доброго времени суток, {CurrentUser.Name}";
            await FillGrid();
        }

        private async Task FillGrid()
        {
            dataGridView1.Rows.Clear();
            requestDtos = await _requestRepository.GetOpenRequestsForUser(Main.CurrentUser.Id);

            foreach (var request in requestDtos)
            {
                dataGridView1.Rows.Add(request.Id,
                    request.CreatedDateTime,
                    request.UpdatedDateTime,
                    request.Message,
                    request.RequestStatus.GetAttribute<DisplayAttribute>().Name,
                    request.ApprovedUser,
                    request.Comment,
                    request.SelectedFileCount,
                    request.SelectedFileCount > 0 ? "Файлы" : null,
                    request.RequestStatus == RequestStatusEnum.NeedEdit ? "Внести правки" : null);
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

            if (senderGrid.Columns[e.ColumnIndex].Name == "change")
            {
                var allow = GetCellValue<string>(e.RowIndex, "change") != null;

                if (allow)
                {
                    var form = _formFactory.Create<fCreateEditRequest>();
                    var message = GetCellValue<string>(e.RowIndex, "message");
                    var fileIds = requestDtos
                        .First(x => x.Id == id)
                        .SelectedFileIds;

                    form?.EditMode(id, message, fileIds);
                    await FillGrid();
                }
            }
        }

        private void bCreateNotification_Click(object sender, EventArgs e)
        {
            _formFactory.Create<fCreateNotification>()?.ShowDialog();
        }

        private async void tNotifyCountRefresh_Tick(object sender, EventArgs e)
        {
            var count = await _notificationRepository.GetUnreadNotificationCount(CurrentUser.Id);
            lNotifyCount.Text = count.ToString();
        }

        private void bNotification_Click(object sender, EventArgs e)
        {
            _formFactory.Create<fNotification>()?.ShowDialog();
        }

        private void bFilesUpload_Click(object sender, EventArgs e)
        {
            _formFactory.Create<fFileLoad>()?.ShowDialog();
        }

        private void bFiles_Click(object sender, EventArgs e)
        {
            _formFactory.Create<fFileManager>()?.ShowDialog();
        }

        private void bUserManage_Click(object sender, EventArgs e)
        {
            _formFactory.Create<fUserManage>()?.ShowDialog();
        }

        private void bNewRequest_Click(object sender, EventArgs e)
        {
            _formFactory.Create<fCreateEditRequest>()?.ShowDialog();
        }

        private void bRequestHistory_Click(object sender, EventArgs e)
        {
            _formFactory.Create<fRequestHistory>()?.ShowDialog();
        }

        private async void bApproving_Click(object sender, EventArgs e)
        {
            _formFactory.Create<fApproveRequest>()?.ShowDialog();
            await FillGrid();
        }
    }
}
