namespace FractalObserverApplication
{
    partial class ConfigureGridAndZoomRectangleDialog
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
            this.gbGridConfiguration = new System.Windows.Forms.GroupBox();
            this.lblOpacityGrid = new System.Windows.Forms.Label();
            this.tbSetGridAlpha = new System.Windows.Forms.TrackBar();
            this.lblVerticalSpacing = new System.Windows.Forms.Label();
            this.lblHorizontalSpacing = new System.Windows.Forms.Label();
            this.tbVerticalSpacing = new System.Windows.Forms.TextBox();
            this.tbHorizontalSpacing = new System.Windows.Forms.TextBox();
            this.btnSetGridColor = new System.Windows.Forms.Button();
            this.gbZoomingRectangleConfiguration = new System.Windows.Forms.GroupBox();
            this.lblOpacityZoomRectamgle = new System.Windows.Forms.Label();
            this.tbSetZoomRectangleAlpha = new System.Windows.Forms.TrackBar();
            this.btnSetZoomRectangleColor = new System.Windows.Forms.Button();
            this.colorDialogGrid = new System.Windows.Forms.ColorDialog();
            this.colorDialogZoomingRectangle = new System.Windows.Forms.ColorDialog();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbGridConfiguration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSetGridAlpha)).BeginInit();
            this.gbZoomingRectangleConfiguration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSetZoomRectangleAlpha)).BeginInit();
            this.SuspendLayout();
            // 
            // gbGridConfiguration
            // 
            this.gbGridConfiguration.Controls.Add(this.lblOpacityGrid);
            this.gbGridConfiguration.Controls.Add(this.tbSetGridAlpha);
            this.gbGridConfiguration.Controls.Add(this.lblVerticalSpacing);
            this.gbGridConfiguration.Controls.Add(this.lblHorizontalSpacing);
            this.gbGridConfiguration.Controls.Add(this.tbVerticalSpacing);
            this.gbGridConfiguration.Controls.Add(this.tbHorizontalSpacing);
            this.gbGridConfiguration.Controls.Add(this.btnSetGridColor);
            this.gbGridConfiguration.Location = new System.Drawing.Point(12, 12);
            this.gbGridConfiguration.Name = "gbGridConfiguration";
            this.gbGridConfiguration.Size = new System.Drawing.Size(363, 123);
            this.gbGridConfiguration.TabIndex = 0;
            this.gbGridConfiguration.TabStop = false;
            this.gbGridConfiguration.Text = "Grid Configuration";
            this.gbGridConfiguration.Paint += new System.Windows.Forms.PaintEventHandler(this.gbGridConfiguration_Paint);
            // 
            // lblOpacityGrid
            // 
            this.lblOpacityGrid.AutoSize = true;
            this.lblOpacityGrid.Location = new System.Drawing.Point(144, 84);
            this.lblOpacityGrid.Name = "lblOpacityGrid";
            this.lblOpacityGrid.Size = new System.Drawing.Size(49, 13);
            this.lblOpacityGrid.TabIndex = 5;
            this.lblOpacityGrid.Text = "Opacity :";
            // 
            // tbSetGridAlpha
            // 
            this.tbSetGridAlpha.LargeChange = 32;
            this.tbSetGridAlpha.Location = new System.Drawing.Point(199, 72);
            this.tbSetGridAlpha.Maximum = 255;
            this.tbSetGridAlpha.Name = "tbSetGridAlpha";
            this.tbSetGridAlpha.Size = new System.Drawing.Size(158, 45);
            this.tbSetGridAlpha.TabIndex = 3;
            this.tbSetGridAlpha.TickFrequency = 8;
            // 
            // lblVerticalSpacing
            // 
            this.lblVerticalSpacing.AutoSize = true;
            this.lblVerticalSpacing.Location = new System.Drawing.Point(6, 51);
            this.lblVerticalSpacing.Name = "lblVerticalSpacing";
            this.lblVerticalSpacing.Size = new System.Drawing.Size(84, 13);
            this.lblVerticalSpacing.TabIndex = 4;
            this.lblVerticalSpacing.Text = "Vertical Spacing";
            // 
            // lblHorizontalSpacing
            // 
            this.lblHorizontalSpacing.AutoSize = true;
            this.lblHorizontalSpacing.Location = new System.Drawing.Point(6, 25);
            this.lblHorizontalSpacing.Name = "lblHorizontalSpacing";
            this.lblHorizontalSpacing.Size = new System.Drawing.Size(96, 13);
            this.lblHorizontalSpacing.TabIndex = 3;
            this.lblHorizontalSpacing.Text = "Horizontal Spacing";
            // 
            // tbVerticalSpacing
            // 
            this.tbVerticalSpacing.Location = new System.Drawing.Point(108, 48);
            this.tbVerticalSpacing.MaxLength = 8;
            this.tbVerticalSpacing.Name = "tbVerticalSpacing";
            this.tbVerticalSpacing.Size = new System.Drawing.Size(44, 20);
            this.tbVerticalSpacing.TabIndex = 1;
            // 
            // tbHorizontalSpacing
            // 
            this.tbHorizontalSpacing.Location = new System.Drawing.Point(108, 22);
            this.tbHorizontalSpacing.MaxLength = 8;
            this.tbHorizontalSpacing.Name = "tbHorizontalSpacing";
            this.tbHorizontalSpacing.Size = new System.Drawing.Size(44, 20);
            this.tbHorizontalSpacing.TabIndex = 0;
            // 
            // btnSetGridColor
            // 
            this.btnSetGridColor.Location = new System.Drawing.Point(6, 84);
            this.btnSetGridColor.Name = "btnSetGridColor";
            this.btnSetGridColor.Size = new System.Drawing.Size(75, 23);
            this.btnSetGridColor.TabIndex = 2;
            this.btnSetGridColor.Text = "Set Color";
            this.btnSetGridColor.UseVisualStyleBackColor = true;
            this.btnSetGridColor.Click += new System.EventHandler(this.btnSetGridColor_Click);
            // 
            // gbZoomingRectangleConfiguration
            // 
            this.gbZoomingRectangleConfiguration.Controls.Add(this.lblOpacityZoomRectamgle);
            this.gbZoomingRectangleConfiguration.Controls.Add(this.tbSetZoomRectangleAlpha);
            this.gbZoomingRectangleConfiguration.Controls.Add(this.btnSetZoomRectangleColor);
            this.gbZoomingRectangleConfiguration.Location = new System.Drawing.Point(12, 141);
            this.gbZoomingRectangleConfiguration.Name = "gbZoomingRectangleConfiguration";
            this.gbZoomingRectangleConfiguration.Size = new System.Drawing.Size(363, 79);
            this.gbZoomingRectangleConfiguration.TabIndex = 1;
            this.gbZoomingRectangleConfiguration.TabStop = false;
            this.gbZoomingRectangleConfiguration.Text = "Zooming Rectangle Configuration";
            this.gbZoomingRectangleConfiguration.Paint += new System.Windows.Forms.PaintEventHandler(this.gbZoomingRectangleConfiguration_Paint);
            // 
            // lblOpacityZoomRectamgle
            // 
            this.lblOpacityZoomRectamgle.AutoSize = true;
            this.lblOpacityZoomRectamgle.Location = new System.Drawing.Point(144, 33);
            this.lblOpacityZoomRectamgle.Name = "lblOpacityZoomRectamgle";
            this.lblOpacityZoomRectamgle.Size = new System.Drawing.Size(49, 13);
            this.lblOpacityZoomRectamgle.TabIndex = 6;
            this.lblOpacityZoomRectamgle.Text = "Opacity :";
            // 
            // tbSetZoomRectangleAlpha
            // 
            this.tbSetZoomRectangleAlpha.LargeChange = 32;
            this.tbSetZoomRectangleAlpha.Location = new System.Drawing.Point(199, 28);
            this.tbSetZoomRectangleAlpha.Maximum = 255;
            this.tbSetZoomRectangleAlpha.Name = "tbSetZoomRectangleAlpha";
            this.tbSetZoomRectangleAlpha.Size = new System.Drawing.Size(158, 45);
            this.tbSetZoomRectangleAlpha.TabIndex = 5;
            this.tbSetZoomRectangleAlpha.TickFrequency = 8;
            // 
            // btnSetZoomRectangleColor
            // 
            this.btnSetZoomRectangleColor.Location = new System.Drawing.Point(6, 33);
            this.btnSetZoomRectangleColor.Name = "btnSetZoomRectangleColor";
            this.btnSetZoomRectangleColor.Size = new System.Drawing.Size(75, 23);
            this.btnSetZoomRectangleColor.TabIndex = 4;
            this.btnSetZoomRectangleColor.Text = "Set Color";
            this.btnSetZoomRectangleColor.UseVisualStyleBackColor = true;
            this.btnSetZoomRectangleColor.Click += new System.EventHandler(this.btnSetZoomRectangleColor_Click);
            // 
            // colorDialogGrid
            // 
            this.colorDialogGrid.FullOpen = true;
            // 
            // colorDialogZoomingRectangle
            // 
            this.colorDialogZoomingRectangle.FullOpen = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(110, 227);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(191, 227);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // ConfigureGridAndZoomRectangleDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 262);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gbZoomingRectangleConfiguration);
            this.Controls.Add(this.gbGridConfiguration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigureGridAndZoomRectangleDialog";
            this.Text = "Configure Grid";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigureGridAndZoomRectangleDialog_FormClosing);
            this.Shown += new System.EventHandler(this.ConfigureGridDialog_Shown);
            this.gbGridConfiguration.ResumeLayout(false);
            this.gbGridConfiguration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSetGridAlpha)).EndInit();
            this.gbZoomingRectangleConfiguration.ResumeLayout(false);
            this.gbZoomingRectangleConfiguration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSetZoomRectangleAlpha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGridConfiguration;
        private System.Windows.Forms.GroupBox gbZoomingRectangleConfiguration;
        private System.Windows.Forms.ColorDialog colorDialogGrid;
        private System.Windows.Forms.ColorDialog colorDialogZoomingRectangle;
        private System.Windows.Forms.Button btnSetGridColor;
        private System.Windows.Forms.Button btnSetZoomRectangleColor;
        private System.Windows.Forms.TextBox tbVerticalSpacing;
        private System.Windows.Forms.TextBox tbHorizontalSpacing;
        private System.Windows.Forms.Label lblVerticalSpacing;
        private System.Windows.Forms.Label lblHorizontalSpacing;
        private System.Windows.Forms.TrackBar tbSetGridAlpha;
        private System.Windows.Forms.TrackBar tbSetZoomRectangleAlpha;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblOpacityGrid;
        private System.Windows.Forms.Label lblOpacityZoomRectamgle;
    }
}