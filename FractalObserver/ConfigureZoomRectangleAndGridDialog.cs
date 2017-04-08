// programmed by Adrian Magdina in 2012
// in this file is the implementation of dialog for input of values for configuration of zooming rectangle and grid dialog
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace FractalObserverApplication
{
    public partial class ConfigureGridAndZoomRectangleDialog : Form
    {
        #region Constructors

        public ConfigureGridAndZoomRectangleDialog()
        {
            InitializeComponent();

            myOk = false;
            myCanClose = true;
        }
        
        #endregion

        #region Methods

        private void btnSetGridColor_Click(object sender, EventArgs e)
        {
            colorDialogGrid.Color = GridColor;
            if (colorDialogGrid.ShowDialog(this) == DialogResult.OK)
            {
                GridColor = colorDialogGrid.Color;

                this.Refresh();
            }
        }

        private void btnSetZoomRectangleColor_Click(object sender, EventArgs e)
        {
            colorDialogZoomingRectangle.Color = ZoomingRectangleColor;
            if (colorDialogZoomingRectangle.ShowDialog(this) == DialogResult.OK)
            {
                ZoomingRectangleColor = colorDialogZoomingRectangle.Color;

                this.Refresh();
            }
        }

        private void gbGridConfiguration_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics aGraphics = gbGridConfiguration.CreateGraphics())
            {
                using (Pen aPen = new Pen(Color.Black, 2))
                {
                    using (SolidBrush aBrush = new SolidBrush(GridColor))
                    {
                        aGraphics.FillRectangle(aBrush, 100, 75, 35, 35);
                        aGraphics.DrawRectangle(aPen, 100, 75, 35, 35);
                    }
                }
            }
        }

        private void gbZoomingRectangleConfiguration_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics aGraphics = gbZoomingRectangleConfiguration.CreateGraphics())
            {
                using (Pen aPen = new Pen(Color.Black, 2))
                {
                    using (SolidBrush aBrush = new SolidBrush(ZoomingRectangleColor))
                    {
                        aGraphics.FillRectangle(aBrush, 100, 30, 35, 35);
                        aGraphics.DrawRectangle(aPen, 100, 30, 35, 35);
                    }
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            GridAlpha = tbSetGridAlpha.Value;
            ZoomingRectangleAlpha = tbSetZoomRectangleAlpha.Value;
            myCanClose = true;

            try
            {
                HorizontalSpacing = Convert.ToDouble(tbHorizontalSpacing.Text, CultureInfo.CurrentCulture);
            }
            catch (FormatException)
            {
                MessageBox.Show("Horizontal spacing value must be valid number!", "Fractal Observer", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0);
                myCanClose = false;
            }

            try
            {
                VerticalSpacing = Convert.ToDouble(tbVerticalSpacing.Text, CultureInfo.CurrentCulture);
            }
            catch (FormatException)
            {
                MessageBox.Show("Vertical spacing value must be valid number!", "Fractal Observer", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0);
                myCanClose = false;
            }

            myOk = true;
        }

        private void ConfigureGridDialog_Shown(object sender, EventArgs e)
        {
            tbSetGridAlpha.Value = GridAlpha;
            tbSetZoomRectangleAlpha.Value = ZoomingRectangleAlpha;

            tbHorizontalSpacing.Text = Convert.ToString(HorizontalSpacing, CultureInfo.CurrentCulture);
            tbVerticalSpacing.Text = Convert.ToString(VerticalSpacing, CultureInfo.CurrentCulture);
        }

        private void ConfigureGridAndZoomRectangleDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool aItemInvisible = false;
            if (tbSetGridAlpha .Value == 0)
            {
                aItemInvisible = true;
            }
            else if (tbSetZoomRectangleAlpha.Value == 0)
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

            if (myCanClose == false && myOk == true)
            {
                e.Cancel = true;
                myOk = false;
            }
        }

        #endregion

        #region Properties

        public Color GridColor
        {
            get
            {
                return myGridColor;
            }
            set
            {
                myGridColor = value;
            }
        }

        public Color ZoomingRectangleColor
        {
            get
            {
                return myZoomingRectangleColor;
            }
            set
            {
                myZoomingRectangleColor = value;
            }
        }

        public int GridAlpha
        {
            get
            {
                return myGridAlpha;
            }
            set
            {
                myGridAlpha = value;
            }
        }

        public int ZoomingRectangleAlpha
        {
            get
            {
                return myZoomingRectangleAlpha;
            }
            set
            {
                myZoomingRectangleAlpha = value;
            }
        }

        public double HorizontalSpacing
        {
            get
            {
                return myHorizontalSpacing;
            }
            set
            {
                myHorizontalSpacing = value;
            }
        }

        public double VerticalSpacing
        {
            get
            {
                return myVerticalSpacing;
            }
            set
            {
                myVerticalSpacing = value;
            }
        }

        #endregion

        #region Members

        private Color myGridColor;
        private Color myZoomingRectangleColor;

        private int myGridAlpha = 0;
        private int myZoomingRectangleAlpha = 0;

        private double myHorizontalSpacing = 0.0;
        private double myVerticalSpacing = 0.0;

        private bool myOk = false;
        private bool myCanClose = true;

        #endregion
    }
}


