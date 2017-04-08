// programmed by Adrian Magdina in 2012
// in this file is the implementation of choose colors for fractals dialog
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FractalObserverApplication
{
    public partial class ConfigureFractalColorsDialog : Form
    {
        public ConfigureFractalColorsDialog()
        {
            InitializeComponent();

            myOk = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialogBackgroundColor.Color = BackgroundColor;
            if (colorDialogBackgroundColor.ShowDialog(this) == DialogResult.OK)
            {
                BackgroundColor = colorDialogBackgroundColor.Color;

                this.Refresh();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            colorDialogColor1.Color = Color1;
            if (colorDialogColor1.ShowDialog(this) == DialogResult.OK)
            {
                Color1 = colorDialogColor1.Color;

                this.Refresh();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            colorDialogColor2.Color = Color2;
            if (colorDialogColor2.ShowDialog(this) == DialogResult.OK)
            {
                Color2 = colorDialogColor2.Color;

                this.Refresh();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            colorDialogColor3.Color = Color3;
            if (colorDialogColor3.ShowDialog(this) == DialogResult.OK)
            {
                Color3 = colorDialogColor3.Color;

                this.Refresh();
            }
        }

        private void gbBackgroundColor_Paint(object sender, PaintEventArgs e)
        {
            Graphics aGraphics = gbBackgroundColor.CreateGraphics();

            Pen aPen = new Pen(Color.Black, 2);
            SolidBrush aBrush = new SolidBrush(BackgroundColor);

            aGraphics.FillRectangle(aBrush, 100, 15, 35, 35);
            aGraphics.DrawRectangle(aPen, 100, 15, 35, 35);

            aPen.Dispose();
            aBrush.Dispose();
        }

        private void gbColor1_Paint(object sender, PaintEventArgs e)
        {
            Graphics aGraphics = gbColor1.CreateGraphics();

            Pen aPen = new Pen(Color.Black, 2);
            SolidBrush aBrush = new SolidBrush(Color1);

            aGraphics.FillRectangle(aBrush, 100, 15, 35, 35);
            aGraphics.DrawRectangle(aPen, 100, 15, 35, 35);

            aPen.Dispose();
            aBrush.Dispose();
        }

        private void gbColor2_Paint(object sender, PaintEventArgs e)
        {
            Graphics aGraphics = gbColor2.CreateGraphics();

            Pen aPen = new Pen(Color.Black, 2);
            SolidBrush aBrush = new SolidBrush(Color2);

            aGraphics.FillRectangle(aBrush, 100, 15, 35, 35);
            aGraphics.DrawRectangle(aPen, 100, 15, 35, 35);

            aPen.Dispose();
            aBrush.Dispose();
        }

        private void gbColor3_Paint(object sender, PaintEventArgs e)
        {
            Graphics aGraphics = gbColor3.CreateGraphics();

            Pen aPen = new Pen(Color.Black, 2);
            SolidBrush aBrush = new SolidBrush(Color3);

            aGraphics.FillRectangle(aBrush, 100, 15, 35, 35);
            aGraphics.DrawRectangle(aPen, 100, 15, 35, 35);

            aPen.Dispose();
            aBrush.Dispose();
        }

        private void ConfigureFractalColorsDialog_Shown(object sender, EventArgs e)
        {
            tbBackgroundAlpha.Value = BackgroundAlpha;
            tbAlpha1.Value = Alpha1;
            tbAlpha2.Value = Alpha2;
            tbAlpha3.Value = Alpha3;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            BackgroundAlpha = tbBackgroundAlpha.Value;
            Alpha1 = tbAlpha1.Value;
            Alpha2 = tbAlpha2.Value;
            Alpha3 = tbAlpha3.Value;

            myOk = true;
        }

        private void ConfigureFractalColorsDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool aItemInvisible = false;
            if (tbBackgroundAlpha.Value == 0)
            {
                aItemInvisible = true;
            }
            else if (tbAlpha3.Value == 0)
            {
                aItemInvisible = true;
            }
            else if (tbAlpha2.Value == 0)
            {
                aItemInvisible = true;
            }
            else if (tbAlpha1.Value == 0)
            {
                aItemInvisible = true;
            }

            if (aItemInvisible && myOk == true)
            {
                DialogResult tempDialogResult = MessageBox.Show("At least one item has opacity set to zero, therefore it is not visible!\nIs it ok?",
                                "Item invisible", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, 0);
                if (tempDialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                    myOk = false;
                }
            }
        }

        public Color BackgroundColor
        {
            get
            {
                return myBackgroundColor;
            }
            set
            {
                myBackgroundColor = value;
            }
        }

        public Color Color1
        {
            get
            {
                return myColor1;
            }
            set
            {
                myColor1 = value;
            }
        }

        public Color Color2
        {
            get
            {
                return myColor2;
            }
            set
            {
                myColor2 = value;
            }
        }

        public Color Color3
        {
            get
            {
                return myColor3;
            }
            set
            {
                myColor3 = value;
            }
        }

        public int BackgroundAlpha
        {
            get
            {
                return myBackgroundAlpha;
            }
            set
            {
                myBackgroundAlpha = value;
            }
        }

        public int Alpha1
        {
            get
            {
                return myAlpha1;
            }
            set
            {
                myAlpha1 = value;
            }
        }

        public int Alpha2
        {
            get
            {
                return myAlpha2;
            }
            set
            {
                myAlpha2 = value;
            }
        }

        public int Alpha3
        {
            get
            {
                return myAlpha3;
            }
            set
            {
                myAlpha3 = value;
            }
        }

        private Color myBackgroundColor;
        private Color myColor1;
        private Color myColor2;
        private Color myColor3;

        private int myBackgroundAlpha = 0;
        private int myAlpha1 = 0;
        private int myAlpha2 = 0;
        private int myAlpha3 = 0;

        private bool myOk = false;
    }
}
