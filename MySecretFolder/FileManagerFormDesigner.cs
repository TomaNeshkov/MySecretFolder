namespace MySecretFolder
{
    partial class FileManagerForm
    {
 
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileManagerForm));
            label1 = new Label();
            imageListIcon = new ImageList(components);
            listViewFiles = new ListView();
            labelFileInfo = new Label();
            label2 = new Label();
            labelFileNameValue = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            buttonBack = new Button();
            textBoxFilePath = new TextBox();
            buttonUploadFile = new Button();
            buttonCreateFile = new Button();
            buttonCreateFolder = new Button();
            buttonRefresh = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(53, 22);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(768, 52);
            label1.TabIndex = 0;
            label1.Text = "Welcome to your own secret folder";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // imageListIcon
            // 
            imageListIcon.ColorDepth = ColorDepth.Depth8Bit;
            imageListIcon.ImageStream = (ImageListStreamer)resources.GetObject("imageListIcon.ImageStream");
            imageListIcon.TransparentColor = Color.Transparent;
            imageListIcon.Images.SetKeyName(0, "icons8-pptx-48.png");
            imageListIcon.Images.SetKeyName(1, "icons8-zip-48.png");
            imageListIcon.Images.SetKeyName(2, "icons8-doc-48.png");
            imageListIcon.Images.SetKeyName(3, "icons8-pdf-48.png");
            imageListIcon.Images.SetKeyName(4, "icons8-mp3-48.png");
            imageListIcon.Images.SetKeyName(5, "icons8-file-48.png");
            imageListIcon.Images.SetKeyName(6, "icons8-folder-48.png");
            imageListIcon.Images.SetKeyName(7, "icons8-exe-48.png");
            imageListIcon.Images.SetKeyName(8, "icons8-png-48.png");
            imageListIcon.Images.SetKeyName(9, "icons8-txt-48.png");
            // 
            // listViewFiles
            // 
            listViewFiles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewFiles.LargeImageList = imageListIcon;
            listViewFiles.Location = new Point(30, 124);
            listViewFiles.Margin = new Padding(2, 2, 2, 2);
            listViewFiles.Name = "listViewFiles";
            listViewFiles.Size = new Size(792, 136);
            listViewFiles.TabIndex = 1;
            listViewFiles.UseCompatibleStateImageBehavior = false;
            listViewFiles.ItemSelectionChanged += listViewFiles_ItemSelectionChanged;
            listViewFiles.DragDrop += listViewFiles_DragDrop;
            listViewFiles.DragEnter += listViewFiles_DragEnter;
            listViewFiles.KeyDown += listViewFiles_KeyDown;
            listViewFiles.MouseClick += listViewFiles_MouseClick;
            listViewFiles.MouseDoubleClick += listViewFiles_MouseDoubleClick;
            listViewFiles.MouseDown += listViewFiles_MouseDown;
            listViewFiles.MouseMove += listViewFiles_MouseMove;
            listViewFiles.MouseUp += listViewFiles_MouseUp;
            // 
            // labelFileInfo
            // 
            labelFileInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelFileInfo.AutoSize = true;
            labelFileInfo.Location = new Point(53, 261);
            labelFileInfo.Margin = new Padding(2, 0, 2, 0);
            labelFileInfo.Name = "labelFileInfo";
            labelFileInfo.Size = new Size(21, 20);
            labelFileInfo.TabIndex = 2;
            labelFileInfo.Text = "--";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(53, 362);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 2;
            label2.Text = "File name:";
            // 
            // labelFileNameValue
            // 
            labelFileNameValue.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelFileNameValue.AutoSize = true;
            labelFileNameValue.Location = new Point(124, 365);
            labelFileNameValue.Margin = new Padding(2, 0, 2, 0);
            labelFileNameValue.Name = "labelFileNameValue";
            labelFileNameValue.Size = new Size(21, 20);
            labelFileNameValue.TabIndex = 2;
            labelFileNameValue.Text = "--";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(53, 295);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(175, 20);
            label3.TabIndex = 2;
            label3.Text = "[DELETE] - deletes a file";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(53, 315);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(288, 20);
            label4.TabIndex = 2;
            label4.Text = "[BACKSACE] - moves the file backwards";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(53, 335);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(312, 20);
            label5.TabIndex = 2;
            label5.Text = "[DRAG&DROP] - moves files into each folder";
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(30, 92);
            buttonBack.Margin = new Padding(2, 2, 2, 2);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(57, 27);
            buttonBack.TabIndex = 3;
            buttonBack.Text = "<";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // textBoxFilePath
            // 
            textBoxFilePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxFilePath.Location = new Point(95, 93);
            textBoxFilePath.Margin = new Padding(2, 2, 2, 2);
            textBoxFilePath.Name = "textBoxFilePath";
            textBoxFilePath.Size = new Size(607, 27);
            textBoxFilePath.TabIndex = 4;
            // 
            // buttonUploadFile
            // 
            buttonUploadFile.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonUploadFile.Location = new Point(559, 362);
            buttonUploadFile.Margin = new Padding(2, 2, 2, 2);
            buttonUploadFile.Name = "buttonUploadFile";
            buttonUploadFile.Size = new Size(127, 27);
            buttonUploadFile.TabIndex = 5;
            buttonUploadFile.Text = "Upload File";
            buttonUploadFile.UseVisualStyleBackColor = true;
            buttonUploadFile.Click += buttonUploadFile_Click;
            // 
            // buttonCreateFile
            // 
            buttonCreateFile.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCreateFile.Location = new Point(693, 362);
            buttonCreateFile.Margin = new Padding(2, 2, 2, 2);
            buttonCreateFile.Name = "buttonCreateFile";
            buttonCreateFile.Size = new Size(127, 27);
            buttonCreateFile.TabIndex = 6;
            buttonCreateFile.Text = "Create File";
            buttonCreateFile.UseVisualStyleBackColor = true;
            buttonCreateFile.Click += buttonCreateFile_Click;
            // 
            // buttonCreateFolder
            // 
            buttonCreateFolder.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCreateFolder.Location = new Point(559, 274);
            buttonCreateFolder.Margin = new Padding(2, 2, 2, 2);
            buttonCreateFolder.Name = "buttonCreateFolder";
            buttonCreateFolder.Size = new Size(261, 80);
            buttonCreateFolder.TabIndex = 7;
            buttonCreateFolder.Text = "Create Folder";
            buttonCreateFolder.UseVisualStyleBackColor = true;
            buttonCreateFolder.Click += buttonCreateFolder_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(687, 93);
            buttonRefresh.Margin = new Padding(2, 2, 2, 2);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(117, 27);
            buttonRefresh.TabIndex = 8;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // FileManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 409);
            Controls.Add(buttonRefresh);
            Controls.Add(buttonCreateFolder);
            Controls.Add(buttonCreateFile);
            Controls.Add(buttonUploadFile);
            Controls.Add(textBoxFilePath);
            Controls.Add(buttonBack);
            Controls.Add(labelFileNameValue);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(labelFileInfo);
            Controls.Add(listViewFiles);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FileManagerForm";
            Text = "File Manager";
            Load += FileManagerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ImageList imageListIcon;
        private ListView listViewFiles;
        private Label labelFileInfo;
        private Label label2;
        private Label labelFileNameValue;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button buttonBack;
        private TextBox textBoxFilePath;
        private Button buttonUploadFile;
        private Button buttonCreateFile;
        private Button buttonCreateFolder;
        private Button buttonRefresh;
    }
}
