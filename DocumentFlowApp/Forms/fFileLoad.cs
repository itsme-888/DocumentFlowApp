using DocumentFlowApp.Common.Dtos;
using DocumentFlowApp.DataAccess.Repositories;
using System.Data;

namespace DocumentFlowApp.UI.Forms
{
    public partial class fFileLoad : Form
    {
        private readonly FilesRepository _repository;

        public fFileLoad(FilesRepository repository)
        {
            _repository = repository;
            InitializeComponent();
        }

        private void bFileSelect_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var selectedFiles = openFileDialog.FileNames.ToList();

                if (!selectedFiles.Any())
                {
                    return;
                }

                var fileInfos = selectedFiles
                    .Select(x => new FileInfo(x)).ToList();

                FillGridByFileInfos(fileInfos);

                toolStripProgressBar1.Value = 0;
                lfileName.Text = string.Empty;
            }
        }

        private void FillGridByFileInfos(List<FileInfo> fileInfos)
        {
            foreach (var fileInfo in fileInfos)
            {
                dataGridView1.Rows.Add(fileInfo.Name.Substring(0, fileInfo.Name.Length - fileInfo.Extension.Length), 
                    fileInfo.Extension, 
                    fileInfo.Length, 
                    fileInfo.FullName, 
                    string.Empty,
                    "Удалить");
                //todo maybe add validating the same files 
            }
        }

        private List<FileUploadDto> GetFileUploadDtos()
        {
            var result = new List<FileUploadDto>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                result.Add(new FileUploadDto
                {
                    FileName = row.Cells[0].Value.ToString(),
                    FileExt = row.Cells[1].Value.ToString(),
                    FileSize = (long)row.Cells[2].Value,
                    FullPath = row.Cells[3].Value.ToString(),
                    UserDescriptions = row.Cells[4].Value.ToString(),
                });
            }

            return result;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                senderGrid.Rows.RemoveAt(e.RowIndex);
            }
        }

        private async void bFileUpload_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Не выбраны файлы для загрузки");
                return;
            }

            var fileUploadDtos = GetFileUploadDtos();

            toolStripProgressBar1.Maximum = fileUploadDtos.Count();
            lfileName.Text = string.Empty;

            foreach (var file in fileUploadDtos)
            {
                lfileName.Text = file.FileName;
                await _repository.UploadFileAsync(file, Main.CurrentUser.Id);
                toolStripProgressBar1.Value += 1;
            }

            lfileName.Text = "завершена";
            dataGridView1.Rows.Clear();
            MessageBox.Show("Файлы успешно загружены");
        }
    }
}
