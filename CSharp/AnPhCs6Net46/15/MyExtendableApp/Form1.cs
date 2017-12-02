using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//c Create a winforms application in which I will install 2 plug-ins.

namespace MyExtendableApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void snapInModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Allow user to select an assembly to load.
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (dlg.FileName.Contains("CommonSnappableTypes"))
                    MessageBox.Show("CommonSnappableTypes has no snap-ins!");
                else if (!LoadExternalModule(dlg.FileName))
                    MessageBox.Show("Nothing implements IAppFunctionality!");
            }
        }
    }
}
