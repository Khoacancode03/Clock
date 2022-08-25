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
    public partial class Clock : Form
    {
        public Clock()
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
                second+=30;
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


            //Check Hour:
            if (hour < 10)
            {
                lbHour.Text = "0" + hour;
            }
            else
            {
                lbHour.Text = hour + "";
            }

            //Set 24 hours per day.
            if (hour >24 )
            {
                lbTik.Text = "0";
                lbSecond.Text = "00";
                lbMinute.Text = "00";
                lbHour.Text = "0";
                timer1.Enabled = false;
            }    

        }

        bool check = true;
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (check)
            {
                timer1.Enabled = true;
                btnStart.Text = "Stop";
                check = false;
            }
            else
            {
                timer1.Enabled = false;
                btnStart.Text = "Start";
                check = true;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbTik.Text = "0";
            lbSecond.Text = "00";
            lbMinute.Text = "00";
            lbHour.Text = "0";
            timer1.Enabled = false;
            btnStart.Text = "Start";

        }

     
    }
}
