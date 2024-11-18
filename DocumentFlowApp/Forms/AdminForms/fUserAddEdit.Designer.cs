namespace DocumentFlowApp.UI.Forms.AdminForms
{
    partial class fUserAddEdit
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
            label1 = new Label();
            tbLogin = new TextBox();
            tbName = new TextBox();
            label2 = new Label();
            tbPassword = new TextBox();
            label3 = new Label();
            bGenPass = new Button();
            cbAdmin = new CheckBox();
            bAddUser = new Button();
            lNewPassTip = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Логин:";
            // 
            // tbLogin
            // 
            tbLogin.Location = new Point(62, 14);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(288, 23);
            tbLogin.TabIndex = 1;
            // 
            // tbName
            // 
            tbName.Location = new Point(62, 43);
            tbName.Name = "tbName";
            tbName.Size = new Size(288, 23);
            tbName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 2;
            label2.Text = "Имя:";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(62, 72);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(181, 23);
            tbPassword.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 77);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 4;
            label3.Text = "Пароль:";
            // 
            // bGenPass
            // 
            bGenPass.Location = new Point(249, 71);
            bGenPass.Name = "bGenPass";
            bGenPass.Size = new Size(101, 23);
            bGenPass.TabIndex = 6;
            bGenPass.Text = "Сгенерировать";
            bGenPass.UseVisualStyleBackColor = true;
            bGenPass.Click += bGenPass_Click;
            // 
            // cbAdmin
            // 
            cbAdmin.AutoSize = true;
            cbAdmin.Location = new Point(12, 148);
            cbAdmin.Name = "cbAdmin";
            cbAdmin.Size = new Size(98, 19);
            cbAdmin.TabIndex = 7;
            cbAdmin.Text = "Админ права";
            cbAdmin.UseVisualStyleBackColor = true;
            // 
            // bAddUser
            // 
            bAddUser.Location = new Point(220, 148);
            bAddUser.Name = "bAddUser";
            bAddUser.Size = new Size(130, 23);
            bAddUser.TabIndex = 8;
            bAddUser.Text = "Добавить";
            bAddUser.UseVisualStyleBackColor = true;
            bAddUser.Click += bAddUser_Click;
            // 
            // lNewPassTip
            // 
            lNewPassTip.AutoSize = true;
            lNewPassTip.Location = new Point(24, 109);
            lNewPassTip.Name = "lNewPassTip";
            lNewPassTip.Size = new Size(305, 15);
            lNewPassTip.TabIndex = 9;
            lNewPassTip.Text = "Для изменения пароля введите или сгенерируйте его.";
            lNewPassTip.Visible = false;
            // 
            // fUserAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 179);
            Controls.Add(lNewPassTip);
            Controls.Add(bAddUser);
            Controls.Add(cbAdmin);
            Controls.Add(bGenPass);
            Controls.Add(tbPassword);
            Controls.Add(label3);
            Controls.Add(tbName);
            Controls.Add(label2);
            Controls.Add(tbLogin);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "fUserAdd";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавить пользователя";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbLogin;
        private TextBox tbName;
        private Label label2;
        private TextBox tbPassword;
        private Label label3;
        private Button bGenPass;
        private CheckBox cbAdmin;
        private Button bAddUser;
        private Label lNewPassTip;
    }
}