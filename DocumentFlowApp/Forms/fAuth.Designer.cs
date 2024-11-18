namespace DocumentFlowApp.UI.Forms
{
    partial class fAuth
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
            tbLogin = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbPass = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // tbLogin
            // 
            tbLogin.Location = new Point(75, 24);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(192, 23);
            tbLogin.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "Логин:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 3;
            label2.Text = "Пароль:";
            // 
            // tbPass
            // 
            tbPass.Location = new Point(75, 62);
            tbPass.Name = "tbPass";
            tbPass.PasswordChar = '*';
            tbPass.Size = new Size(192, 23);
            tbPass.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(96, 113);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // fAuth
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 148);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(tbPass);
            Controls.Add(label1);
            Controls.Add(tbLogin);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "fAuth";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbLogin;
        private Label label1;
        private Label label2;
        private TextBox tbPass;
        private Button button1;
    }
}