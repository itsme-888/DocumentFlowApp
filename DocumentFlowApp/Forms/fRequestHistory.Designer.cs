namespace DocumentFlowApp.UI.Forms
{
    partial class fRequestHistory
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
            id = new DataGridViewTextBoxColumn();
            created = new DataGridViewTextBoxColumn();
            updated = new DataGridViewTextBoxColumn();
            message = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            approves = new DataGridViewTextBoxColumn();
            comment = new DataGridViewTextBoxColumn();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, created, updated, message, status, approves, comment, count, showfiles });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(1008, 501);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            approves.HeaderText = "Проверял";
            approves.Name = "approves";
            approves.ReadOnly = true;
            // 
            // comment
            // 
            comment.HeaderText = "Комментарий";
            comment.Name = "comment";
            comment.ReadOnly = true;
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
            // fRequestHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 501);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "fRequestHistory";
            StartPosition = FormStartPosition.CenterParent;
            Text = "История запросов";
            Load += fRequestHistory_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn created;
        private DataGridViewTextBoxColumn updated;
        private DataGridViewTextBoxColumn message;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn approves;
        private DataGridViewTextBoxColumn comment;
        private DataGridViewTextBoxColumn count;
        private DataGridViewButtonColumn showfiles;
    }
}