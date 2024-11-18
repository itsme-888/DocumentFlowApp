using DocumentFlowApp.DataAccess.Repositories;

namespace DocumentFlowApp.UI.Forms
{
    public partial class fAuth : Form
    {
        private readonly UserRepository _userRepository;

        public fAuth(UserRepository userRepositor)
        {
            InitializeComponent();
            _userRepository = userRepositor;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var user = await _userRepository.LogInAsync(tbLogin.Text, tbPass.Text);
            
            if(user == null)
            {
                MessageBox.Show("Неправильный логин/пароль");
            }
            else 
            {
                Main.CurrentUser = user;
                this.Close();
            }
        }
    }
}
