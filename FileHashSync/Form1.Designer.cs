namespace FileHashSync
{
    partial class Form1
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
            DirectoryPathTxt = new TextBox();
            label1 = new Label();
            loadPathBtn = new Button();
            LoadCSVBtn = new Button();
            label2 = new Label();
            CSVPathTXT = new TextBox();
            ExportBtn = new Button();
            prgBar = new ProgressBar();
            exportCsvBtn = new Button();
            listViewFiles = new ListView();
            SuspendLayout();
            // 
            // DirectoryPathTxt
            // 
            DirectoryPathTxt.Anchor = AnchorStyles.None;
            DirectoryPathTxt.Enabled = false;
            DirectoryPathTxt.Location = new Point(78, 12);
            DirectoryPathTxt.Name = "DirectoryPathTxt";
            DirectoryPathTxt.Size = new Size(480, 23);
            DirectoryPathTxt.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(14, 15);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 1;
            label1.Text = "Directory:";
            // 
            // loadPathBtn
            // 
            loadPathBtn.Anchor = AnchorStyles.None;
            loadPathBtn.Location = new Point(564, 15);
            loadPathBtn.Name = "loadPathBtn";
            loadPathBtn.Size = new Size(59, 23);
            loadPathBtn.TabIndex = 2;
            loadPathBtn.Text = "...";
            loadPathBtn.UseVisualStyleBackColor = true;
            loadPathBtn.Click += loadPathBtn_Click;
            // 
            // LoadCSVBtn
            // 
            LoadCSVBtn.Anchor = AnchorStyles.None;
            LoadCSVBtn.Location = new Point(564, 41);
            LoadCSVBtn.Name = "LoadCSVBtn";
            LoadCSVBtn.Size = new Size(59, 23);
            LoadCSVBtn.TabIndex = 6;
            LoadCSVBtn.Text = "...";
            LoadCSVBtn.UseVisualStyleBackColor = true;
            LoadCSVBtn.Click += LoadCSVBtn_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(14, 44);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 5;
            label2.Text = "CSV FIle:";
            // 
            // CSVPathTXT
            // 
            CSVPathTXT.Anchor = AnchorStyles.None;
            CSVPathTXT.Enabled = false;
            CSVPathTXT.Location = new Point(78, 41);
            CSVPathTXT.Name = "CSVPathTXT";
            CSVPathTXT.Size = new Size(480, 23);
            CSVPathTXT.TabIndex = 4;
            // 
            // ExportBtn
            // 
            ExportBtn.Anchor = AnchorStyles.None;
            ExportBtn.Location = new Point(629, 41);
            ExportBtn.Name = "ExportBtn";
            ExportBtn.Size = new Size(131, 23);
            ExportBtn.TabIndex = 6;
            ExportBtn.Text = "Export Changed FIles";
            ExportBtn.UseVisualStyleBackColor = true;
            ExportBtn.Click += ExportBtn_Click;
            // 
            // prgBar
            // 
            prgBar.Anchor = AnchorStyles.None;
            prgBar.Location = new Point(14, 70);
            prgBar.Name = "prgBar";
            prgBar.Size = new Size(746, 23);
            prgBar.TabIndex = 7;
            // 
            // exportCsvBtn
            // 
            exportCsvBtn.Anchor = AnchorStyles.None;
            exportCsvBtn.Location = new Point(629, 15);
            exportCsvBtn.Name = "exportCsvBtn";
            exportCsvBtn.Size = new Size(131, 23);
            exportCsvBtn.TabIndex = 6;
            exportCsvBtn.Text = "Export CSV";
            exportCsvBtn.UseVisualStyleBackColor = true;
            exportCsvBtn.Click += exportCsvBtn_Click;
            // 
            // listViewFiles
            // 
            listViewFiles.Location = new Point(14, 99);
            listViewFiles.Name = "listViewFiles";
            listViewFiles.Size = new Size(744, 470);
            listViewFiles.TabIndex = 8;
            listViewFiles.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 581);
            Controls.Add(listViewFiles);
            Controls.Add(prgBar);
            Controls.Add(exportCsvBtn);
            Controls.Add(ExportBtn);
            Controls.Add(LoadCSVBtn);
            Controls.Add(label2);
            Controls.Add(CSVPathTXT);
            Controls.Add(loadPathBtn);
            Controls.Add(label1);
            Controls.Add(DirectoryPathTxt);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Text = "FileHashSync";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DirectoryPathTxt;
        private Label label1;
        private Button loadPathBtn;
        private Button LoadCSVBtn;
        private Label label2;
        private TextBox CSVPathTXT;
        private Button ExportBtn;
        private ProgressBar prgBar;
        private Button exportCsvBtn;
        private ListView listViewFiles;
    }
}
