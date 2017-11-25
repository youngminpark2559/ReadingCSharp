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
//c Use Task class. This class allows you to invoke a method on a secondary thread. And this class also can be used as an alternative to working with asynchronous delegate. By this code, ProcessFiles() method is invoke on the secondary thread.
//c Add cancel token field which will be used for suspending parallel task in the middle of executing.

namespace DataParallelismWithForEach
{
    public partial class MainForm : Form
    {

        // New Form-level variable.
        private CancellationTokenSource cancelToken = new CancellationTokenSource();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnProcessImages_Click(object sender, EventArgs e)
        {
            // Start a new "task" to process the files.
            Task.Factory.StartNew(() =>
            {
                ProcessFiles();
            });
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

                    // Eek! This will not work anymore!
                    //this.Text = string.Format("Processing {0} on thread {1}", filename,
                    //  Thread.CurrentThread.ManagedThreadId);

                    // Invoke on the Form object, to allow secondary threads to access controls
                    // in a thread-safe manner.
                    this.Invoke((Action)delegate
                    {
                        this.Text = string.Format("Processing {0} on thread {1}", filename,
                                    Thread.CurrentThread.ManagedThreadId);
                    }
                    );
                }
            }
            );
        }
    }
}
