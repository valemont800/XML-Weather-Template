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
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            dayOutput.Text = DateTime.Now.AddDays(0).DayOfWeek.ToString();
            timeOutput.Text = DateTime.Now.ToString("hh:mm:ss tt");
            dayOfYearOutput.Text = DateTime.Now.ToString(", MMMM dd, yyyy");

            cityOutput.Text = Form1.days[0].location;
            currentOutput.Text = Form1.days[0].currentTemp + "°";
            minOutput.Text = Form1.days[0].tempLow + "°";
            maxOutput.Text = Form1.days[0].tempHigh + "°";
            conditionOutput.Text = Form1.days[0].condition;

            if (Form1.days[0].id == "800")
            {
                pictureBox1.Image = Properties.Resources._01d;
            }

            if (Form1.days[0].id == "500" || "501" || "502" || "503" || "504")
            {
                pictureBox1.Image = Properties.Resources._10d;
            }

            if (Form1.days[0].id == "801" || "802" || "803" || "804")
            {
                pictureBox1.Image = Properties.Resources._02d;
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
    }
}
