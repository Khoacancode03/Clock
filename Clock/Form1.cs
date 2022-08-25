using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int hour = Convert.ToInt32(lbHour.Text);
            int minute = Convert.ToInt32(lbMinute.Text);
            int second = Convert.ToInt32(lbSecond.Text);
            int tik = Convert.ToInt32(lbTik.Text);
          
            //Start check tik:
            tik++;
            if (tik >9)
            {
                tik = 0;
                second++;
            }
            if (tik < 10)
            {
                lbTik.Text = "0" + tik;
            }

            else
            {
                lbTik.Text = tik + "";
            }


            //Check second:
            if (second > 59)
            {
                second = 0;
                minute++;

            }

            if (second < 10)
            {
                lbSecond.Text = "0" + second;
            }
            else
            {
                lbSecond.Text = second + "";
            }



            //Check Minutes:
            if (minute > 59)
            {
                minute = 0;
                hour++;
            }

            if (minute < 10)
            {
                lbMinute.Text = "0" + minute;
            }
            else
            {
                lbMinute.Text = minute + "";
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbTik.Text = "0";
            lbSecond.Text = "00";
            lbMinute.Text = "00";
            lbHour.Text = "0";
            timer1.Enabled = false;

        }
    }
}
