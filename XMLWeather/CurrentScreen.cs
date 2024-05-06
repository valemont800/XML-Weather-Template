using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {

        int currentHour = DateTime.Now.Hour;
        string city;

        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            //time & date
            dayOutput.Text = DateTime.Now.AddDays(0).DayOfWeek.ToString();
            timeOutput.Text = DateTime.Now.ToString("hh:mm:ss tt");
            dayOfYearOutput.Text = DateTime.Now.ToString(", MMMM dd, yyyy");

            //temp info

            double tempDoubleMax = Convert.ToDouble(Form1.days[0].tempHigh);
            int roundMax = Convert.ToInt32(Math.Round(tempDoubleMax));
            roundMax = Form1.finalMax;

            double tempDoubleMin = Convert.ToDouble(Form1.days[0].tempLow);
            int roundMin = Convert.ToInt32(Math.Round(tempDoubleMin));
            roundMin = Form1.finalMin;

            //cityOutput1.Text = Form1.days[0].location;
            currentOutput.Text = Form1.finalTemp + "°";
            minOutput.Text = Form1.finalMin + "°  /";
            maxOutput.Text = Form1.finalMax + "°";
            conditionOutput.Text = Form1.days[0].condition;

            //original data
            //cityOutput1.Text = Form1.days[0].location;
            //currentOutput.Text = Form1.days[0].currentTemp + "°";
            //minOutput.Text = Form1.days[0].tempLow + "°";
            //maxOutput.Text = Form1.days[0].tempHigh + "°";
            //conditionOutput.Text = Form1.days[0].condition;


            //Image conditions
            if (Form1.days[0].id == "800")
            {
                pictureBox1.Image = Properties.Resources._01d; //clear
                this.BackgroundImage = Properties.Resources.morning;
            }
            else if ((Form1.days[0].id == "500") || (Form1.days[0].id == "501") || (Form1.days[0].id == "502") || (Form1.days[0].id == "503") || (Form1.days[0].id == "504"))
            {
                pictureBox1.Image = Properties.Resources._10d; //cloudy rain w sun
                this.BackgroundImage = Properties.Resources.suncloudy;
            }
            else if ((Form1.days[0].id == "520") || (Form1.days[0].id == "521") || (Form1.days[0].id == "522") || (Form1.days[0].id == "531"))
            {
                pictureBox1.Image = Properties.Resources._09d; //cloudy rain
                this.BackgroundImage = Properties.Resources.rain;
            }
            else if ((Form1.days[0].id == "200") || (Form1.days[0].id == "201") || (Form1.days[0].id == "210") || (Form1.days[0].id == "211") || (Form1.days[0].id == "212") || (Form1.days[0].id == "221") || (Form1.days[0].id == "230") || (Form1.days[0].id == "231") || (Form1.days[0].id == "232"))
            {
                pictureBox1.Image = Properties.Resources._11d; //thunder
                this.BackgroundImage = Properties.Resources.thunder;
            }
            else if ((Form1.days[0].id == "801"))
            {
                pictureBox1.Image = Properties.Resources._02d; //cloudy w sun
                this.BackgroundImage = Properties.Resources.scattered;
            }
            else if ((Form1.days[0].id == "802"))
            {
                pictureBox1.Image = Properties.Resources._03d; // scattered clouds
                this.BackgroundImage = Properties.Resources.scattered;
            }
            else if ((Form1.days[0].id == "803") || (Form1.days[0].id == "804"))
            {
                pictureBox1.Image = Properties.Resources._04d; //broken clouds
                this.BackgroundImage = Properties.Resources.scattered;
            }
            else if ((Form1.days[0].id == "701") || (Form1.days[0].id == "711") || (Form1.days[0].id == "721") || (Form1.days[0].id == "741") || (Form1.days[0].id == "771") || (Form1.days[0].id == "781"))
            {
                pictureBox1.Image = Properties.Resources._50d; //atmosphere
                this.BackgroundImage = Properties.Resources.mist;
            }
            else if((Form1.days[0].id == "600") || (Form1.days[0].id == "601") || (Form1.days[0].id == "602") || (Form1.days[0].id == "611") || (Form1.days[0].id == "612") || (Form1.days[0].id == "613") || (Form1.days[0].id == "613") || (Form1.days[0].id == "615") || (Form1.days[0].id == "616") || (Form1.days[0].id == "620") || (Form1.days[0].id == "621") || (Form1.days[0].id == "622"))
            {
                pictureBox1.Image = Properties.Resources._13d;
                this.BackgroundImage = Properties.Resources.snow;
            }
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void cityOutput_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Form1.CitySearch();
        }
    }
}
