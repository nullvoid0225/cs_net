using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

namespace mook_ParameterThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Thread SumThread = null;

        private void btnSum_Click(object sender, EventArgs e)
        {
            SumThread = new Thread(new ParameterizedThreadStart(NumSum));
            SumThread.Start(this.txtNum.Text);
        }

        private void NumSum(object n)
        {
            long sum = 0;
            long k = Convert.ToInt64(n);
            for (long i = 0; i <= k; i++)
            {
                Thread.Sleep(1);
                sum += i;
                this.lblResult.Text = "계산중 : " + sum.ToString();
            }
            this.lblResult.Text = "완료 결과 : " + sum.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SumThread != null)
                SumThread.Abort();
        }
    }
}