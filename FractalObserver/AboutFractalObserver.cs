// programmed by Adrian Magdina in 2012
// in this file is the implementation of about dialog
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace FractalObserverApplication
{
    public partial class AboutFractalObserverDialog : Form
    {
        #region Constructors

        public AboutFractalObserverDialog()
        {
            InitializeComponent();

            myAppName = new RectangleF(90, 30, 120, 20);
            myMyName = new RectangleF(40, 60, 220, 20);
            myYear = new RectangleF(115, 90, 100, 20);
            myEMail = new RectangleF(60, 120, 180, 20);

            timerAboutProgram.Enabled = true;
            timerAboutProgram.Start();
        }

        #endregion

        #region Methods

        private void timerAboutProgram_Tick(object sender, EventArgs e)
        {
            if (myAlphaValue < 254)
            {
                myAlphaValue += 2;
            }

            this.Invalidate(new Rectangle((int)myAppName.X, (int)myAppName.Y, (int)myAppName.Width, (int)myAppName.Height));
            this.Invalidate(new Rectangle((int)myMyName.X, (int)myMyName.Y, (int)myMyName.Width, (int)myMyName.Height));
            this.Invalidate(new Rectangle((int)myYear.X, (int)myYear.Y, (int)myYear.Width, (int)myYear.Height));
            this.Invalidate(new Rectangle((int)myEMail.X, (int)myEMail.Y, (int)myEMail.Width, (int)myEMail.Height));

            this.Update();
        }

        private void AboutFractalObserverDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerAboutProgram.Stop();
            timerAboutProgram.Enabled = false;
        }

        private void AboutFractalObserverDialog_Paint(object sender, PaintEventArgs e)
        {
            Graphics aGraphics = e.Graphics;

            using (Brush aBrush = new LinearGradientBrush(new Point(50, 30), new Point(260, 140), Color.FromArgb(myAlphaValue, 0, 255, 0), Color.FromArgb(myAlphaValue, 0, 0, 255)))
            {
                using (Font aFont = new Font("Arial", 10.0f, FontStyle.Bold))
                {
                    String aAppName = "Fractal Observer";
                    String aMyName = "programmed by Adrian Magdina";
                    String aYear = "in 2012";
                    String aEmail = "adrian.magdina@yahoo.de";

                    aGraphics.DrawString(aAppName, aFont, aBrush, myAppName);
                    aGraphics.DrawString(aMyName, aFont, aBrush, myMyName);
                    aGraphics.DrawString(aYear, aFont, aBrush, myYear);
                    aGraphics.DrawString(aEmail, aFont, aBrush, myEMail);
                }
            }
        }

        #endregion

        #region Members

        private int myAlphaValue = 0;

        private RectangleF myAppName;
        private RectangleF myMyName;
        private RectangleF myYear;
        private RectangleF myEMail;

        #endregion
    }
}
