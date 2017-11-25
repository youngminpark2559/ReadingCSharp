using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

//c Do some foreach tasks on a single primary thread, so everything is hung because the primary thread is fully taken by the running task.

namespace DataParallelismWithForEach
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnProcessImages_Click(object sender, EventArgs e)
        {
            ProcessFiles();
        }

        private void ProcessFiles()
        {
            // Load up all *.jpg files, and make a new folder for the modified data.
            string[] files = Directory.GetFiles
              (@"C:\TestPictures", "*.jpg", SearchOption.AllDirectories);
            string newDir = @"C:\ModifiedPictures";
            Directory.CreateDirectory(newDir);

            // Process the image data in a blocking manner.
            foreach (string currentFile in files)
            {
                string filename = Path.GetFileName(currentFile);

                using (Bitmap bitmap = new Bitmap(currentFile))
                {
                    bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    bitmap.Save(Path.Combine(newDir, filename));

                    // Print out the ID of the thread processing the current image.
                    this.Text = string.Format("Processing {0} on thread {1}", filename,
                      Thread.CurrentThread.ManagedThreadId);
                }
            }
        }
    }
}
