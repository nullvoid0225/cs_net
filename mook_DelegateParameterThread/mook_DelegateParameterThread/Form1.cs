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

namespace mook_DelegateParameterThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread SumThread = null;

        private delegate void OnResultDelegate(string strText); //데리게이트 선언
        private OnResultDelegate ResultView = null; //델리게이트 개체 생성

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
                Invoke(ResultView, "계산중 : " + sum.ToString());
            }
            Invoke(ResultView, "완료 결과 : " + sum.ToString());
            SumThread.Abort();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SumThread != null)
                SumThread.Abort();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResultView = new OnResultDelegate(ResultSum);
        }

        private void ResultSum(string NumSum)
        {
            this.lblResult.Text = NumSum;
        }
    }
}