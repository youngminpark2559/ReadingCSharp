using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

//c Add a project FunWithCSharpAsync to examine "async and await" feature to implement multi-threading and asynchronous programming in a simple way. This commit is before applying async and await feature to the project.

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
            Thread.Sleep(4000);
            return "Done with work!";
        }


    }
}
