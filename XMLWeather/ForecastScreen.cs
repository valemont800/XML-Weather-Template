using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            //digits
            double tempDoubleMax = Convert.ToDouble(Form1.days[0].tempHigh);
            int roundMax = Convert.ToInt32(Math.Round(tempDoubleMax));
            roundMax = Form1.finalMax;

            double tempDoubleMin = Convert.ToDouble(Form1.days[0].tempLow);
            int roundMin = Convert.ToInt32(Math.Round(tempDoubleMin));
            roundMin = Form1.finalMin;


            //tomorrow

            if (Form1.days[1].id == "800")
            {
                pictureBox1.Image = Properties.Resources._01d; //clear
            }
            else if ((Form1.days[1].id == "500") || (Form1.days[1].id == "501") || (Form1.days[1].id == "502") || (Form1.days[1].id == "503") || (Form1.days[1].id == "504"))
            {
                pictureBox1.Image = Properties.Resources._10d; //cloudy rain w sun
            }
            else if ((Form1.days[1].id == "520") || (Form1.days[1].id == "521") || (Form1.days[1].id == "522") || (Form1.days[1].id == "531"))
            {
                pictureBox1.Image = Properties.Resources._09d; //cloudy rain
            }
            else if ((Form1.days[1].id == "200") || (Form1.days[1].id == "201") || (Form1.days[1].id == "210") || (Form1.days[1].id == "211") || (Form1.days[1].id == "212") || (Form1.days[1].id == "221") || (Form1.days[1].id == "230") || (Form1.days[1].id == "231") || (Form1.days[1].id == "232"))
            {
                pictureBox1.Image = Properties.Resources._11d; //thunder
            }
            else if ((Form1.days[1].id == "801"))
            {
                pictureBox1.Image = Properties.Resources._02d; //cloudy w sun
            }
            else if ((Form1.days[1].id == "802"))
            {
                pictureBox1.Image = Properties.Resources._03d; // scattered clouds
            }
            else if ((Form1.days[1].id == "803") || (Form1.days[1].id == "804"))
            {
                pictureBox1.Image = Properties.Resources._04d; //broken clouds
            }
            else if ((Form1.days[1].id == "701") || (Form1.days[1].id == "711") || (Form1.days[1].id == "721") || (Form1.days[1].id == "741") || (Form1.days[1].id == "771") || (Form1.days[1].id == "781"))
            {
                pictureBox1.Image = Properties.Resources._50d; //atmosphere
            }
            else if ((Form1.days[1].id == "600") || (Form1.days[1].id == "601") || (Form1.days[1].id == "602") || (Form1.days[1].id == "611") || (Form1.days[1].id == "612") || (Form1.days[1].id == "613") || (Form1.days[1].id == "613") || (Form1.days[1].id == "615") || (Form1.days[1].id == "616") || (Form1.days[1].id == "620") || (Form1.days[1].id == "621") || (Form1.days[1].id == "622"))
            {
                pictureBox1.Image = Properties.Resources._13d;
            }

            //date1.Text = DateTime.Now.AddDays(1).DayOfWeek.ToString();
            max1.Text = Form1.finalMax + "°";
            min1.Text = Form1.finalMin + "°";
            //condition1.Text = Form1.days[1].condition;

            //2day
            if (Form1.days[2].id == "800")
            {
                pictureBox2.Image = Properties.Resources._01d; //clear
            }
            else if ((Form1.days[2].id == "500") || (Form1.days[2].id == "501") || (Form1.days[2].id == "502") || (Form1.days[2].id == "503") || (Form1.days[2].id == "504"))
            {
                pictureBox2.Image = Properties.Resources._10d; //cloudy rain w sun
            }
            else if ((Form1.days[2].id == "520") || (Form1.days[2].id == "521") || (Form1.days[2].id == "522") || (Form1.days[2].id == "531"))
            {
                pictureBox2.Image = Properties.Resources._09d; //cloudy rain
            }
            else if ((Form1.days[2].id == "200") || (Form1.days[2].id == "201") || (Form1.days[2].id == "210") || (Form1.days[2].id == "211") || (Form1.days[2].id == "212") || (Form1.days[2].id == "221") || (Form1.days[2].id == "230") || (Form1.days[2].id == "231") || (Form1.days[2].id == "232"))
            {
                pictureBox2.Image = Properties.Resources._11d; //thunder
            }
            else if ((Form1.days[2].id == "801"))
            {
                pictureBox2.Image = Properties.Resources._02d; //cloudy w sun
            }
            else if ((Form1.days[2].id == "802"))
            {
                pictureBox2.Image = Properties.Resources._03d; // scattered clouds
            }
            else if ((Form1.days[2].id == "803") || (Form1.days[1].id == "804"))
            {
                pictureBox2.Image = Properties.Resources._04d; //broken clouds
            }
            else if ((Form1.days[2].id == "701") || (Form1.days[2].id == "711") || (Form1.days[2].id == "721") || (Form1.days[2].id == "741") || (Form1.days[2].id == "771") || (Form1.days[2].id == "781"))
            {
                pictureBox2.Image = Properties.Resources._50d; //atmosphere
            }
            else if ((Form1.days[2].id == "600") || (Form1.days[2].id == "601") || (Form1.days[2].id == "602") || (Form1.days[2].id == "611") || (Form1.days[2].id == "612") || (Form1.days[2].id == "613") || (Form1.days[2].id == "613") || (Form1.days[2].id == "615") || (Form1.days[2].id == "616") || (Form1.days[2].id == "620") || (Form1.days[2].id == "621") || (Form1.days[2].id == "622"))
            {
                pictureBox2.Image = Properties.Resources._13d;
            }

            date2.Text = DateTime.Now.AddDays(2).DayOfWeek.ToString();
            max2.Text = Form1.finalMax + "°";
            min2.Text = Form1.finalMin + "°";
            //condition2.Text = Form1.days[2].condition;


            //3day
            if (Form1.days[3].id == "800")
            {
                pictureBox3.Image = Properties.Resources._01d; //clear
            }
            else if ((Form1.days[3].id == "500") || (Form1.days[3].id == "501") || (Form1.days[3].id == "502") || (Form1.days[3].id == "503") || (Form1.days[3].id == "504"))
            {
                pictureBox3.Image = Properties.Resources._10d; //cloudy rain w sun
            }
            else if ((Form1.days[3].id == "520") || (Form1.days[3].id == "521") || (Form1.days[3].id == "522") || (Form1.days[3].id == "531"))
            {
                pictureBox3.Image = Properties.Resources._09d; //cloudy rain
            }
            else if ((Form1.days[3].id == "200") || (Form1.days[3].id == "201") || (Form1.days[3].id == "210") || (Form1.days[3].id == "211") || (Form1.days[3].id == "212") || (Form1.days[3].id == "221") || (Form1.days[3].id == "230") || (Form1.days[3].id == "231") || (Form1.days[3].id == "232"))
            {
                pictureBox3.Image = Properties.Resources._11d; //thunder
            }
            else if ((Form1.days[3].id == "801"))
            {
                pictureBox3.Image = Properties.Resources._02d; //cloudy w sun
            }
            else if ((Form1.days[3].id == "802"))
            {
                pictureBox3.Image = Properties.Resources._03d; // scattered clouds
            }
            else if ((Form1.days[3].id == "803") || (Form1.days[3].id == "804"))
            {
                pictureBox3.Image = Properties.Resources._04d; //broken clouds
            }
            else if ((Form1.days[3].id == "701") || (Form1.days[3].id == "711") || (Form1.days[3].id == "721") || (Form1.days[3].id == "741") || (Form1.days[3].id == "771") || (Form1.days[3].id == "781"))
            {
                pictureBox3.Image = Properties.Resources._50d; //atmosphere
            }
            else if ((Form1.days[3].id == "600") || (Form1.days[3].id == "601") || (Form1.days[3].id == "602") || (Form1.days[3].id == "611") || (Form1.days[3].id == "612") || (Form1.days[3].id == "613") || (Form1.days[3].id == "613") || (Form1.days[3].id == "615") || (Form1.days[3].id == "616") || (Form1.days[3].id == "620") || (Form1.days[3].id == "621") || (Form1.days[3].id == "622"))
            {
                pictureBox3.Image = Properties.Resources._13d;
            }

            date3.Text = DateTime.Now.AddDays(3).DayOfWeek.ToString();
            max3.Text = Form1.finalMax + "°";
            min3.Text = Form1.finalMin + "°";
            //condition3.Text = Form1.days[3].condition;




            //date4.Text = DateTime.Now.AddDays(4).DayOfWeek.ToString();
            //max4.Text = Form1.days[4].tempHigh + "°C";
            //min4.Text = Form1.days[4].tempLow + "°C";
            //condition4.Text = Form1.days[4].condition;

            //date5.Text = DateTime.Now.AddDays(5).DayOfWeek.ToString();
            //max5.Text = Form1.days[5].tempHigh + "°C";
            //min5.Text = Form1.days[5].tempLow + "°C";
            //condition5.Text = Form1.days[5].condition;

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}
