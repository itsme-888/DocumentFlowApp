using DocumentFlowApp.DataAccess.Repositories;

namespace DocumentFlowApp.UI.Forms
{
    public partial class fNotification : Form
    {
        private readonly NotificationRepository _notificationRepository;

        public fNotification(NotificationRepository notificationRepository)
        {
            _notificationRepository = notificationRepository;
            InitializeComponent();
        }

        private async void fNotification_Load(object sender, EventArgs e)
        {
           await UpdateGridData();
        }

        private async Task UpdateGridData()
        {
            var data = await _notificationRepository.GetAllNotificationForUser(Main.CurrentUser.Id);

            var allRead = data.All(x => x.IsRead);
            button2.Enabled = !allRead;

            dataGridView1.Rows.Clear();

            foreach (var notification in data)
            {
                dataGridView1.Rows.Add(notification.IsRead, notification.CreatedDateTime, notification.Message, notification.Id);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index >= 0)
                {
                    var row = dataGridView1.CurrentRow;
                    textBox1.Text = (string)row.Cells[2].Value;
                    var isRead = (bool)row.Cells[0].Value;
                    button1.Enabled = !isRead;
                }
            }
            catch { }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index >= 0)
            {
                var row = dataGridView1.CurrentRow;
                var notificationId = (long)row.Cells[3].Value;
                await _notificationRepository.MarkAsReadNotification(notificationId);
                await UpdateGridData();
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await _notificationRepository.MarkAsReadAllNotification(Main.CurrentUser.Id);
            await UpdateGridData();
        }
    }
}
