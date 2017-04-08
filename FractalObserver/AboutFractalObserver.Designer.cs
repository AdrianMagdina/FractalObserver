namespace FractalObserverApplication
{
    partial class AboutFractalObserverDialog
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
            this.components = new System.ComponentModel.Container();
            this.timerAboutProgram = new System.Windows.Forms.Timer(this.components);
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timerAboutProgram
            // 
            this.timerAboutProgram.Interval = 10;
            this.timerAboutProgram.Tick += new System.EventHandler(this.timerAboutProgram_Tick);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(109, 156);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // AboutFractalObserverDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 191);
            this.Controls.Add(this.btnOk);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutFractalObserverDialog";
            this.Text = "About Fractal Observer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AboutFractalObserverDialog_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AboutFractalObserverDialog_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Timer timerAboutProgram;

    }
}