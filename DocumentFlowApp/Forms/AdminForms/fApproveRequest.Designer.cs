namespace DocumentFlowApp.UI.Forms.AdminForms
{
    partial class fApproveRequest
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            bApprove = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            bDecline = new Button();
            id = new DataGridViewTextBoxColumn();
            created = new DataGridViewTextBoxColumn();
            updated = new DataGridViewTextBoxColumn();
            message = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            approves = new DataGridViewTextBoxColumn();
            user_id = new DataGridViewTextBoxColumn();
            count = new DataGridViewTextBoxColumn();
            showfiles = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, created, updated, message, status, approves, user_id, count, showfiles });
            dataGridView1.Location = new Point(3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(1077, 375);
            dataGridView1.TabIndex = 5;
            // 
            // bApprove
            // 
            bApprove.Location = new Point(12, 401);
            bApprove.Name = "bApprove";
            bApprove.Size = new Size(203, 23);
            bApprove.TabIndex = 6;
            bApprove.Text = "Согласовать выбранный";
            bApprove.UseVisualStyleBackColor = true;
            bApprove.Click += bApprove_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(583, 401);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(262, 23);
            textBox1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(452, 405);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 8;
            label1.Text = "Комментарий отказа:";
            // 
            // bDecline
            // 
            bDecline.Location = new Point(874, 405);
            bDecline.Name = "bDecline";
            bDecline.Size = new Size(198, 23);
            bDecline.TabIndex = 9;
            bDecline.Text = "Отклонить выбранный";
            bDecline.UseVisualStyleBackColor = true;
            bDecline.Click += bDecline_Click;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // created
            // 
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            created.DefaultCellStyle = dataGridViewCellStyle1;
            created.HeaderText = "Создан";
            created.Name = "created";
            created.ReadOnly = true;
            // 
            // updated
            // 
            dataGridViewCellStyle2.Format = "g";
            dataGridViewCellStyle2.NullValue = null;
            updated.DefaultCellStyle = dataGridViewCellStyle2;
            updated.HeaderText = "Обновлен";
            updated.Name = "updated";
            updated.ReadOnly = true;
            // 
            // message
            // 
            message.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            message.HeaderText = "Сообщение";
            message.Name = "message";
            message.ReadOnly = true;
            // 
            // status
            // 
            status.HeaderText = "Статус";
            status.Name = "status";
            status.ReadOnly = true;
            // 
            // approves
            // 
            approves.HeaderText = "Создан пользователем";
            approves.Name = "approves";
            approves.ReadOnly = true;
            // 
            // user_id
            // 
            user_id.HeaderText = "Id пользователя";
            user_id.Name = "user_id";
            user_id.ReadOnly = true;
            // 
            // count
            // 
            count.HeaderText = "Количество файлов";
            count.Name = "count";
            count.ReadOnly = true;
            // 
            // showfiles
            // 
            showfiles.HeaderText = "Файлы";
            showfiles.Name = "showfiles";
            showfiles.ReadOnly = true;
            // 
            // fApproveRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 449);
            Controls.Add(bDecline);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(bApprove);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "fApproveRequest";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Согласование запросов";
            Load += fApproveRequest_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button bApprove;
        private TextBox textBox1;
        private Label label1;
        private Button bDecline;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn created;
        private DataGridViewTextBoxColumn updated;
        private DataGridViewTextBoxColumn message;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn approves;
        private DataGridViewTextBoxColumn user_id;
        private DataGridViewTextBoxColumn count;
        private DataGridViewButtonColumn showfiles;
    }
}