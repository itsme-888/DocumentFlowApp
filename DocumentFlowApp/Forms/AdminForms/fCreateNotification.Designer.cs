namespace DocumentFlowApp.UI.Forms.AdminForms
{
    partial class fCreateNotification
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
            textBox1 = new TextBox();
            label1 = new Label();
            cbTarget = new ComboBox();
            label2 = new Label();
            bSendNotify = new Button();
            cbUser = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 27);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(278, 144);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 1;
            label1.Text = "Текст уведомления:";
            // 
            // cbTarget
            // 
            cbTarget.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTarget.FormattingEnabled = true;
            cbTarget.Items.AddRange(new object[] { "Всех пользователей", "Всех, кроме администраторов", "Выбранного пользователя" });
            cbTarget.Location = new Point(296, 51);
            cbTarget.Name = "cbTarget";
            cbTarget.Size = new Size(237, 23);
            cbTarget.TabIndex = 2;
            cbTarget.SelectedIndexChanged += cbTarget_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(296, 30);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 3;
            label2.Text = "Кого уведомить:";
            // 
            // bSendNotify
            // 
            bSendNotify.Location = new Point(296, 148);
            bSendNotify.Name = "bSendNotify";
            bSendNotify.Size = new Size(237, 23);
            bSendNotify.TabIndex = 4;
            bSendNotify.Text = "Отправить";
            bSendNotify.UseVisualStyleBackColor = true;
            bSendNotify.Click += bSendNotify_Click;
            // 
            // cbUser
            // 
            cbUser.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUser.FormattingEnabled = true;
            cbUser.Location = new Point(296, 98);
            cbUser.Name = "cbUser";
            cbUser.Size = new Size(237, 23);
            cbUser.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(296, 80);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 6;
            label3.Text = "Пользователь:";
            // 
            // fCreateNotification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 202);
            Controls.Add(label3);
            Controls.Add(cbUser);
            Controls.Add(bSendNotify);
            Controls.Add(label2);
            Controls.Add(cbTarget);
            Controls.Add(label1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "fCreateNotification";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Создать уведомление";
            Load += fCreateNotification_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private ComboBox cbTarget;
        private Label label2;
        private Button bSendNotify;
        private ComboBox cbUser;
        private Label label3;
    }
}