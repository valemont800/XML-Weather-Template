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
            cityOutput1.Text = Form1.days[0].location;
            currentOutput.Text = Form1.days[0].currentTemp + "°";
            minOutput.Text = Form1.days[0].tempLow + "°";
            maxOutput.Text = Form1.days[0].tempHigh + "°";
            conditionOutput.Text = Form1.days[0].condition;



            //image conditions
            //if ( DateTime.Now.Hour == 8)
            //{
            //    this.BackgroundImage = Properties.Resources.;
            //}


            //clear
            if (Form1.days[0].id == "800")
            {
                pictureBox1.Image = Properties.Resources._01d;
            }

            if ((Form1.days[0].id == "500")|| (Form1.days[0].id == "501") || (Form1.days[0].id == "502") || (Form1.days[0].id == "503") || (Form1.days[0].id == "504"))
            {
                pictureBox1.Image = Properties.Resources._10d;
            }

            if ((Form1.days[0].id == "801" )|| (Form1.days[0].id == "802") || (Form1.days[0].id == "803") || (Form1.days[0].id == "804"))
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

        private void CitySearch()
        {
            string city = cityInput.Text;

            XmlReader reader = XmlReader.Create($"http://api.openweathermap.org/data/2.5/weather?q=" + city + "&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            while (reader.Read())
            {
                //TODO: create a day object
                Day d = new Day();

                //TODO: fill day object with required data
                reader.ReadToFollowing("time");
                d.date = reader.GetAttribute("day");

                reader.ReadToFollowing("temperature");
                d.tempLow = reader.GetAttribute("min");
                d.tempHigh = reader.GetAttribute("max");

                reader.ReadToFollowing("symbol");
                d.condition = reader.GetAttribute("name");
                d.id = reader.GetAttribute("number");


                //TODO: if day object not null add to the days list
                Form1.days.Add(d);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CitySearch();
        }
    }
}
