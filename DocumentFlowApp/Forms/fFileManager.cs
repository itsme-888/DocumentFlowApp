using DocumentFlowApp.Common.Entities;
using DocumentFlowApp.DataAccess;
using DocumentFlowApp.DataAccess.Repositories;
using System.Diagnostics;

namespace DocumentFlowApp.UI.Forms
{
    public partial class fFileManager : Form
    {
        private readonly MinioService _minioService;
        private readonly FilesRepository _repository;
        private readonly IFormFactory _formFactory;

        private string _currentDownloadPath;
        private FileInfoDb[] currentFileInfos;

        private bool selectingMode = false;
        private List<long> fileSelectedIds = new List<long>();

        private bool showMode = false;
        private long? requestId;

        public fFileManager(MinioService minioService,
            FilesRepository filesRepository,
            IFormFactory formFactory)
        {
            _minioService = minioService;
            _repository = filesRepository;
            _formFactory = formFactory;
            InitializeComponent();
            cbFilter.SelectedIndex = 0;
        }

        private bool SetDownloadDirectory()
        {
            var res = folderBrowserDialog1.ShowDialog();

            if (res == DialogResult.OK)
            {
                _currentDownloadPath = folderBrowserDialog1.SelectedPath;
                lCurrentPath.Text = _currentDownloadPath;
            }

            return res == DialogResult.OK;
        }

        private async Task RefreshDataGrid(long? requestId = null)
        {
            dataGridView1.Rows.Clear();

            if(requestId == null)
            {
                currentFileInfos = await _repository.GetFileInfos(Main.CurrentUser);
            }
            else
            {
                currentFileInfos = await _repository.GetFilesByRequest((long)requestId);
            }

            foreach (var fileInfo in currentFileInfos)
            {
                dataGridView1.Rows.Add(
                    fileInfo.Id,
                    fileSelectedIds.Any(x => x == fileInfo.Id),
                    fileInfo.CreatedDateTime,
                    fileInfo.UpdatedDateTime,
                    fileInfo.Name,
                    fileInfo.Ext,
                    fileInfo.Size,
                    fileInfo.User.Name,
                    fileInfo.Description,
                    fileInfo.IsArchived,
                    fileInfo.IsSoftDeleted,
                    "Скачать");
            }
        }

        private async void fFileManager_Load(object sender, EventArgs e)
        {
            SetUserRights();
            await RefreshDataGrid(requestId);
        }

        private void SetUserRights()
        {
            if (!Main.CurrentUser.IsAdmin)
            {
                dataGridView1.Columns["softDeleted"].Visible = false;
            }
        }

        private async void bAddFile_Click(object sender, EventArgs e)
        {
            _formFactory.Create<fFileLoad>()?.ShowDialog();
            await RefreshDataGrid();
            lFilter_TextChanged(null, null);
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

            if (senderGrid.Columns[e.ColumnIndex].Name == "select")
            {
                var isSelected = !GetCellValue<bool>(e.RowIndex, "select");
                if (isSelected)
                {
                    fileSelectedIds.Add(id);
                }
                else
                {
                    fileSelectedIds.Remove(id);
                }
            }

            if (senderGrid.Columns[e.ColumnIndex].Name == "download")
            {
                if (string.IsNullOrWhiteSpace(_currentDownloadPath))
                {
                    if (!SetDownloadDirectory())
                    {
                        MessageBox.Show("Не выбрана папка для загрузки.");
                        return;
                    }
                }

                var selectedFileInfo = currentFileInfos.Single(x => id == x.Id);

                dataGridView1.Enabled = false;
                await _minioService.DownloadFile(selectedFileInfo, _currentDownloadPath);
                dataGridView1.Enabled = true;
                MessageBox.Show("Файл был загружен");
            }

            if (senderGrid.Columns[e.ColumnIndex].Name == "softDeleted")
            {
                var value = !GetCellValue<bool>(e.RowIndex, "softDeleted");
                await _repository.SetDeleted(id, value);
            }

            if (senderGrid.Columns[e.ColumnIndex].Name == "archive")
            {
                var value = !GetCellValue<bool>(e.RowIndex, "archive");
                await _repository.SetArchive(id, value);
            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            SetDownloadDirectory();
        }

        private void lCurrentPath_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_currentDownloadPath))
            {
                Process.Start("explorer.exe", _currentDownloadPath);
            }
        }

        private void Filter(string columnName)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (string.IsNullOrWhiteSpace(lFilter.Text))
                {
                    row.Visible = true;
                    continue;
                }

                var value = (row.Cells[columnName].Value.ToString() ?? string.Empty).Trim().ToLower();

                if (value.Contains(lFilter.Text.Trim().ToLower()))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void bFilterRemove_Click(object sender, EventArgs e) => lFilter.Text = string.Empty;

        private void lFilter_TextChanged(object sender, EventArgs e)
        {
            switch (cbFilter.SelectedIndex)
            {
                case 0:
                    Filter("fileName");
                    break;
                case 1:
                    Filter("ext");
                    break;
                case 2:
                    Filter("user");
                    break;
                case 3:
                    Filter("descriptions");
                    break;
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e) => lFilter_TextChanged(null, e);

        private void fFileManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (selectingMode)
            {
                fCreateEditRequest.fileSelectedIds = fileSelectedIds;
            }
        }

        public void SetSelectedMode(List<long> fileSelectedIds)
        {
            this.fileSelectedIds = fileSelectedIds;
            dataGridView1.Columns["select"].Visible = true;
            dataGridView1.Columns["softDeleted"].Visible = false;
            dataGridView1.Columns["archive"].Visible = false;
            this.Text = "Выбрать файлы";

            this.ShowDialog();
        }

        public void SetShowOnlyMode(long requestId)
        {
            showMode = true;
            this.requestId = requestId;
            this.bAddFile.Visible = false;
            dataGridView1.Columns["softDeleted"].Visible = false;
            dataGridView1.Columns["archive"].Visible = false;
            this.Text = "Файлы запроса";

            this.ShowDialog();
        }
    }
}
