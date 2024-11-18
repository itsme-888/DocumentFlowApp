using DocumentFlowApp.DataAccess.Repositories;

namespace DocumentFlowApp.UI.Forms.AdminForms
{
    public partial class fUserManage : Form
    {
        private readonly IFormFactory _formFactory;
        private readonly UserRepository _userRepository;

        public fUserManage(IFormFactory formFactory,
            UserRepository userRepository)
        {
            _formFactory = formFactory;
            _userRepository = userRepository;
            InitializeComponent();
        }

        private T GetCellValue<T>(int rowIndex, string cellName) => (T)dataGridView1.Rows[rowIndex].Cells[cellName].Value;

        private async void bAdd_Click(object sender, EventArgs e)
        {
            _formFactory.Create<fUserAddEdit>()?.ShowDialog();
            await LoadData();
        }

        private async Task LoadData()
        {
            dataGridView1.Rows.Clear();
            var data = await _userRepository.GetUsersAsync();

            foreach (var user in data)
            {
                dataGridView1.Rows.Add(user.Id, user.UserName, user.Name, user.IsAdmin, "Изменить");
            }

        }

        private async void fUserManage_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var senderGrid = (DataGridView)sender;
            var id = GetCellValue<long>(e.RowIndex, "id");

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                var form = _formFactory.Create<fUserAddEdit>();

                var login = GetCellValue<string>(e.RowIndex, "login");
                var name = GetCellValue<string>(e.RowIndex, "name");
                var isAdmin = GetCellValue<bool>(e.RowIndex, "isAdmin");

                form?.SetEditMode(id, login, name, isAdmin);
                await LoadData();
            }
        }
    }
}
