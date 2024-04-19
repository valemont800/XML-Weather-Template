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
            date1.Text = DateTime.Now.AddDays(1).DayOfWeek.ToString();
            max1.Text = Form1.days[1].tempHigh + "°";
            min1.Text = Form1.days[1].tempLow + "°";
            condition1.Text = Form1.days[1].condition;

            date2.Text = DateTime.Now.AddDays(2).DayOfWeek.ToString();
            max2.Text = Form1.days[2].tempHigh + "°";
            min2.Text = Form1.days[2].tempLow + "°";
            condition2.Text = Form1.days[2].condition;

            date3.Text = DateTime.Now.AddDays(3).DayOfWeek.ToString();
            max3.Text = Form1.days[3].tempHigh + "°";
            min3.Text = Form1.days[3].tempLow + "°";
            condition3.Text = Form1.days[3].condition;

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
