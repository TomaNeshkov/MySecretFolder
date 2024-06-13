namespace MySecretFolder
{
    partial class NewForm
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            textBoxFolderName = new TextBox();
            buttonEnter = new Button();
            errorProviderFolderName = new ErrorProvider(components);
            labelError = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProviderFolderName).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(54, 25);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(712, 74);
            label1.TabIndex = 0;
            label1.Text = "Please enter a name for your folder:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxFolderName
            // 
            textBoxFolderName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxFolderName.Location = new Point(54, 127);
            textBoxFolderName.Margin = new Padding(2);
            textBoxFolderName.Name = "textBoxFolderName";
            textBoxFolderName.Size = new Size(727, 27);
            textBoxFolderName.TabIndex = 1;
            textBoxFolderName.Validating += ValidateTextBoxFolderName;
            // 
            // buttonEnter
            // 
            buttonEnter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonEnter.Location = new Point(321, 198);
            buttonEnter.Margin = new Padding(2);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(171, 61);
            buttonEnter.TabIndex = 2;
            buttonEnter.Text = "Enter";
            buttonEnter.UseVisualStyleBackColor = true;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // errorProviderFolderName
            // 
            errorProviderFolderName.ContainerControl = this;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Location = new Point(54, 154);
            labelError.Margin = new Padding(2, 0, 2, 0);
            labelError.Name = "labelError";
            labelError.Size = new Size(15, 20);
            labelError.TabIndex = 3;
            labelError.Text = "*";
            // 
            // NewFolderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 298);
            Controls.Add(labelError);
            Controls.Add(buttonEnter);
            Controls.Add(textBoxFolderName);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "NewFolderForm";
            Text = "New Folder";
            ((System.ComponentModel.ISupportInitialize)errorProviderFolderName).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxFolderName;
        private Button buttonEnter;
        private ErrorProvider errorProviderFolderName;
        private Label labelError;
    }
}