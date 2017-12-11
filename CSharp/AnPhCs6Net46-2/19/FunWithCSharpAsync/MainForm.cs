using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//c Add a method DoWork() which suspends Thread for 10 seconds and after that returns a string data type literal value to the caller.

namespace FunWithCSharpAsync
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCallMethod_Click(object sender, EventArgs e)
        {
            this.Text = DoWork();
        }

        private string DoWork()
        {
            Thread.Sleep(10000);
            return "Done with work!";
        }
    }
}
