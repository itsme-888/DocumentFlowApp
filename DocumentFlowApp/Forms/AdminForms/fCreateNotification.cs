using DocumentFlowApp.DataAccess.Repositories;
using System.Data;

namespace DocumentFlowApp.UI.Forms.AdminForms
{
    public partial class fCreateNotification : Form
    {
        private readonly NotificationRepository _notificationRepository;
        private readonly UserRepository _userRepository;

        public fCreateNotification(NotificationRepository notificationRepository,
            UserRepository userRepository)
        {
            _userRepository = userRepository;
            _notificationRepository = notificationRepository;
            InitializeComponent();
        }

        private async void fCreateNotification_Load(object sender, EventArgs e)
        {
            cbTarget.SelectedIndex = 0;
            await FillUsers();
        }

        private async Task FillUsers()
        {
            var users = await _userRepository.GetUsersAsync();

            var cbData = users.Select(x => new Item
            {
                Name = x.UserName,
                Id = x.Id
            }).ToArray();

            cbUser.DisplayMember = nameof(Item.Name);
            cbUser.ValueMember = nameof(Item.Id);
            cbUser.Items.AddRange(cbData);
            cbUser.SelectedIndex = 0;
            cbUser.Enabled = false;
        }

        private class Item
        {
            public string Name { get; set; }
            public long Id { get; set; }
        }

        private void cbTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbUser.Enabled = cbTarget.SelectedIndex == 2;
        }

        private async void bSendNotify_Click(object sender, EventArgs e)
        {
            var message = textBox1.Text;

            if(string.IsNullOrEmpty(message))
            {
                MessageBox.Show("Текст уведомления пуст!");
                return;
            }

            if (cbTarget.SelectedIndex == 0)
            {
                await _notificationRepository.NotificateAllUsers(message);
            }
            else if(cbTarget.SelectedIndex == 1)
            {
                await _notificationRepository.NotificateNotAdminUsers(message);
            }
            else
            {
                var selectedUserId = ((Item)cbUser.SelectedItem).Id;
                await _notificationRepository.NotificateUser(message, selectedUserId);
            }

            MessageBox.Show("Уведомление отправлено успешно");
        }
    }
}
