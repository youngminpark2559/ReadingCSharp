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
//c Use Parallel.ForEach to process foreach task in parallel by using multiple processor of CPU. The logic is identical except that source is located in the first argument, and one unit from source is located in the second argument, and the logic is inside of Action delegate.

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

            // Process the image data in a parallel manner!
            Parallel.ForEach(files, currentFile =>
            {
                string filename = Path.GetFileName(currentFile);

                using (Bitmap bitmap = new Bitmap(currentFile))
                {
                    bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    bitmap.Save(Path.Combine(newDir, filename));

                    // This code statement is now a problem! See next section.
                    // this.Text = string.Format("Processing {0} on thread {1}", filename,
                    // Thread.CurrentThread.ManagedThreadId);
                }
            }
            );
        }
    }
}
