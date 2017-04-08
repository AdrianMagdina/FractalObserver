// programmed by Adrian Magdina in 2012
// in this file is the implementation of dialog with help
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FractalObserverApplication
{
    public partial class HelpDialog : Form
    {
        public HelpDialog()
        {
            InitializeComponent();
        }

        private void HelpDialog_Shown(object sender, EventArgs e)
        {
            String aCurrentDirectory = System.IO.Directory.GetCurrentDirectory();

            try
            {
                richTextHelp.LoadFile(aCurrentDirectory + "\\HelpFile.rtf");
            }
            catch (System.IO.IOException ex)
            {
                MessageBox.Show("The file with Help text cannot be loaded because of IO error!\n" +
                                "The program will continue without showing the help!\n" + ex.Message, "Fractal Observer", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("The file with Help text cannot be loaded because it is not an RTF document!\n" +
                                "The program will continue without showing the help!\n" + ex.Message, "Fractal Observer", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
