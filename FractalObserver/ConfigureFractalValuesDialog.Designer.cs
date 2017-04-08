namespace FractalObserverApplication
{
    partial class ConfigureFractalValuesDialog
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
            this.btnOK = new System.Windows.Forms.Button();
            this.cbFractalType = new System.Windows.Forms.ComboBox();
            this.gbArea = new System.Windows.Forms.GroupBox();
            this.gbCurrentVisibleArea = new System.Windows.Forms.GroupBox();
            this.tbCurrentYEnd = new System.Windows.Forms.TextBox();
            this.tbCurrentYStart = new System.Windows.Forms.TextBox();
            this.tbCurrentXEnd = new System.Windows.Forms.TextBox();
            this.tbCurrentXStart = new System.Windows.Forms.TextBox();
            this.lblCurrentYEnd = new System.Windows.Forms.Label();
            this.lblCurrentXEnd = new System.Windows.Forms.Label();
            this.lblCurrentYStart = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentXStart = new System.Windows.Forms.Label();
            this.gbZoomArea = new System.Windows.Forms.GroupBox();
            this.btnSetZoomRectangleToCurrent = new System.Windows.Forms.Button();
            this.tbZoomXStart = new System.Windows.Forms.TextBox();
            this.lblZoomYEnd = new System.Windows.Forms.Label();
            this.tbZoomXEnd = new System.Windows.Forms.TextBox();
            this.lblZoomYStart = new System.Windows.Forms.Label();
            this.tbZoomYStart = new System.Windows.Forms.TextBox();
            this.lblZoomXEnd = new System.Windows.Forms.Label();
            this.tbZoomYEnd = new System.Windows.Forms.TextBox();
            this.lblZoomXStart = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblFractalType = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNewtonFractalEquation = new System.Windows.Forms.Label();
            this.cbFractalEquation = new System.Windows.Forms.ComboBox();
            this.gbArea.SuspendLayout();
            this.gbCurrentVisibleArea.SuspendLayout();
            this.gbZoomArea.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(70, 299);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cbFractalType
            // 
            this.cbFractalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFractalType.FormattingEnabled = true;
            this.cbFractalType.Location = new System.Drawing.Point(83, 9);
            this.cbFractalType.Name = "cbFractalType";
            this.cbFractalType.Size = new System.Drawing.Size(121, 21);
            this.cbFractalType.TabIndex = 0;
            this.cbFractalType.SelectionChangeCommitted += new System.EventHandler(this.cbFractalType_SelectionChangeCommitted);
            // 
            // gbArea
            // 
            this.gbArea.Controls.Add(this.gbCurrentVisibleArea);
            this.gbArea.Controls.Add(this.gbZoomArea);
            this.gbArea.Location = new System.Drawing.Point(12, 104);
            this.gbArea.Name = "gbArea";
            this.gbArea.Size = new System.Drawing.Size(276, 189);
            this.gbArea.TabIndex = 2;
            this.gbArea.TabStop = false;
            this.gbArea.Text = "Fractal Area";
            // 
            // gbCurrentVisibleArea
            // 
            this.gbCurrentVisibleArea.Controls.Add(this.tbCurrentYEnd);
            this.gbCurrentVisibleArea.Controls.Add(this.tbCurrentYStart);
            this.gbCurrentVisibleArea.Controls.Add(this.tbCurrentXEnd);
            this.gbCurrentVisibleArea.Controls.Add(this.tbCurrentXStart);
            this.gbCurrentVisibleArea.Controls.Add(this.lblCurrentYEnd);
            this.gbCurrentVisibleArea.Controls.Add(this.lblCurrentXEnd);
            this.gbCurrentVisibleArea.Controls.Add(this.lblCurrentYStart);
            this.gbCurrentVisibleArea.Controls.Add(this.label1);
            this.gbCurrentVisibleArea.Controls.Add(this.lblCurrentXStart);
            this.gbCurrentVisibleArea.Location = new System.Drawing.Point(139, 19);
            this.gbCurrentVisibleArea.Name = "gbCurrentVisibleArea";
            this.gbCurrentVisibleArea.Size = new System.Drawing.Size(126, 162);
            this.gbCurrentVisibleArea.TabIndex = 1;
            this.gbCurrentVisibleArea.TabStop = false;
            this.gbCurrentVisibleArea.Text = "Current visible area";
            // 
            // tbCurrentYEnd
            // 
            this.tbCurrentYEnd.Location = new System.Drawing.Point(55, 93);
            this.tbCurrentYEnd.MaxLength = 16;
            this.tbCurrentYEnd.Name = "tbCurrentYEnd";
            this.tbCurrentYEnd.Size = new System.Drawing.Size(65, 20);
            this.tbCurrentYEnd.TabIndex = 3;
            // 
            // tbCurrentYStart
            // 
            this.tbCurrentYStart.Location = new System.Drawing.Point(55, 70);
            this.tbCurrentYStart.MaxLength = 16;
            this.tbCurrentYStart.Name = "tbCurrentYStart";
            this.tbCurrentYStart.Size = new System.Drawing.Size(65, 20);
            this.tbCurrentYStart.TabIndex = 2;
            // 
            // tbCurrentXEnd
            // 
            this.tbCurrentXEnd.Location = new System.Drawing.Point(55, 43);
            this.tbCurrentXEnd.MaxLength = 16;
            this.tbCurrentXEnd.Name = "tbCurrentXEnd";
            this.tbCurrentXEnd.Size = new System.Drawing.Size(65, 20);
            this.tbCurrentXEnd.TabIndex = 1;
            // 
            // tbCurrentXStart
            // 
            this.tbCurrentXStart.Location = new System.Drawing.Point(54, 16);
            this.tbCurrentXStart.MaxLength = 16;
            this.tbCurrentXStart.Name = "tbCurrentXStart";
            this.tbCurrentXStart.Size = new System.Drawing.Size(66, 20);
            this.tbCurrentXStart.TabIndex = 0;
            // 
            // lblCurrentYEnd
            // 
            this.lblCurrentYEnd.AutoSize = true;
            this.lblCurrentYEnd.Location = new System.Drawing.Point(6, 97);
            this.lblCurrentYEnd.Name = "lblCurrentYEnd";
            this.lblCurrentYEnd.Size = new System.Drawing.Size(42, 13);
            this.lblCurrentYEnd.TabIndex = 8;
            this.lblCurrentYEnd.Text = "Y End :";
            // 
            // lblCurrentXEnd
            // 
            this.lblCurrentXEnd.AutoSize = true;
            this.lblCurrentXEnd.Location = new System.Drawing.Point(6, 46);
            this.lblCurrentXEnd.Name = "lblCurrentXEnd";
            this.lblCurrentXEnd.Size = new System.Drawing.Size(42, 13);
            this.lblCurrentXEnd.TabIndex = 6;
            this.lblCurrentXEnd.Text = "X End :";
            // 
            // lblCurrentYStart
            // 
            this.lblCurrentYStart.AutoSize = true;
            this.lblCurrentYStart.Location = new System.Drawing.Point(6, 71);
            this.lblCurrentYStart.Name = "lblCurrentYStart";
            this.lblCurrentYStart.Size = new System.Drawing.Size(45, 13);
            this.lblCurrentYStart.TabIndex = 4;
            this.lblCurrentYStart.Text = "Y Start :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // lblCurrentXStart
            // 
            this.lblCurrentXStart.AutoSize = true;
            this.lblCurrentXStart.Location = new System.Drawing.Point(7, 19);
            this.lblCurrentXStart.Name = "lblCurrentXStart";
            this.lblCurrentXStart.Size = new System.Drawing.Size(45, 13);
            this.lblCurrentXStart.TabIndex = 1;
            this.lblCurrentXStart.Text = "X Start :";
            // 
            // gbZoomArea
            // 
            this.gbZoomArea.Controls.Add(this.btnSetZoomRectangleToCurrent);
            this.gbZoomArea.Controls.Add(this.tbZoomXStart);
            this.gbZoomArea.Controls.Add(this.lblZoomYEnd);
            this.gbZoomArea.Controls.Add(this.tbZoomXEnd);
            this.gbZoomArea.Controls.Add(this.lblZoomYStart);
            this.gbZoomArea.Controls.Add(this.tbZoomYStart);
            this.gbZoomArea.Controls.Add(this.lblZoomXEnd);
            this.gbZoomArea.Controls.Add(this.tbZoomYEnd);
            this.gbZoomArea.Controls.Add(this.lblZoomXStart);
            this.gbZoomArea.Location = new System.Drawing.Point(6, 19);
            this.gbZoomArea.Name = "gbZoomArea";
            this.gbZoomArea.Size = new System.Drawing.Size(127, 162);
            this.gbZoomArea.TabIndex = 0;
            this.gbZoomArea.TabStop = false;
            this.gbZoomArea.Text = "Zoom rectangle area";
            // 
            // btnSetZoomRectangleToCurrent
            // 
            this.btnSetZoomRectangleToCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSetZoomRectangleToCurrent.Location = new System.Drawing.Point(6, 120);
            this.btnSetZoomRectangleToCurrent.Name = "btnSetZoomRectangleToCurrent";
            this.btnSetZoomRectangleToCurrent.Size = new System.Drawing.Size(115, 36);
            this.btnSetZoomRectangleToCurrent.TabIndex = 4;
            this.btnSetZoomRectangleToCurrent.Text = "Set Zoom Rectangle\r\nTo Current";
            this.btnSetZoomRectangleToCurrent.UseVisualStyleBackColor = true;
            this.btnSetZoomRectangleToCurrent.Click += new System.EventHandler(this.btnSetZoomRectangleToCurrent_Click);
            // 
            // tbZoomXStart
            // 
            this.tbZoomXStart.Location = new System.Drawing.Point(57, 19);
            this.tbZoomXStart.MaxLength = 16;
            this.tbZoomXStart.Name = "tbZoomXStart";
            this.tbZoomXStart.Size = new System.Drawing.Size(57, 20);
            this.tbZoomXStart.TabIndex = 0;
            // 
            // lblZoomYEnd
            // 
            this.lblZoomYEnd.AutoSize = true;
            this.lblZoomYEnd.Location = new System.Drawing.Point(6, 94);
            this.lblZoomYEnd.Name = "lblZoomYEnd";
            this.lblZoomYEnd.Size = new System.Drawing.Size(42, 13);
            this.lblZoomYEnd.TabIndex = 7;
            this.lblZoomYEnd.Text = "Y End :";
            // 
            // tbZoomXEnd
            // 
            this.tbZoomXEnd.Location = new System.Drawing.Point(57, 42);
            this.tbZoomXEnd.MaxLength = 16;
            this.tbZoomXEnd.Name = "tbZoomXEnd";
            this.tbZoomXEnd.Size = new System.Drawing.Size(57, 20);
            this.tbZoomXEnd.TabIndex = 1;
            // 
            // lblZoomYStart
            // 
            this.lblZoomYStart.AutoSize = true;
            this.lblZoomYStart.Location = new System.Drawing.Point(6, 68);
            this.lblZoomYStart.Name = "lblZoomYStart";
            this.lblZoomYStart.Size = new System.Drawing.Size(45, 13);
            this.lblZoomYStart.TabIndex = 6;
            this.lblZoomYStart.Text = "Y Start :";
            // 
            // tbZoomYStart
            // 
            this.tbZoomYStart.Location = new System.Drawing.Point(57, 68);
            this.tbZoomYStart.MaxLength = 16;
            this.tbZoomYStart.Name = "tbZoomYStart";
            this.tbZoomYStart.Size = new System.Drawing.Size(57, 20);
            this.tbZoomYStart.TabIndex = 2;
            // 
            // lblZoomXEnd
            // 
            this.lblZoomXEnd.AutoSize = true;
            this.lblZoomXEnd.Location = new System.Drawing.Point(6, 42);
            this.lblZoomXEnd.Name = "lblZoomXEnd";
            this.lblZoomXEnd.Size = new System.Drawing.Size(42, 13);
            this.lblZoomXEnd.TabIndex = 5;
            this.lblZoomXEnd.Text = "X End :";
            // 
            // tbZoomYEnd
            // 
            this.tbZoomYEnd.Location = new System.Drawing.Point(57, 94);
            this.tbZoomYEnd.MaxLength = 16;
            this.tbZoomYEnd.Name = "tbZoomYEnd";
            this.tbZoomYEnd.Size = new System.Drawing.Size(57, 20);
            this.tbZoomYEnd.TabIndex = 3;
            // 
            // lblZoomXStart
            // 
            this.lblZoomXStart.AutoSize = true;
            this.lblZoomXStart.Location = new System.Drawing.Point(6, 19);
            this.lblZoomXStart.Name = "lblZoomXStart";
            this.lblZoomXStart.Size = new System.Drawing.Size(45, 13);
            this.lblZoomXStart.TabIndex = 4;
            this.lblZoomXStart.Text = "X Start :";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(151, 299);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblFractalType
            // 
            this.lblFractalType.AutoSize = true;
            this.lblFractalType.Location = new System.Drawing.Point(9, 12);
            this.lblFractalType.Name = "lblFractalType";
            this.lblFractalType.Size = new System.Drawing.Size(68, 13);
            this.lblFractalType.TabIndex = 4;
            this.lblFractalType.Text = "Fractal type :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNewtonFractalEquation);
            this.groupBox1.Controls.Add(this.cbFractalEquation);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 58);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration for fractals with equation";
            // 
            // lblNewtonFractalEquation
            // 
            this.lblNewtonFractalEquation.AutoSize = true;
            this.lblNewtonFractalEquation.Location = new System.Drawing.Point(12, 23);
            this.lblNewtonFractalEquation.Name = "lblNewtonFractalEquation";
            this.lblNewtonFractalEquation.Size = new System.Drawing.Size(90, 13);
            this.lblNewtonFractalEquation.TabIndex = 1;
            this.lblNewtonFractalEquation.Text = "Fractal Equation :";
            // 
            // cbFractalEquation
            // 
            this.cbFractalEquation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFractalEquation.FormattingEnabled = true;
            this.cbFractalEquation.Location = new System.Drawing.Point(137, 20);
            this.cbFractalEquation.Name = "cbFractalEquation";
            this.cbFractalEquation.Size = new System.Drawing.Size(121, 21);
            this.cbFractalEquation.TabIndex = 0;
            // 
            // ConfigureFractalValuesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 330);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFractalType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbArea);
            this.Controls.Add(this.cbFractalType);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigureFractalValuesDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configure Fractal Values";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigureFractalValuesDialog_FormClosing);
            this.Shown += new System.EventHandler(this.ConfigureFractalObserverDialog_Shown);
            this.gbArea.ResumeLayout(false);
            this.gbCurrentVisibleArea.ResumeLayout(false);
            this.gbCurrentVisibleArea.PerformLayout();
            this.gbZoomArea.ResumeLayout(false);
            this.gbZoomArea.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cbFractalType;
        private System.Windows.Forms.GroupBox gbArea;
        private System.Windows.Forms.TextBox tbZoomYEnd;
        private System.Windows.Forms.TextBox tbZoomYStart;
        private System.Windows.Forms.TextBox tbZoomXEnd;
        private System.Windows.Forms.TextBox tbZoomXStart;
        private System.Windows.Forms.Label lblZoomYEnd;
        private System.Windows.Forms.Label lblZoomYStart;
        private System.Windows.Forms.Label lblZoomXEnd;
        private System.Windows.Forms.Label lblZoomXStart;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblFractalType;
        private System.Windows.Forms.GroupBox gbZoomArea;
        private System.Windows.Forms.GroupBox gbCurrentVisibleArea;
        private System.Windows.Forms.Label lblCurrentXStart;
        private System.Windows.Forms.Label lblCurrentYStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurrentXEnd;
        private System.Windows.Forms.Label lblCurrentYEnd;
        private System.Windows.Forms.TextBox tbCurrentYEnd;
        private System.Windows.Forms.TextBox tbCurrentYStart;
        private System.Windows.Forms.TextBox tbCurrentXEnd;
        private System.Windows.Forms.TextBox tbCurrentXStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNewtonFractalEquation;
        private System.Windows.Forms.ComboBox cbFractalEquation;
        private System.Windows.Forms.Button btnSetZoomRectangleToCurrent;
    }
}