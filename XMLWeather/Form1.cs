﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    //Valentina Montoya
    // Monday, April 22, 2024
    //Weather App

    public partial class Form1 : Form
    {
        // TODO: create list to hold day objects
        public static List<Day> days = new List<Day>();
        public static string city;
        public static int finalTemp, finalMax, finalMin;

        public Form1()
        {
            InitializeComponent();

            ExtractForecast();
            ExtractCurrent();
            
            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        private void ExtractForecast()
        {
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");



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
                days.Add(d);
                
            }
        }

        private void ExtractCurrent()
        {
            // current info is not included in forecast file so we need to use this file to get it
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            //TODO: find the city and current temperature and add to appropriate item in days list
            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            reader.ReadToFollowing("temperature");
            days[0].currentTemp = reader.GetAttribute("value");

            double tempDouble = Convert.ToDouble(days[0].currentTemp);
            int temp = Convert.ToInt32(Math.Round(tempDouble));
            temp = finalTemp;


        }
        public void CitySearch()
        {

            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q={" + city + "}&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

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

    }
}
