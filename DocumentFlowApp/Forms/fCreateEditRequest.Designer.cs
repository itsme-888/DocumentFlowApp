namespace DocumentFlowApp.UI.Forms
{
    partial class fCreateEditRequest
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
            bAdd = new Button();
            label2 = new Label();
            lFilesSelected = new Label();
            bCreateRequest = new Button();
            bDeattacheFiles = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 27);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(326, 141);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 1;
            label1.Text = "Сообщение:";
            // 
            // bAdd
            // 
            bAdd.Location = new Point(12, 202);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(128, 23);
            bAdd.TabIndex = 2;
            bAdd.Text = "Добавить файлы";
            bAdd.UseVisualStyleBackColor = true;
            bAdd.Click += bAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 179);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 3;
            label2.Text = "Выбрано файлов:";
            // 
            // lFilesSelected
            // 
            lFilesSelected.AutoSize = true;
            lFilesSelected.Location = new Point(124, 179);
            lFilesSelected.Name = "lFilesSelected";
            lFilesSelected.Size = new Size(13, 15);
            lFilesSelected.TabIndex = 4;
            lFilesSelected.Text = "0";
            // 
            // bCreateRequest
            // 
            bCreateRequest.Location = new Point(13, 244);
            bCreateRequest.Name = "bCreateRequest";
            bCreateRequest.Size = new Size(325, 23);
            bCreateRequest.TabIndex = 5;
            bCreateRequest.Text = "Создать";
            bCreateRequest.UseVisualStyleBackColor = true;
            bCreateRequest.Click += bCreateRequest_Click;
            // 
            // bDeattacheFiles
            // 
            bDeattacheFiles.Location = new Point(210, 202);
            bDeattacheFiles.Name = "bDeattacheFiles";
            bDeattacheFiles.Size = new Size(128, 23);
            bDeattacheFiles.TabIndex = 6;
            bDeattacheFiles.Text = "Удалить файлы";
            bDeattacheFiles.UseVisualStyleBackColor = true;
            bDeattacheFiles.Click += bDeattacheFiles_Click;
            // 
            // fCreateRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 279);
            Controls.Add(bDeattacheFiles);
            Controls.Add(bCreateRequest);
            Controls.Add(lFilesSelected);
            Controls.Add(label2);
            Controls.Add(bAdd);
            Controls.Add(label1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "fCreateRequest";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Создать запрос";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button bAdd;
        private Label label2;
        private Label lFilesSelected;
        private Button bCreateRequest;
        private Button bDeattacheFiles;
    }
}