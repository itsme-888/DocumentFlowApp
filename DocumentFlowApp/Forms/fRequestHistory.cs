using DocumentFlowApp.DataAccess;
using DocumentFlowApp.DataAccess.Repositories;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DocumentFlowApp.UI.Forms
{
    public partial class fRequestHistory : Form
    {
        private readonly IFormFactory _formFactory;
        private readonly RequestRepository _requestRepository;

        public fRequestHistory(IFormFactory formFactory,
            RequestRepository requestRepository)
        {
            _formFactory = formFactory;
            _requestRepository = requestRepository;
            InitializeComponent();
        }

        private T GetCellValue<T>(int rowIndex, string cellName) => (T)dataGridView1.Rows[rowIndex].Cells[cellName].Value;

        private async void fRequestHistory_Load(object sender, EventArgs e)
        {
            await FillGrid();
        }

        private async Task FillGrid()
        {
            dataGridView1.Rows.Clear();
            var data = await _requestRepository.GetRequestsForUserHistory(Main.CurrentUser.Id);

            foreach (var request in data)
            {
                dataGridView1.Rows.Add(request.Id,
                    request.CreatedDateTime,
                    request.UpdatedDateTime,
                    request.Message,
                    request.RequestStatus.GetAttribute<DisplayAttribute>().Name,
                    request.ApprovedUser,
                    request.Comment,
                    request.SelectedFileCount,
                    request.SelectedFileCount > 0 ? "Файлы" : null);
            }
        }

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
    }
}
