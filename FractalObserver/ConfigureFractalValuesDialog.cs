// programmed by Adrian Magdina in 2012
// in this file is the implementation of dialog for input of values for fractal display 
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
    public partial class ConfigureFractalValuesDialog : Form
    {
        #region Constructors

        public ConfigureFractalValuesDialog()
        {
            InitializeComponent();

            myFractalObserverConfiguration = null;
            myCanClose = true;
            myBtnOk = false;
        }

        #endregion

        #region Methods

        public ConfigureFractalValuesDialog(IFractalObserverConfiguration fractalObserverConfigurationIn)
        {
            InitializeComponent();

            myFractalObserverConfiguration = fractalObserverConfigurationIn as FractalObserverConfiguration;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            myCanClose = true;
            myBtnOk = true;

            try
            {
                myFractalObserverConfiguration.ZoomRectangle.StartX = Convert.ToDouble(tbZoomXStart.Text, CultureInfo.CurrentCulture);
            }
            catch (FormatException)
            {
                MessageBox.Show("Zoom Rectangle Area - X Start value must be valid number!", "Fractal Observer", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0);
                myCanClose = false;
            }

            try
            {
                myFractalObserverConfiguration.ZoomRectangle.EndX = Convert.ToDouble(tbZoomXEnd.Text, CultureInfo.CurrentCulture);
            }
            catch (FormatException)
            {
                MessageBox.Show("Zoom Rectangle Area - X End value must be valid number!", "Fractal Observer", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0);
                myCanClose = false;
            }

            try
            {
                myFractalObserverConfiguration.ZoomRectangle.StartY = Convert.ToDouble(tbZoomYStart.Text, CultureInfo.CurrentCulture);
            }
            catch (FormatException)
            {
                MessageBox.Show("Zoom Rectangle Area - Y Start value must be valid number!", "Fractal Observer", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0);
                myCanClose = false;
            }

            try
            {
                myFractalObserverConfiguration.ZoomRectangle.EndY = Convert.ToDouble(tbZoomYEnd.Text, CultureInfo.CurrentCulture);
            }
            catch (FormatException)
            {
                MessageBox.Show("Zoom Rectangle Area - X End value must be valid number!", "Fractal Observer", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0);
                myCanClose = false;
            }

            try
            {
                myFractalObserverConfiguration.CurrentRectangle.StartX = Convert.ToDouble(tbCurrentXStart.Text, CultureInfo.CurrentCulture);
            }
            catch (FormatException)
            {
                MessageBox.Show("Current Visible Area - X Start value must be valid number!", "Fractal Observer", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0);
                myCanClose = false;
            }

            try
            {
                myFractalObserverConfiguration.CurrentRectangle.EndX = Convert.ToDouble(tbCurrentXEnd.Text, CultureInfo.CurrentCulture);
            }
            catch (FormatException)
            {
                MessageBox.Show("Current Visible Area - X End value must be valid number!", "Fractal Observer", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0);
                myCanClose = false;
            }

            try
            {
                myFractalObserverConfiguration.CurrentRectangle.StartY = Convert.ToDouble(tbCurrentYStart.Text, CultureInfo.CurrentCulture);
            }
            catch (FormatException)
            {
                MessageBox.Show("Current Visible Area - Y Start value must be valid number!", "Fractal Observer", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0);
                myCanClose = false;
            }

            try
            {
                myFractalObserverConfiguration.CurrentRectangle.EndY = Convert.ToDouble(tbCurrentYEnd.Text, CultureInfo.CurrentCulture);
            }
            catch (FormatException)
            {
                MessageBox.Show("Current Visible Area - Y End value must be valid number!", "Fractal Observer", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0);
                myCanClose = false;
            }

            myFractalObserverConfiguration.FractalTypeString = cbFractalType.Text;

            myFractalObserverConfiguration.EquationTypeString = cbFractalEquation.Text;
        }

        private void ConfigureFractalObserverDialog_Shown(object sender, EventArgs e)
        {
            tbZoomXStart.Text = Convert.ToString(myFractalObserverConfiguration.ZoomRectangle.StartX, CultureInfo.CurrentCulture);
            tbZoomXEnd.Text = Convert.ToString(myFractalObserverConfiguration.ZoomRectangle.EndX, CultureInfo.CurrentCulture);
            tbZoomYStart.Text = Convert.ToString(myFractalObserverConfiguration.ZoomRectangle.StartY, CultureInfo.CurrentCulture);
            tbZoomYEnd.Text = Convert.ToString(myFractalObserverConfiguration.ZoomRectangle.EndY, CultureInfo.CurrentCulture);

            tbCurrentXStart.Text = Convert.ToString(myFractalObserverConfiguration.CurrentRectangle.StartX, CultureInfo.CurrentCulture);
            tbCurrentXEnd.Text = Convert.ToString(myFractalObserverConfiguration.CurrentRectangle.EndX, CultureInfo.CurrentCulture);
            tbCurrentYStart.Text = Convert.ToString(myFractalObserverConfiguration.CurrentRectangle.StartY, CultureInfo.CurrentCulture);
            tbCurrentYEnd.Text = Convert.ToString(myFractalObserverConfiguration.CurrentRectangle.EndY, CultureInfo.CurrentCulture);

            cbFractalEquation.Items.Clear();

            foreach (KeyValuePair<string, FractalTypes> fractalType in FractalFactory.AvailableFractalTypes)
            {
                cbFractalType.Items.Add(fractalType.Key);

                if (myFractalObserverConfiguration.FractalType == fractalType.Value)
                {
                    cbFractalType.SelectedItem = fractalType.Key;

                    bool aEquationSelected = false;
                    foreach (KeyValuePair<string, EquationTypes> equationType in EquationFactory.AvailableEquationTypes)
                    {
                        if (FractalFactory.GetAvailableEquationTypesForFractalType(fractalType.Value).Contains(equationType.Value))
                        {
                            cbFractalEquation.Items.Add(equationType.Key);

                            if (myFractalObserverConfiguration.EquationType == equationType.Value)
                            {
                                cbFractalEquation.SelectedItem = equationType.Key;
                                aEquationSelected = true;
                            }
                        }
                    }
                    if (!aEquationSelected && cbFractalEquation.Items.Count > 0)
                    {
                        cbFractalEquation.SelectedIndex = 0;
                    }
                }
            }

            if (cbFractalEquation.Items.Count == 0)
            {
                cbFractalEquation.Enabled = false;
            }
        }

        private void cbFractalType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbFractalEquation.Items.Clear();

            foreach (KeyValuePair<string, FractalTypes> fractalType in FractalFactory.AvailableFractalTypes)
            {
                if ((string)cbFractalType.SelectedItem == fractalType.Key)
                {
                    bool aEquationSelected = false;
                    foreach (KeyValuePair<string, EquationTypes> equationType in EquationFactory.AvailableEquationTypes)
                    {
                        if (FractalFactory.GetAvailableEquationTypesForFractalType(fractalType.Value).Contains(equationType.Value))
                        {
                            cbFractalEquation.Items.Add(equationType.Key);

                            if (myFractalObserverConfiguration.EquationType == equationType.Value)
                            {
                                cbFractalEquation.SelectedItem = equationType.Key;
                                aEquationSelected = true;
                            }
                        }
                    }

                    if (!aEquationSelected && cbFractalEquation.Items.Count > 0)
                    {
                        cbFractalEquation.SelectedIndex = 0;
                    }

                    if (cbFractalEquation.Items.Count == 0)
                    {
                        cbFractalEquation.Enabled = false;
                    }
                    else
                    {
                        cbFractalEquation.Enabled = true;
                    }
                }
            }
        }

        private void btnSetZoomRectangleToCurrent_Click(object sender, EventArgs e)
        {
            tbZoomXStart.Text = tbCurrentXStart.Text;
            tbZoomXEnd.Text = tbCurrentXEnd.Text;
            tbZoomYStart.Text = tbCurrentYStart.Text;
            tbZoomYEnd.Text = tbCurrentYEnd.Text;
        }

        private void ConfigureFractalValuesDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (myCanClose == false && myBtnOk == true)
            {
                e.Cancel = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            myBtnOk = false;
        }

        #endregion

        #region Properties

        public FractalObserverConfiguration FractalObserverConfiguration
        {
            get
            {
                return myFractalObserverConfiguration;
            }
        }

        #endregion

        #region Members

        private FractalObserverConfiguration myFractalObserverConfiguration = null;

        private bool myCanClose = true;
        private bool myBtnOk = false;

        #endregion
    }
}
