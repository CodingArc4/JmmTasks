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

namespace SynchronusAndAsynchronus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // button event for sync 
        private void ClickMe_Click(object sender, EventArgs e)
        {
            DateTimeLabel.Text = "Displaying time...";

            DateTime result = GetTimeInSeconds();

            DateTimeLabel.Text = result.ToString();

        }

        private DateTime GetTimeInSeconds()
        {
            // thread sleep for 10 seconds
            Thread.Sleep(10000);

            return DateTime.Now;
        }

        // button event for async
        private async void AsyncBtn_Click(object sender, EventArgs e)
        {
            AsyncLbl.Text = "Displaying Time...";

            DateTime res = await Task.Run(() => GetTimeInSeconds());

            AsyncLbl.Text = res.ToString();
        }
    }
}
