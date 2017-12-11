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
//c Invoke btnCallMethod_Click() event handler method asychronously and inside of that, invoke DoWorkAsync() method on the secondary thread asychronously. This DoWorkAsync() method makes the calling thread(the thread which called DoWorkAsync() method) sleep 4 seconds and return Task<string> to the place which called the DoWorkAsync() method. And on there, by await keyword, it extracts string which is the form to be assigned to this.Text from Task<string>.
//c Invoke method returning void by async and await feature.
//c Use async method with multiple await.

namespace FunWithCSharpAsync
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void btnCallMethod_Click(object sender, EventArgs e)
        {
            this.Text = await DoWorkAsync();
            for (int i = 1; i <= 2; i++)
            {
                MessageBox.Show($"Inside of btnCallMethod_Click() invoked after DoWorkAsync() finished: {i.ToString()}");
                Thread.Sleep(1000);
            }
        }

        private async void btnVoidMethodCall_Click(object sender, EventArgs e)
        {
            //await MethodReturningVoidAsync();
            //MessageBox.Show("Done!");
            await ForBy2ndButton();
        }



        //private async Task ForBy2ndButton()
        //{
        //    await Task.Run(() =>
        //    {
        //        for (int i = 1; i <= 2; i++)
        //        {
        //            MessageBox.Show($"Inside of ForBy2ndButton(): {i.ToString()}");
        //            Thread.Sleep(1000);
        //        }
        //    });
        //}

        private async Task ForBy2ndButton()
        {
            for (int i = 1; i <= 2; i++)
            {
                MessageBox.Show($"Inside of ForBy2ndButton(): {i.ToString()}");
                Thread.Sleep(1000);
            }
        }


        // See below for code walkthrough...
        private async Task<string> DoWorkAsync()
        {
            string varStr = await Task.Run(() =>
            {
                Thread.Sleep(4000);

                for (int i = 1; i <= 2; i++)
                {
                    MessageBox.Show($"Inside of Task.Run() of DoWorkAsync(): {i.ToString()}");
                    Thread.Sleep(1000);
                }
                return "Done with work!";
            });

            for (int i = 1; i <= 2; i++)
            {
                MessageBox.Show($"Inside of DoWorkAsync() invoked after Task.Run() finished: {i.ToString()}");
                Thread.Sleep(1000);
            }

            return varStr;
        }

        private async Task MethodReturningVoidAsync()
        {
            await Task.Run(() =>
            { /* Do some work here... */
                Thread.Sleep(4000);
            });
        }

        private async void btnMutliAwaits_Click(object sender, EventArgs e)
        {
            await Task.Run(() => { Thread.Sleep(2000); });
            MessageBox.Show("Done with first task!");

            await Task.Run(() => { Thread.Sleep(2000); });
            MessageBox.Show("Done with second task!");

            await Task.Run(() => { Thread.Sleep(2000); });
            MessageBox.Show("Done with third task!");
        }
    }
}
