
namespace UnitConverter
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
            this.grpbxConversionTypes = new System.Windows.Forms.GroupBox();
            this.rdBtnWeight = new System.Windows.Forms.RadioButton();
            this.rdBtnTemperature = new System.Windows.Forms.RadioButton();
            this.rdBtnSpeed = new System.Windows.Forms.RadioButton();
            this.rdBtnDistance = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBxData = new System.Windows.Forms.GroupBox();
            this.lblTxtTo = new System.Windows.Forms.Label();
            this.lblTxtValue = new System.Windows.Forms.Label();
            this.lblTxtFrom = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.nmTxBxToConvert = new UnitConverter.Controls.NumericTextBox();
            this.lstBxConvertTo = new System.Windows.Forms.ListBox();
            this.lstBxConvertFrom = new System.Windows.Forms.ListBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.grpbxConversionTypes.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grpBxData.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxConversionTypes
            // 
            this.grpbxConversionTypes.Controls.Add(this.rdBtnWeight);
            this.grpbxConversionTypes.Controls.Add(this.rdBtnTemperature);
            this.grpbxConversionTypes.Controls.Add(this.rdBtnSpeed);
            this.grpbxConversionTypes.Controls.Add(this.rdBtnDistance);
            this.grpbxConversionTypes.Location = new System.Drawing.Point(12, 27);
            this.grpbxConversionTypes.Name = "grpbxConversionTypes";
            this.grpbxConversionTypes.Size = new System.Drawing.Size(135, 167);
            this.grpbxConversionTypes.TabIndex = 0;
            this.grpbxConversionTypes.TabStop = false;
            this.grpbxConversionTypes.Text = "Conversion Types";
            // 
            // rdBtnWeight
            // 
            this.rdBtnWeight.AutoSize = true;
            this.rdBtnWeight.Location = new System.Drawing.Point(15, 97);
            this.rdBtnWeight.Name = "rdBtnWeight";
            this.rdBtnWeight.Size = new System.Drawing.Size(63, 19);
            this.rdBtnWeight.TabIndex = 3;
            this.rdBtnWeight.TabStop = true;
            this.rdBtnWeight.Text = "Weight";
            this.rdBtnWeight.UseVisualStyleBackColor = true;
            this.rdBtnWeight.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdBtnTemperature
            // 
            this.rdBtnTemperature.AutoSize = true;
            this.rdBtnTemperature.Location = new System.Drawing.Point(15, 72);
            this.rdBtnTemperature.Name = "rdBtnTemperature";
            this.rdBtnTemperature.Size = new System.Drawing.Size(91, 19);
            this.rdBtnTemperature.TabIndex = 2;
            this.rdBtnTemperature.TabStop = true;
            this.rdBtnTemperature.Text = "Temperature";
            this.rdBtnTemperature.UseVisualStyleBackColor = true;
            this.rdBtnTemperature.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdBtnSpeed
            // 
            this.rdBtnSpeed.AutoSize = true;
            this.rdBtnSpeed.Location = new System.Drawing.Point(15, 47);
            this.rdBtnSpeed.Name = "rdBtnSpeed";
            this.rdBtnSpeed.Size = new System.Drawing.Size(57, 19);
            this.rdBtnSpeed.TabIndex = 1;
            this.rdBtnSpeed.TabStop = true;
            this.rdBtnSpeed.Text = "Speed";
            this.rdBtnSpeed.UseVisualStyleBackColor = true;
            this.rdBtnSpeed.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdBtnDistance
            // 
            this.rdBtnDistance.AutoSize = true;
            this.rdBtnDistance.Location = new System.Drawing.Point(15, 22);
            this.rdBtnDistance.Name = "rdBtnDistance";
            this.rdBtnDistance.Size = new System.Drawing.Size(75, 19);
            this.rdBtnDistance.TabIndex = 0;
            this.rdBtnDistance.TabStop = true;
            this.rdBtnDistance.Text = "Distances";
            this.rdBtnDistance.UseVisualStyleBackColor = true;
            this.rdBtnDistance.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(599, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // grpBxData
            // 
            this.grpBxData.Controls.Add(this.lblTxtTo);
            this.grpBxData.Controls.Add(this.lblTxtValue);
            this.grpBxData.Controls.Add(this.lblTxtFrom);
            this.grpBxData.Controls.Add(this.btnCalculate);
            this.grpBxData.Controls.Add(this.nmTxBxToConvert);
            this.grpBxData.Controls.Add(this.lstBxConvertTo);
            this.grpBxData.Controls.Add(this.lstBxConvertFrom);
            this.grpBxData.Location = new System.Drawing.Point(153, 27);
            this.grpBxData.Name = "grpBxData";
            this.grpBxData.Size = new System.Drawing.Size(433, 116);
            this.grpBxData.TabIndex = 2;
            this.grpBxData.TabStop = false;
            this.grpBxData.Text = "Data";
            // 
            // lblTxtTo
            // 
            this.lblTxtTo.AutoSize = true;
            this.lblTxtTo.Location = new System.Drawing.Point(306, 17);
            this.lblTxtTo.Name = "lblTxtTo";
            this.lblTxtTo.Size = new System.Drawing.Size(46, 15);
            this.lblTxtTo.TabIndex = 5;
            this.lblTxtTo.Text = "lbltxtTo";
            // 
            // lblTxtValue
            // 
            this.lblTxtValue.AutoSize = true;
            this.lblTxtValue.Location = new System.Drawing.Point(8, 17);
            this.lblTxtValue.Name = "lblTxtValue";
            this.lblTxtValue.Size = new System.Drawing.Size(62, 15);
            this.lblTxtValue.TabIndex = 5;
            this.lblTxtValue.Text = "lbltxtValue";
            // 
            // lblTxtFrom
            // 
            this.lblTxtFrom.AutoSize = true;
            this.lblTxtFrom.Location = new System.Drawing.Point(169, 17);
            this.lblTxtFrom.Name = "lblTxtFrom";
            this.lblTxtFrom.Size = new System.Drawing.Size(62, 15);
            this.lblTxtFrom.TabIndex = 5;
            this.lblTxtFrom.Text = "lbltxtFrom";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(8, 72);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(155, 30);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // nmTxBxToConvert
            // 
            this.nmTxBxToConvert.Location = new System.Drawing.Point(8, 37);
            this.nmTxBxToConvert.Name = "nmTxBxToConvert";
            this.nmTxBxToConvert.Size = new System.Drawing.Size(155, 23);
            this.nmTxBxToConvert.TabIndex = 3;
            // 
            // lstBxConvertTo
            // 
            this.lstBxConvertTo.FormattingEnabled = true;
            this.lstBxConvertTo.ItemHeight = 15;
            this.lstBxConvertTo.Location = new System.Drawing.Point(306, 37);
            this.lstBxConvertTo.Name = "lstBxConvertTo";
            this.lstBxConvertTo.Size = new System.Drawing.Size(114, 64);
            this.lstBxConvertTo.TabIndex = 0;
            // 
            // lstBxConvertFrom
            // 
            this.lstBxConvertFrom.FormattingEnabled = true;
            this.lstBxConvertFrom.ItemHeight = 15;
            this.lstBxConvertFrom.Location = new System.Drawing.Point(169, 37);
            this.lstBxConvertFrom.Name = "lstBxConvertFrom";
            this.lstBxConvertFrom.Size = new System.Drawing.Size(114, 64);
            this.lstBxConvertFrom.TabIndex = 0;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(153, 160);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(55, 15);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "lblResult";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 206);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.grpBxData);
            this.Controls.Add(this.grpbxConversionTypes);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(615, 245);
            this.MinimumSize = new System.Drawing.Size(615, 245);
            this.Name = "MainForm";
            this.Text = "Unit Converter APP";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpbxConversionTypes.ResumeLayout(false);
            this.grpbxConversionTypes.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpBxData.ResumeLayout(false);
            this.grpBxData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxConversionTypes;
        private System.Windows.Forms.RadioButton rdBtnWeight;
        private System.Windows.Forms.RadioButton rdBtnTemperature;
        private System.Windows.Forms.RadioButton rdBtnSpeed;
        private System.Windows.Forms.RadioButton rdBtnDistance;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpBxData;
        private System.Windows.Forms.ListBox lstBxConvertTo;
        private System.Windows.Forms.ListBox lstBxConvertFrom;
        private Controls.NumericTextBox nmTxBxToConvert;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblTxtTo;
        private System.Windows.Forms.Label lblTxtFrom;
        private System.Windows.Forms.Label lblTxtValue;
    }
}

