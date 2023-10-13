namespace BarcodeGenerator
{
    partial class MainForm
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
            _generateButton = new Button();
            _textBox = new TextBox();
            _previewBox = new PictureBox();
            _panel1 = new Panel();
            _tableLayoutPanel2 = new TableLayoutPanel();
            _tableLayoutPanel1 = new TableLayoutPanel();
            _barcodeSettingsGroupBox = new GroupBox();
            _barcodeHeightTextBox = new TextBox();
            _barcodeHeightLabel = new Label();
            _barcodeWidthTextBox = new TextBox();
            _barcodeWidthLabel = new Label();
            _barcodeFormatComboBox = new ComboBox();
            _barcodeFormatLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)_previewBox).BeginInit();
            _panel1.SuspendLayout();
            _tableLayoutPanel2.SuspendLayout();
            _tableLayoutPanel1.SuspendLayout();
            _barcodeSettingsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // _generateButton
            // 
            _generateButton.Dock = DockStyle.Bottom;
            _generateButton.Location = new Point(370, 210);
            _generateButton.Margin = new Padding(2);
            _generateButton.Name = "_generateButton";
            _generateButton.Size = new Size(88, 25);
            _generateButton.TabIndex = 0;
            _generateButton.Text = "Generate";
            _generateButton.UseVisualStyleBackColor = true;
            _generateButton.Click += HandleGenerateButtonClicked;
            // 
            // _textBox
            // 
            _textBox.Dock = DockStyle.Fill;
            _textBox.Location = new Point(2, 2);
            _textBox.Margin = new Padding(2);
            _textBox.Multiline = true;
            _textBox.Name = "_textBox";
            _textBox.Size = new Size(364, 233);
            _textBox.TabIndex = 1;
            // 
            // _previewBox
            // 
            _previewBox.BorderStyle = BorderStyle.Fixed3D;
            _previewBox.Dock = DockStyle.Fill;
            _previewBox.Location = new Point(2, 2);
            _previewBox.Margin = new Padding(2);
            _previewBox.Name = "_previewBox";
            _previewBox.Size = new Size(460, 236);
            _previewBox.SizeMode = PictureBoxSizeMode.CenterImage;
            _previewBox.TabIndex = 2;
            _previewBox.TabStop = false;
            // 
            // _panel1
            // 
            _panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _panel1.AutoSize = true;
            _panel1.Controls.Add(_tableLayoutPanel2);
            _panel1.Location = new Point(2, 362);
            _panel1.Margin = new Padding(2);
            _panel1.Name = "_panel1";
            _panel1.Size = new Size(460, 237);
            _panel1.TabIndex = 3;
            // 
            // _tableLayoutPanel2
            // 
            _tableLayoutPanel2.ColumnCount = 2;
            _tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            _tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            _tableLayoutPanel2.Controls.Add(_textBox, 0, 0);
            _tableLayoutPanel2.Controls.Add(_generateButton, 1, 0);
            _tableLayoutPanel2.Dock = DockStyle.Fill;
            _tableLayoutPanel2.Location = new Point(0, 0);
            _tableLayoutPanel2.Margin = new Padding(2);
            _tableLayoutPanel2.Name = "_tableLayoutPanel2";
            _tableLayoutPanel2.RowCount = 1;
            _tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            _tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _tableLayoutPanel2.Size = new Size(460, 237);
            _tableLayoutPanel2.TabIndex = 2;
            // 
            // _tableLayoutPanel1
            // 
            _tableLayoutPanel1.ColumnCount = 1;
            _tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            _tableLayoutPanel1.Controls.Add(_previewBox, 0, 0);
            _tableLayoutPanel1.Controls.Add(_panel1, 0, 2);
            _tableLayoutPanel1.Controls.Add(_barcodeSettingsGroupBox, 0, 1);
            _tableLayoutPanel1.Dock = DockStyle.Fill;
            _tableLayoutPanel1.Location = new Point(0, 0);
            _tableLayoutPanel1.Margin = new Padding(2);
            _tableLayoutPanel1.Name = "_tableLayoutPanel1";
            _tableLayoutPanel1.RowCount = 3;
            _tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            _tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            _tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            _tableLayoutPanel1.Size = new Size(464, 601);
            _tableLayoutPanel1.TabIndex = 6;
            // 
            // _barcodeSettingsGroupBox
            // 
            _barcodeSettingsGroupBox.Controls.Add(_barcodeHeightTextBox);
            _barcodeSettingsGroupBox.Controls.Add(_barcodeHeightLabel);
            _barcodeSettingsGroupBox.Controls.Add(_barcodeWidthTextBox);
            _barcodeSettingsGroupBox.Controls.Add(_barcodeWidthLabel);
            _barcodeSettingsGroupBox.Controls.Add(_barcodeFormatComboBox);
            _barcodeSettingsGroupBox.Controls.Add(_barcodeFormatLabel);
            _barcodeSettingsGroupBox.Dock = DockStyle.Fill;
            _barcodeSettingsGroupBox.Location = new Point(2, 242);
            _barcodeSettingsGroupBox.Margin = new Padding(2);
            _barcodeSettingsGroupBox.Name = "_barcodeSettingsGroupBox";
            _barcodeSettingsGroupBox.Padding = new Padding(2);
            _barcodeSettingsGroupBox.Size = new Size(460, 116);
            _barcodeSettingsGroupBox.TabIndex = 4;
            _barcodeSettingsGroupBox.TabStop = false;
            _barcodeSettingsGroupBox.Text = "Barcode Settings";
            // 
            // _barcodeHeightTextBox
            // 
            _barcodeHeightTextBox.Location = new Point(264, 68);
            _barcodeHeightTextBox.Margin = new Padding(2);
            _barcodeHeightTextBox.Name = "_barcodeHeightTextBox";
            _barcodeHeightTextBox.Size = new Size(121, 23);
            _barcodeHeightTextBox.TabIndex = 5;
            // 
            // _barcodeHeightLabel
            // 
            _barcodeHeightLabel.AutoSize = true;
            _barcodeHeightLabel.Location = new Point(211, 71);
            _barcodeHeightLabel.Margin = new Padding(2);
            _barcodeHeightLabel.Name = "_barcodeHeightLabel";
            _barcodeHeightLabel.Size = new Size(49, 17);
            _barcodeHeightLabel.TabIndex = 4;
            _barcodeHeightLabel.Text = "Height:";
            // 
            // _barcodeWidthTextBox
            // 
            _barcodeWidthTextBox.Location = new Point(67, 68);
            _barcodeWidthTextBox.Margin = new Padding(2);
            _barcodeWidthTextBox.Name = "_barcodeWidthTextBox";
            _barcodeWidthTextBox.Size = new Size(121, 23);
            _barcodeWidthTextBox.TabIndex = 3;
            // 
            // _barcodeWidthLabel
            // 
            _barcodeWidthLabel.AutoSize = true;
            _barcodeWidthLabel.Location = new Point(11, 71);
            _barcodeWidthLabel.Name = "_barcodeWidthLabel";
            _barcodeWidthLabel.Size = new Size(45, 17);
            _barcodeWidthLabel.TabIndex = 2;
            _barcodeWidthLabel.Text = "Width:";
            // 
            // _barcodeFormatComboBox
            // 
            _barcodeFormatComboBox.FormattingEnabled = true;
            _barcodeFormatComboBox.Location = new Point(67, 28);
            _barcodeFormatComboBox.Margin = new Padding(2);
            _barcodeFormatComboBox.Name = "_barcodeFormatComboBox";
            _barcodeFormatComboBox.Size = new Size(121, 25);
            _barcodeFormatComboBox.Sorted = true;
            _barcodeFormatComboBox.TabIndex = 1;
            // 
            // _barcodeFormatLabel
            // 
            _barcodeFormatLabel.AutoSize = true;
            _barcodeFormatLabel.Location = new Point(11, 31);
            _barcodeFormatLabel.Margin = new Padding(2);
            _barcodeFormatLabel.Name = "_barcodeFormatLabel";
            _barcodeFormatLabel.Size = new Size(52, 17);
            _barcodeFormatLabel.TabIndex = 0;
            _barcodeFormatLabel.Text = "Format:";
            _barcodeFormatLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 601);
            Controls.Add(_tableLayoutPanel1);
            Name = "MainForm";
            Text = "Barcode Generator";
            ((System.ComponentModel.ISupportInitialize)_previewBox).EndInit();
            _panel1.ResumeLayout(false);
            _tableLayoutPanel2.ResumeLayout(false);
            _tableLayoutPanel2.PerformLayout();
            _tableLayoutPanel1.ResumeLayout(false);
            _tableLayoutPanel1.PerformLayout();
            _barcodeSettingsGroupBox.ResumeLayout(false);
            _barcodeSettingsGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button _generateButton;
        private TextBox _textBox;
        private PictureBox _previewBox;
        private FlowLayoutPanel _flowLayoutPanel;
        private Panel _panel1;
        private TableLayoutPanel _tableLayoutPanel1;
        private TableLayoutPanel _tableLayoutPanel2;
        private GroupBox _barcodeSettingsGroupBox;
        private ComboBox comboBox1;
        private TextBox _barcodeHeightTextBox;
        private Label _barcodeHeightLabel;
        private TextBox _barcodeWidthTextBox;
        private Label _barcodeWidthLabel;
        private ComboBox _barcodeFormatComboBox;
        private Label _barcodeFormatLabel;
    }
}
