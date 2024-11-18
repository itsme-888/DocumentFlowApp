namespace DocumentFlowApp.UI.Forms
{
    partial class fFileManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fFileManager));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            folderBrowserDialog1 = new FolderBrowserDialog();
            toolStrip1 = new ToolStrip();
            bAddFile = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            cbFilter = new ToolStripComboBox();
            lFilter = new ToolStripTextBox();
            bFilterRemove = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel2 = new ToolStripLabel();
            lCurrentPath = new ToolStripLabel();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            select = new DataGridViewCheckBoxColumn();
            created = new DataGridViewTextBoxColumn();
            changed = new DataGridViewTextBoxColumn();
            fileName = new DataGridViewTextBoxColumn();
            ext = new DataGridViewTextBoxColumn();
            fileSize = new DataGridViewTextBoxColumn();
            user = new DataGridViewTextBoxColumn();
            descriptions = new DataGridViewTextBoxColumn();
            archive = new DataGridViewCheckBoxColumn();
            softDeleted = new DataGridViewCheckBoxColumn();
            download = new DataGridViewButtonColumn();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(30, 30);
            toolStrip1.Items.AddRange(new ToolStripItem[] { bAddFile, toolStripSeparator2, toolStripLabel1, cbFilter, lFilter, bFilterRemove, toolStripSeparator1, toolStripLabel2, lCurrentPath });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1304, 37);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // bAddFile
            // 
            bAddFile.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bAddFile.Image = (Image)resources.GetObject("bAddFile.Image");
            bAddFile.ImageTransparentColor = Color.Magenta;
            bAddFile.Name = "bAddFile";
            bAddFile.Size = new Size(34, 34);
            bAddFile.Text = "Загрузка файлов";
            bAddFile.Click += bAddFile_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 37);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(68, 34);
            toolStripLabel1.Text = "Фильтр по:";
            // 
            // cbFilter
            // 
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.Items.AddRange(new object[] { "Имя файла", "Расширение", "Пользователь", "Описание" });
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(121, 37);
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // lFilter
            // 
            lFilter.Name = "lFilter";
            lFilter.Size = new Size(100, 37);
            lFilter.TextChanged += lFilter_TextChanged;
            // 
            // bFilterRemove
            // 
            bFilterRemove.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bFilterRemove.Image = (Image)resources.GetObject("bFilterRemove.Image");
            bFilterRemove.ImageTransparentColor = Color.Magenta;
            bFilterRemove.Name = "bFilterRemove";
            bFilterRemove.Size = new Size(34, 34);
            bFilterRemove.Text = "Сброс фильтра";
            bFilterRemove.Click += bFilterRemove_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 37);
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(161, 34);
            toolStripLabel2.Text = "Папка для загрузки файлов:";
            toolStripLabel2.Click += toolStripLabel2_Click;
            // 
            // lCurrentPath
            // 
            lCurrentPath.Name = "lCurrentPath";
            lCurrentPath.Size = new Size(62, 34);
            lCurrentPath.Text = "...выбрать";
            lCurrentPath.Click += lCurrentPath_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, select, created, changed, fileName, ext, fileSize, user, descriptions, archive, softDeleted, download });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1304, 498);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // select
            // 
            select.HeaderText = "Выбрать";
            select.Name = "select";
            select.Visible = false;
            // 
            // created
            // 
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = null;
            created.DefaultCellStyle = dataGridViewCellStyle1;
            created.HeaderText = "Создан";
            created.Name = "created";
            created.ReadOnly = true;
            // 
            // changed
            // 
            dataGridViewCellStyle2.Format = "G";
            dataGridViewCellStyle2.NullValue = null;
            changed.DefaultCellStyle = dataGridViewCellStyle2;
            changed.HeaderText = "Изменен";
            changed.Name = "changed";
            changed.ReadOnly = true;
            // 
            // fileName
            // 
            fileName.HeaderText = "Имя файла";
            fileName.Name = "fileName";
            fileName.ReadOnly = true;
            fileName.Width = 150;
            // 
            // ext
            // 
            ext.HeaderText = "Расширение";
            ext.Name = "ext";
            ext.ReadOnly = true;
            // 
            // fileSize
            // 
            fileSize.HeaderText = "Размер файла";
            fileSize.Name = "fileSize";
            fileSize.ReadOnly = true;
            // 
            // user
            // 
            user.HeaderText = "Пользователь";
            user.Name = "user";
            user.ReadOnly = true;
            // 
            // descriptions
            // 
            descriptions.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            descriptions.HeaderText = "Описание";
            descriptions.Name = "descriptions";
            descriptions.ReadOnly = true;
            // 
            // archive
            // 
            archive.HeaderText = "Архивирован";
            archive.Name = "archive";
            // 
            // softDeleted
            // 
            softDeleted.HeaderText = "Удален";
            softDeleted.Name = "softDeleted";
            // 
            // download
            // 
            download.HeaderText = "Скачать";
            download.Name = "download";
            // 
            // fFileManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1304, 535);
            Controls.Add(dataGridView1);
            Controls.Add(toolStrip1);
            DoubleBuffered = true;
            Name = "fFileManager";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Менеджер файлов";
            FormClosing += fFileManager_FormClosing;
            Load += fFileManager_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FolderBrowserDialog folderBrowserDialog1;
        private ToolStrip toolStrip1;
        private ToolStripButton bFilterRemove;
        private ToolStripTextBox lFilter;
        private ToolStripLabel toolStripLabel1;
        private ToolStripComboBox cbFilter;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton bAddFile;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel toolStripLabel2;
        private ToolStripLabel lCurrentPath;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewCheckBoxColumn select;
        private DataGridViewTextBoxColumn created;
        private DataGridViewTextBoxColumn changed;
        private DataGridViewTextBoxColumn fileName;
        private DataGridViewTextBoxColumn ext;
        private DataGridViewTextBoxColumn fileSize;
        private DataGridViewTextBoxColumn user;
        private DataGridViewTextBoxColumn descriptions;
        private DataGridViewCheckBoxColumn archive;
        private DataGridViewCheckBoxColumn softDeleted;
        private DataGridViewButtonColumn download;
    }
}