namespace FractalObserverApplication
{
    partial class ConfigureFractalColorsDialog
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
            this.gbBackgroundColor = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBackgroundAlpha = new System.Windows.Forms.TrackBar();
            this.btnSetBackgroundColor = new System.Windows.Forms.Button();
            this.gbColor1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAlpha1 = new System.Windows.Forms.TrackBar();
            this.btnSetColor1 = new System.Windows.Forms.Button();
            this.gbColor2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSetColor2 = new System.Windows.Forms.Button();
            this.tbAlpha2 = new System.Windows.Forms.TrackBar();
            this.gbColor3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSetColor3 = new System.Windows.Forms.Button();
            this.tbAlpha3 = new System.Windows.Forms.TrackBar();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.colorDialogBackgroundColor = new System.Windows.Forms.ColorDialog();
            this.colorDialogColor1 = new System.Windows.Forms.ColorDialog();
            this.colorDialogColor2 = new System.Windows.Forms.ColorDialog();
            this.colorDialogColor3 = new System.Windows.Forms.ColorDialog();
            this.gbBackgroundColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBackgroundAlpha)).BeginInit();
            this.gbColor1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAlpha1)).BeginInit();
            this.gbColor2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAlpha2)).BeginInit();
            this.gbColor3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAlpha3)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBackgroundColor
            // 
            this.gbBackgroundColor.Controls.Add(this.label1);
            this.gbBackgroundColor.Controls.Add(this.tbBackgroundAlpha);
            this.gbBackgroundColor.Controls.Add(this.btnSetBackgroundColor);
            this.gbBackgroundColor.Location = new System.Drawing.Point(13, 13);
            this.gbBackgroundColor.Name = "gbBackgroundColor";
            this.gbBackgroundColor.Size = new System.Drawing.Size(366, 59);
            this.gbBackgroundColor.TabIndex = 0;
            this.gbBackgroundColor.TabStop = false;
            this.gbBackgroundColor.Text = "Background Color";
            this.gbBackgroundColor.Paint += new System.Windows.Forms.PaintEventHandler(this.gbBackgroundColor_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Opacity :";
            // 
            // tbBackgroundAlpha
            // 
            this.tbBackgroundAlpha.LargeChange = 32;
            this.tbBackgroundAlpha.Location = new System.Drawing.Point(204, 8);
            this.tbBackgroundAlpha.Maximum = 255;
            this.tbBackgroundAlpha.Name = "tbBackgroundAlpha";
            this.tbBackgroundAlpha.Size = new System.Drawing.Size(156, 45);
            this.tbBackgroundAlpha.TabIndex = 1;
            this.tbBackgroundAlpha.TickFrequency = 8;
            // 
            // btnSetBackgroundColor
            // 
            this.btnSetBackgroundColor.Location = new System.Drawing.Point(6, 19);
            this.btnSetBackgroundColor.Name = "btnSetBackgroundColor";
            this.btnSetBackgroundColor.Size = new System.Drawing.Size(75, 23);
            this.btnSetBackgroundColor.TabIndex = 0;
            this.btnSetBackgroundColor.Text = "Set Color";
            this.btnSetBackgroundColor.UseVisualStyleBackColor = true;
            this.btnSetBackgroundColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbColor1
            // 
            this.gbColor1.Controls.Add(this.label5);
            this.gbColor1.Controls.Add(this.label2);
            this.gbColor1.Controls.Add(this.tbAlpha1);
            this.gbColor1.Controls.Add(this.btnSetColor1);
            this.gbColor1.Location = new System.Drawing.Point(13, 78);
            this.gbColor1.Name = "gbColor1";
            this.gbColor1.Size = new System.Drawing.Size(366, 59);
            this.gbColor1.TabIndex = 1;
            this.gbColor1.TabStop = false;
            this.gbColor1.Text = "1. Color";
            this.gbColor1.Paint += new System.Windows.Forms.PaintEventHandler(this.gbColor1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Opacity :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // tbAlpha1
            // 
            this.tbAlpha1.LargeChange = 32;
            this.tbAlpha1.Location = new System.Drawing.Point(204, 8);
            this.tbAlpha1.Maximum = 255;
            this.tbAlpha1.Name = "tbAlpha1";
            this.tbAlpha1.Size = new System.Drawing.Size(156, 45);
            this.tbAlpha1.TabIndex = 1;
            this.tbAlpha1.TickFrequency = 8;
            // 
            // btnSetColor1
            // 
            this.btnSetColor1.Location = new System.Drawing.Point(7, 20);
            this.btnSetColor1.Name = "btnSetColor1";
            this.btnSetColor1.Size = new System.Drawing.Size(75, 23);
            this.btnSetColor1.TabIndex = 0;
            this.btnSetColor1.Text = "Set Color";
            this.btnSetColor1.UseVisualStyleBackColor = true;
            this.btnSetColor1.Click += new System.EventHandler(this.button4_Click);
            // 
            // gbColor2
            // 
            this.gbColor2.Controls.Add(this.label3);
            this.gbColor2.Controls.Add(this.btnSetColor2);
            this.gbColor2.Controls.Add(this.tbAlpha2);
            this.gbColor2.Location = new System.Drawing.Point(13, 144);
            this.gbColor2.Name = "gbColor2";
            this.gbColor2.Size = new System.Drawing.Size(366, 59);
            this.gbColor2.TabIndex = 3;
            this.gbColor2.TabStop = false;
            this.gbColor2.Text = "2. Color";
            this.gbColor2.Paint += new System.Windows.Forms.PaintEventHandler(this.gbColor2_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Opacity :";
            // 
            // btnSetColor2
            // 
            this.btnSetColor2.Location = new System.Drawing.Point(7, 19);
            this.btnSetColor2.Name = "btnSetColor2";
            this.btnSetColor2.Size = new System.Drawing.Size(75, 23);
            this.btnSetColor2.TabIndex = 0;
            this.btnSetColor2.Text = "Set Color";
            this.btnSetColor2.UseVisualStyleBackColor = true;
            this.btnSetColor2.Click += new System.EventHandler(this.button5_Click);
            // 
            // tbAlpha2
            // 
            this.tbAlpha2.LargeChange = 32;
            this.tbAlpha2.Location = new System.Drawing.Point(204, 8);
            this.tbAlpha2.Maximum = 255;
            this.tbAlpha2.Name = "tbAlpha2";
            this.tbAlpha2.Size = new System.Drawing.Size(156, 45);
            this.tbAlpha2.TabIndex = 1;
            this.tbAlpha2.TickFrequency = 8;
            // 
            // gbColor3
            // 
            this.gbColor3.Controls.Add(this.label4);
            this.gbColor3.Controls.Add(this.btnSetColor3);
            this.gbColor3.Controls.Add(this.tbAlpha3);
            this.gbColor3.Location = new System.Drawing.Point(13, 210);
            this.gbColor3.Name = "gbColor3";
            this.gbColor3.Size = new System.Drawing.Size(366, 59);
            this.gbColor3.TabIndex = 4;
            this.gbColor3.TabStop = false;
            this.gbColor3.Text = "3. Color";
            this.gbColor3.Paint += new System.Windows.Forms.PaintEventHandler(this.gbColor3_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Opacity :";
            // 
            // btnSetColor3
            // 
            this.btnSetColor3.Location = new System.Drawing.Point(7, 19);
            this.btnSetColor3.Name = "btnSetColor3";
            this.btnSetColor3.Size = new System.Drawing.Size(75, 23);
            this.btnSetColor3.TabIndex = 0;
            this.btnSetColor3.Text = "Set Color";
            this.btnSetColor3.UseVisualStyleBackColor = true;
            this.btnSetColor3.Click += new System.EventHandler(this.button6_Click);
            // 
            // tbAlpha3
            // 
            this.tbAlpha3.LargeChange = 32;
            this.tbAlpha3.Location = new System.Drawing.Point(204, 8);
            this.tbAlpha3.Maximum = 255;
            this.tbAlpha3.Name = "tbAlpha3";
            this.tbAlpha3.Size = new System.Drawing.Size(156, 45);
            this.tbAlpha3.TabIndex = 1;
            this.tbAlpha3.TickFrequency = 8;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(115, 275);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(196, 275);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // colorDialogBackgroundColor
            // 
            this.colorDialogBackgroundColor.FullOpen = true;
            // 
            // colorDialogColor1
            // 
            this.colorDialogColor1.FullOpen = true;
            // 
            // colorDialogColor2
            // 
            this.colorDialogColor2.FullOpen = true;
            // 
            // colorDialogColor3
            // 
            this.colorDialogColor3.FullOpen = true;
            // 
            // ConfigureFractalColorsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 308);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gbColor3);
            this.Controls.Add(this.gbColor2);
            this.Controls.Add(this.gbColor1);
            this.Controls.Add(this.gbBackgroundColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigureFractalColorsDialog";
            this.Text = "Configure Fractal Colors";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigureFractalColorsDialog_FormClosing);
            this.Shown += new System.EventHandler(this.ConfigureFractalColorsDialog_Shown);
            this.gbBackgroundColor.ResumeLayout(false);
            this.gbBackgroundColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBackgroundAlpha)).EndInit();
            this.gbColor1.ResumeLayout(false);
            this.gbColor1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAlpha1)).EndInit();
            this.gbColor2.ResumeLayout(false);
            this.gbColor2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAlpha2)).EndInit();
            this.gbColor3.ResumeLayout(false);
            this.gbColor3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAlpha3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBackgroundColor;
        private System.Windows.Forms.GroupBox gbColor1;
        private System.Windows.Forms.TrackBar tbBackgroundAlpha;
        private System.Windows.Forms.Button btnSetBackgroundColor;
        private System.Windows.Forms.GroupBox gbColor2;
        private System.Windows.Forms.GroupBox gbColor3;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSetColor1;
        private System.Windows.Forms.TrackBar tbAlpha1;
        private System.Windows.Forms.TrackBar tbAlpha2;
        private System.Windows.Forms.TrackBar tbAlpha3;
        private System.Windows.Forms.Button btnSetColor2;
        private System.Windows.Forms.Button btnSetColor3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColorDialog colorDialogBackgroundColor;
        private System.Windows.Forms.ColorDialog colorDialogColor1;
        private System.Windows.Forms.ColorDialog colorDialogColor2;
        private System.Windows.Forms.ColorDialog colorDialogColor3;
    }
}