using DocumentFlowApp.DataAccess.Repositories;

namespace DocumentFlowApp.UI.Forms
{
    public partial class fCreateEditRequest : Form
    {
        private readonly IFormFactory _formFactory;
        private readonly RequestRepository _repository;
        private readonly NotificationRepository _notificationRepository;

        public fCreateEditRequest(IFormFactory formFactory,
            RequestRepository repository,
            NotificationRepository notificationRepository)
        {
            _notificationRepository = notificationRepository;
            _repository = repository;
            _formFactory = formFactory;
            InitializeComponent();
        }

        public static List<long> fileSelectedIds = new List<long>();
        private bool changeMode = false;
        private long requestId = 0;

        private async void bCreateRequest_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Текст сообщения не может быть пустым");
                return;
            }

            if(changeMode)
            {
                await _repository.ChangeRequest(requestId, textBox1.Text, fileSelectedIds);
                MessageBox.Show("Правки успешно внесены");
                await _notificationRepository.NotificateAdminUsers($"Пользователем {Main.CurrentUser.Name} были внесены правки в запрос (id = {requestId}).");
            }
            else
            {
                var createdRequestId = await _repository.AddNewRequest(textBox1.Text, Main.CurrentUser.Id, fileSelectedIds);
                MessageBox.Show("Новый запрос был создан");
                await _notificationRepository.NotificateAdminUsers($"Пользователем {Main.CurrentUser.Name} был создан новый запрос (id = {createdRequestId}) с количеством вложений {fileSelectedIds.Count()}.");
            }

            this.Close();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            var form = _formFactory.Create<fFileManager>();
            form?.SetSelectedMode(fileSelectedIds);
            lFilesSelected.Text = fileSelectedIds.Count.ToString();
        }

        private void bDeattacheFiles_Click(object sender, EventArgs e)
        {
            fileSelectedIds.Clear();
            lFilesSelected.Text = fileSelectedIds.Count.ToString();
        }

        public void EditMode(long requestId, string message, List<long> fileIds)
        {
            this.requestId = requestId;
            changeMode = true;
            fileSelectedIds = fileIds;
            lFilesSelected.Text = fileSelectedIds.Count.ToString();
            this.Text = "Внести правки";
            bCreateRequest.Text = "Изменить";
            textBox1.Text = message;

            this.ShowDialog();
        }
    }
}
