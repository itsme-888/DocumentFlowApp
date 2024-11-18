namespace DocumentFlowApp.UI.Forms
{
    partial class fFileLoad
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
            bFileSelect = new Button();
            bFileUpload = new Button();
            dataGridView1 = new DataGridView();
            fileName = new DataGridViewTextBoxColumn();
            ext = new DataGridViewTextBoxColumn();
            fileSize = new DataGridViewTextBoxColumn();
            path = new DataGridViewTextBoxColumn();
            descriptions = new DataGridViewTextBoxColumn();
            delete = new DataGridViewButtonColumn();
            statusStrip1 = new StatusStrip();
            toolStripProgressBar1 = new ToolStripProgressBar();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lfileName = new ToolStripStatusLabel();
            openFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // bFileSelect
            // 
            bFileSelect.Location = new Point(12, 396);
            bFileSelect.Name = "bFileSelect";
            bFileSelect.Size = new Size(227, 23);
            bFileSelect.TabIndex = 0;
            bFileSelect.Text = "Выбрать файлы для загрузки";
            bFileSelect.UseVisualStyleBackColor = true;
            bFileSelect.Click += bFileSelect_Click;
            // 
            // bFileUpload
            // 
            bFileUpload.Location = new Point(712, 396);
            bFileUpload.Name = "bFileUpload";
            bFileUpload.Size = new Size(213, 23);
            bFileUpload.TabIndex = 1;
            bFileUpload.Text = "Загрузить";
            bFileUpload.UseVisualStyleBackColor = true;
            bFileUpload.Click += bFileUpload_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { fileName, ext, fileSize, path, descriptions, delete });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(913, 378);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // fileName
            // 
            fileName.HeaderText = "Имя файла";
            fileName.Name = "fileName";
            fileName.SortMode = DataGridViewColumnSortMode.NotSortable;
            fileName.Width = 150;
            // 
            // ext
            // 
            ext.HeaderText = "Расширение";
            ext.Name = "ext";
            ext.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // fileSize
            // 
            fileSize.HeaderText = "Размер файла";
            fileSize.Name = "fileSize";
            fileSize.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // path
            // 
            path.HeaderText = "Путь к файлу";
            path.Name = "path";
            path.SortMode = DataGridViewColumnSortMode.NotSortable;
            path.Width = 200;
            // 
            // descriptions
            // 
            descriptions.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            descriptions.HeaderText = "Описание";
            descriptions.Name = "descriptions";
            descriptions.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // delete
            // 
            delete.HeaderText = "Удалить";
            delete.Name = "delete";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripProgressBar1, toolStripStatusLabel1, lfileName });
            statusStrip1.Location = new Point(0, 441);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(937, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 16);
            toolStripProgressBar1.Step = 1;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(58, 17);
            toolStripStatusLabel1.Text = "Загрузка:";
            // 
            // lfileName
            // 
            lfileName.Name = "lfileName";
            lfileName.Size = new Size(0, 17);
            // 
            // openFileDialog
            // 
            openFileDialog.Multiselect = true;
            // 
            // fFileLoad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 463);
            Controls.Add(statusStrip1);
            Controls.Add(dataGridView1);
            Controls.Add(bFileUpload);
            Controls.Add(bFileSelect);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "fFileLoad";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Загрузить файлы";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bFileSelect;
        private Button bFileUpload;
        private DataGridView dataGridView1;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lfileName;
        private OpenFileDialog openFileDialog;
        private DataGridViewTextBoxColumn fileName;
        private DataGridViewTextBoxColumn ext;
        private DataGridViewTextBoxColumn fileSize;
        private DataGridViewTextBoxColumn path;
        private DataGridViewTextBoxColumn descriptions;
        private DataGridViewButtonColumn delete;
    }
}