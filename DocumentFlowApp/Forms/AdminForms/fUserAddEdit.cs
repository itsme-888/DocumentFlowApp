using DocumentFlowApp.DataAccess.Repositories;

namespace DocumentFlowApp.UI.Forms.AdminForms
{
    public partial class fUserAddEdit : Form
    {
        private readonly UserRepository _userRepository;
        private bool isEdituser = false;
        private long userEditId = 0;

        public fUserAddEdit(UserRepository userRepository)
        {
            _userRepository = userRepository;
            InitializeComponent();
        }

        public void SetEditMode(long userEditId, string login, string name, bool isAdmin)
        {
            isEdituser = true;
            lNewPassTip.Visible = true;
            bAddUser.Text = "Изменить";

            this.userEditId = userEditId;
            tbLogin.Text = login;
            tbName.Text = name;
            cbAdmin.Checked = isAdmin;
            this.Text = "Изменить пользователя";

            if(Main.CurrentUser?.Id == userEditId)
            {
                cbAdmin.Enabled = false;
            }

            this.ShowDialog();

        }

        private async void bAddUser_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(tbPassword.Text) && !isEdituser) ||
                string.IsNullOrWhiteSpace(tbLogin.Text) ||
                string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Одно или несколько полей не заполнено");
                return;
            }


            if(isEdituser)
            {
                await _userRepository.ChangeUserAsync(userEditId, 
                    tbLogin.Text,
                    tbName.Text,
                    tbPassword.Text,
                    cbAdmin.Checked);

                MessageBox.Show("Пользователь был изменен");
            }

            else
            {
                await _userRepository.AddUserAsync(tbLogin.Text,
                    tbName.Text,
                    tbPassword.Text,
                    cbAdmin.Checked);

                MessageBox.Show("Пользователь был добавлен");
            }

            this.Close();
        }

        private void bGenPass_Click(object sender, EventArgs e)
        {
            tbPassword.Text = UserRepository.GenPass();
        }
    }
}
