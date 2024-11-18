namespace DocumentFlowApp.UI.Forms.AdminForms
{
    partial class fUserManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            bAdd = new Button();
            id = new DataGridViewButtonColumn();
            login = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            isAdmin = new DataGridViewCheckBoxColumn();
            change = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, login, name, isAdmin, change });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(689, 364);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // bAdd
            // 
            bAdd.Location = new Point(12, 9);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(193, 23);
            bAdd.TabIndex = 1;
            bAdd.Text = "Добавить пользователя";
            bAdd.UseVisualStyleBackColor = true;
            bAdd.Click += bAdd_Click;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // login
            // 
            login.HeaderText = "Логин";
            login.Name = "login";
            login.ReadOnly = true;
            login.Width = 150;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.HeaderText = "Имя";
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // isAdmin
            // 
            isAdmin.HeaderText = "Админ права";
            isAdmin.Name = "isAdmin";
            isAdmin.ReadOnly = true;
            // 
            // change
            // 
            change.HeaderText = "Изменить";
            change.Name = "change";
            change.ReadOnly = true;
            // 
            // fUserManage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 402);
            Controls.Add(bAdd);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "fUserManage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Управление пользователями";
            Load += fUserManage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button bAdd;
        private DataGridViewButtonColumn id;
        private DataGridViewTextBoxColumn login;
        private DataGridViewTextBoxColumn name;
        private DataGridViewCheckBoxColumn isAdmin;
        private DataGridViewButtonColumn change;
    }
}