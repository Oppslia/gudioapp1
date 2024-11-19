namespace gudioapp1
{
    partial class Form1
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
            this.btnWebhook = new System.Windows.Forms.Button();
            this.btnConvertCaps = new System.Windows.Forms.Button();
            this.textToConvertBox = new System.Windows.Forms.TextBox();
            this.btnWriteData = new System.Windows.Forms.Button();
            this.btnReadCsv = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contentForListBox = new System.Windows.Forms.TextBox();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.fileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btnReadData = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.imgComboBox = new System.Windows.Forms.ComboBox();
            this.btnChangeBackgroundColor = new System.Windows.Forms.Button();
            this.fileDatatxtBox = new System.Windows.Forms.TextBox();
            this.imgDragArea = new System.Windows.Forms.GroupBox();
            this.btnAddToListBox = new System.Windows.Forms.Button();
            this.fileDialogCSV = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.imgDragArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWebhook
            // 
            this.btnWebhook.Location = new System.Drawing.Point(21, 79);
            this.btnWebhook.Name = "btnWebhook";
            this.btnWebhook.Size = new System.Drawing.Size(133, 23);
            this.btnWebhook.TabIndex = 0;
            this.btnWebhook.Text = "Post To a Webhook";
            this.btnWebhook.UseVisualStyleBackColor = true;
            this.btnWebhook.Click += new System.EventHandler(this.btnWebhook_Click);
            // 
            // btnConvertCaps
            // 
            this.btnConvertCaps.Location = new System.Drawing.Point(21, 162);
            this.btnConvertCaps.Name = "btnConvertCaps";
            this.btnConvertCaps.Size = new System.Drawing.Size(133, 60);
            this.btnConvertCaps.TabIndex = 1;
            this.btnConvertCaps.Text = "Make Textbox Text All Caps";
            this.btnConvertCaps.UseVisualStyleBackColor = true;
            this.btnConvertCaps.Click += new System.EventHandler(this.btnConvertCaps_Click);
            // 
            // textToConvertBox
            // 
            this.textToConvertBox.Location = new System.Drawing.Point(21, 129);
            this.textToConvertBox.Name = "textToConvertBox";
            this.textToConvertBox.Size = new System.Drawing.Size(133, 20);
            this.textToConvertBox.TabIndex = 2;
            // 
            // btnWriteData
            // 
            this.btnWriteData.Location = new System.Drawing.Point(636, 279);
            this.btnWriteData.Name = "btnWriteData";
            this.btnWriteData.Size = new System.Drawing.Size(152, 61);
            this.btnWriteData.TabIndex = 3;
            this.btnWriteData.Text = "Write Data to a file";
            this.btnWriteData.UseVisualStyleBackColor = true;
            this.btnWriteData.Click += new System.EventHandler(this.btnWriteData_Click);
            // 
            // btnReadCsv
            // 
            this.btnReadCsv.Location = new System.Drawing.Point(189, 69);
            this.btnReadCsv.Name = "btnReadCsv";
            this.btnReadCsv.Size = new System.Drawing.Size(227, 74);
            this.btnReadCsv.TabIndex = 4;
            this.btnReadCsv.Text = "Read a CSV";
            this.btnReadCsv.UseVisualStyleBackColor = true;
            this.btnReadCsv.Click += new System.EventHandler(this.btnReadCsv_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(21, 329);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 8;
            // 
            // contentForListBox
            // 
            this.contentForListBox.Location = new System.Drawing.Point(21, 262);
            this.contentForListBox.Name = "contentForListBox";
            this.contentForListBox.Size = new System.Drawing.Size(120, 20);
            this.contentForListBox.TabIndex = 9;
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.Location = new System.Drawing.Point(636, 377);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(152, 61);
            this.btnDeleteFile.TabIndex = 11;
            this.btnDeleteFile.Text = "Delete a File";
            this.btnDeleteFile.UseVisualStyleBackColor = true;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(636, 346);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(152, 23);
            this.btnOpenFile.TabIndex = 14;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnReadData
            // 
            this.btnReadData.Location = new System.Drawing.Point(636, 184);
            this.btnReadData.Name = "btnReadData";
            this.btnReadData.Size = new System.Drawing.Size(152, 89);
            this.btnReadData.TabIndex = 15;
            this.btnReadData.Text = "Read Data Of A File";
            this.btnReadData.UseVisualStyleBackColor = true;
            this.btnReadData.Click += new System.EventHandler(this.btnReadData_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(5, 46);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(140, 92);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 16;
            this.pictureBox.TabStop = false;
            // 
            // imgComboBox
            // 
            this.imgComboBox.FormattingEnabled = true;
            this.imgComboBox.Location = new System.Drawing.Point(5, 19);
            this.imgComboBox.Name = "imgComboBox";
            this.imgComboBox.Size = new System.Drawing.Size(140, 21);
            this.imgComboBox.TabIndex = 17;
            this.imgComboBox.SelectedIndexChanged += new System.EventHandler(this.imgComboBox_SelectedIndexChanged);
            // 
            // btnChangeBackgroundColor
            // 
            this.btnChangeBackgroundColor.Location = new System.Drawing.Point(416, 284);
            this.btnChangeBackgroundColor.Name = "btnChangeBackgroundColor";
            this.btnChangeBackgroundColor.Size = new System.Drawing.Size(188, 89);
            this.btnChangeBackgroundColor.TabIndex = 18;
            this.btnChangeBackgroundColor.Text = "Change Background Color";
            this.btnChangeBackgroundColor.UseVisualStyleBackColor = true;
            this.btnChangeBackgroundColor.Click += new System.EventHandler(this.btnChangeBackgroundColor_Click);
            // 
            // fileDatatxtBox
            // 
            this.fileDatatxtBox.Location = new System.Drawing.Point(636, 61);
            this.fileDatatxtBox.Multiline = true;
            this.fileDatatxtBox.Name = "fileDatatxtBox";
            this.fileDatatxtBox.Size = new System.Drawing.Size(152, 117);
            this.fileDatatxtBox.TabIndex = 19;
            // 
            // imgDragArea
            // 
            this.imgDragArea.AutoSize = true;
            this.imgDragArea.Controls.Add(this.imgComboBox);
            this.imgDragArea.Controls.Add(this.pictureBox);
            this.imgDragArea.Location = new System.Drawing.Point(184, 300);
            this.imgDragArea.Name = "imgDragArea";
            this.imgDragArea.Size = new System.Drawing.Size(154, 157);
            this.imgDragArea.TabIndex = 20;
            this.imgDragArea.TabStop = false;
            this.imgDragArea.DragDrop += new System.Windows.Forms.DragEventHandler(this.imgDragArea_DragDrop);
            this.imgDragArea.DragEnter += new System.Windows.Forms.DragEventHandler(this.imgDragArea_DragEnter);
            // 
            // btnAddToListBox
            // 
            this.btnAddToListBox.Location = new System.Drawing.Point(21, 300);
            this.btnAddToListBox.Name = "btnAddToListBox";
            this.btnAddToListBox.Size = new System.Drawing.Size(120, 23);
            this.btnAddToListBox.TabIndex = 21;
            this.btnAddToListBox.Text = "Add to list";
            this.btnAddToListBox.UseVisualStyleBackColor = true;
            this.btnAddToListBox.Click += new System.EventHandler(this.btnAddToListBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddToListBox);
            this.Controls.Add(this.imgDragArea);
            this.Controls.Add(this.fileDatatxtBox);
            this.Controls.Add(this.btnChangeBackgroundColor);
            this.Controls.Add(this.btnReadData);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnDeleteFile);
            this.Controls.Add(this.contentForListBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnReadCsv);
            this.Controls.Add(this.btnWriteData);
            this.Controls.Add(this.textToConvertBox);
            this.Controls.Add(this.btnConvertCaps);
            this.Controls.Add(this.btnWebhook);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.imgDragArea.ResumeLayout(false);
            this.imgDragArea.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWebhook;
        private System.Windows.Forms.Button btnConvertCaps;
        private System.Windows.Forms.TextBox textToConvertBox;
        private System.Windows.Forms.Button btnWriteData;
        private System.Windows.Forms.Button btnReadCsv;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox contentForListBox;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.OpenFileDialog fileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btnReadData;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox imgComboBox;
        private System.Windows.Forms.Button btnChangeBackgroundColor;
        private System.Windows.Forms.TextBox fileDatatxtBox;
        private System.Windows.Forms.GroupBox imgDragArea;
        private System.Windows.Forms.Button btnAddToListBox;
        private System.Windows.Forms.OpenFileDialog fileDialogCSV;
    }
}

