using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//c Implement btnDownload_Click() event handler method. I download text file asynchronously and when this task is completed, DownloadStringCompleted event is fired and event handler is invoked so downloaded text is assigned to theEBook variable and this variable is assigned ti text box.

namespace MyEBookReader
{
    public partial class Form1 : Form
    {
        string theEBook;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            wc.DownloadStringCompleted += (s, eArgs) =>
            {
                theEBook = eArgs.Result;
                txtBook.Text = theEBook;
            };
            // The Project Gutenberg EBook of A Tale of Two Cities, by Charles Dickens
            wc.DownloadStringAsync(new Uri("http://www.gutenberg.org/files/98/98-8.txt"));
        }

        private void btnGetStats_Click(object sender, EventArgs e)
        {

        }
    }
}
