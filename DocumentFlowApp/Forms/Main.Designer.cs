namespace DocumentFlowApp
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            adminStrip = new ToolStrip();
            bCreateNotification = new ToolStripButton();
            bApproving = new ToolStripButton();
            bUserManage = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lNotifyCount = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            lUserHello = new ToolStripLabel();
            bNotification = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            bFiles = new ToolStripButton();
            bFilesUpload = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            bNewRequest = new ToolStripButton();
            bRequestHistory = new ToolStripButton();
            tNotifyCountRefresh = new System.Windows.Forms.Timer(components);
            label1 = new Label();
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
            change = new DataGridViewButtonColumn();
            adminStrip.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // adminStrip
            // 
            adminStrip.ImageScalingSize = new Size(30, 30);
            adminStrip.Items.AddRange(new ToolStripItem[] { bCreateNotification, bApproving, bUserManage });
            adminStrip.Location = new Point(0, 0);
            adminStrip.Name = "adminStrip";
            adminStrip.RenderMode = ToolStripRenderMode.Professional;
            adminStrip.Size = new Size(1153, 37);
            adminStrip.TabIndex = 0;
            adminStrip.Text = "Админ панель";
            // 
            // bCreateNotification
            // 
            bCreateNotification.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bCreateNotification.Image = (Image)resources.GetObject("bCreateNotification.Image");
            bCreateNotification.ImageTransparentColor = Color.Magenta;
            bCreateNotification.Name = "bCreateNotification";
            bCreateNotification.Size = new Size(34, 34);
            bCreateNotification.Text = "Создать уведомление";
            bCreateNotification.Click += bCreateNotification_Click;
            // 
            // bApproving
            // 
            bApproving.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bApproving.Image = (Image)resources.GetObject("bApproving.Image");
            bApproving.ImageTransparentColor = Color.Magenta;
            bApproving.Name = "bApproving";
            bApproving.Size = new Size(34, 34);
            bApproving.Text = "Согласование запросов";
            bApproving.Click += bApproving_Click;
            // 
            // bUserManage
            // 
            bUserManage.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bUserManage.Image = (Image)resources.GetObject("bUserManage.Image");
            bUserManage.ImageTransparentColor = Color.Magenta;
            bUserManage.Name = "bUserManage";
            bUserManage.Size = new Size(34, 34);
            bUserManage.Text = "Управление пользователями";
            bUserManage.Click += bUserManage_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lNotifyCount });
            statusStrip1.Location = new Point(0, 467);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1153, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(124, 17);
            toolStripStatusLabel1.Text = "Новых уведомлений:";
            toolStripStatusLabel1.Click += bNotification_Click;
            // 
            // lNotifyCount
            // 
            lNotifyCount.Name = "lNotifyCount";
            lNotifyCount.Size = new Size(76, 17);
            lNotifyCount.Text = "lNotifyCount";
            lNotifyCount.Click += bNotification_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(30, 30);
            toolStrip1.Items.AddRange(new ToolStripItem[] { lUserHello, bNotification, toolStripSeparator1, bFiles, bFilesUpload, toolStripSeparator2, bNewRequest, bRequestHistory });
            toolStrip1.Location = new Point(0, 37);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1153, 37);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // lUserHello
            // 
            lUserHello.Name = "lUserHello";
            lUserHello.Size = new Size(61, 34);
            lUserHello.Text = "lUserHello";
            // 
            // bNotification
            // 
            bNotification.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bNotification.Image = (Image)resources.GetObject("bNotification.Image");
            bNotification.ImageTransparentColor = Color.Magenta;
            bNotification.Name = "bNotification";
            bNotification.Size = new Size(34, 34);
            bNotification.Text = "Уведомления";
            bNotification.Click += bNotification_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 37);
            // 
            // bFiles
            // 
            bFiles.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bFiles.Image = (Image)resources.GetObject("bFiles.Image");
            bFiles.ImageTransparentColor = Color.Magenta;
            bFiles.Name = "bFiles";
            bFiles.Size = new Size(34, 34);
            bFiles.Text = "Файлы";
            bFiles.Click += bFiles_Click;
            // 
            // bFilesUpload
            // 
            bFilesUpload.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bFilesUpload.Image = (Image)resources.GetObject("bFilesUpload.Image");
            bFilesUpload.ImageTransparentColor = Color.Magenta;
            bFilesUpload.Name = "bFilesUpload";
            bFilesUpload.Size = new Size(34, 34);
            bFilesUpload.Text = "Загрузить новый файл";
            bFilesUpload.Click += bFilesUpload_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 37);
            // 
            // bNewRequest
            // 
            bNewRequest.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bNewRequest.Image = (Image)resources.GetObject("bNewRequest.Image");
            bNewRequest.ImageTransparentColor = Color.Magenta;
            bNewRequest.Name = "bNewRequest";
            bNewRequest.Size = new Size(34, 34);
            bNewRequest.Text = "Новый запрос на согласование";
            bNewRequest.Click += bNewRequest_Click;
            // 
            // bRequestHistory
            // 
            bRequestHistory.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bRequestHistory.Image = (Image)resources.GetObject("bRequestHistory.Image");
            bRequestHistory.ImageTransparentColor = Color.Magenta;
            bRequestHistory.Name = "bRequestHistory";
            bRequestHistory.Size = new Size(34, 34);
            bRequestHistory.Text = "История запросов";
            bRequestHistory.Click += bRequestHistory_Click;
            // 
            // tNotifyCountRefresh
            // 
            tNotifyCountRefresh.Interval = 5000;
            tNotifyCountRefresh.Tick += tNotifyCountRefresh_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 74);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 3;
            label1.Text = "Мои открытые запросы:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, created, updated, message, status, approves, comment, count, showfiles, change });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(1153, 367);
            dataGridView1.TabIndex = 4;
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
            // change
            // 
            change.HeaderText = "Изменить";
            change.Name = "change";
            change.ReadOnly = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1153, 489);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(adminStrip);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Main";
            Text = "АИС документооборот";
            Load += Main_Load;
            adminStrip.ResumeLayout(false);
            adminStrip.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip adminStrip;
        private ToolStripButton bCreateNotification;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lNotifyCount;
        private ToolStripLabel toolStripLabel1;
        private ToolStrip toolStrip1;
        private ToolStripButton bNotification;
        private System.Windows.Forms.Timer tNotifyCountRefresh;
        private ToolStripLabel lUserHello;
        private ToolStripButton bFiles;
        private ToolStripButton bNewRequest;
        private ToolStripButton bFilesUpload;
        private ToolStripButton bApproving;
        private ToolStripButton bUserManage;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton bRequestHistory;
        private Label label1;
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
        private DataGridViewButtonColumn change;
    }
}
