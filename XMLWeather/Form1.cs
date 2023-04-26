/*Kian Glenfield
 * Weather App
using xml files and an api
  */
using System;
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
    public partial class Form1 : Form
    {

        //list to hold day objects
        public static List<Day> days = new List<Day>();
        public Form1()
        {
            InitializeComponent();


            CurrentScreen.searchInput = "Stratford"; //set inputbox to a city on load

            ExtractForecast();
            ExtractCurrent();


            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        public static bool ExtractForecast()
        {
            try //try catch for error message
            {//string for updating search url
                string citySearch = $"https://api.openweathermap.org/data/2.5/forecast/daily?q={CurrentScreen.searchInput}&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0";
                XmlReader reader = XmlReader.Create(citySearch); //read the url

                while (reader.Read())
                {

                    //create a day object
                    Day d = new Day();

                    //fill day object with required data

                    reader.ReadToFollowing("time"); //get date
                    d.date = reader.GetAttribute("day");

                    reader.ReadToFollowing("sun"); //get sunrise and sunset
                    d.sunRise = reader.GetAttribute("rise");
                    d.sunSet = reader.GetAttribute("set");

                    reader.ReadToFollowing("symbol"); //get condition name, the number, and the icon
                    d.condition = reader.GetAttribute("number");
                    d.conditionName = reader.GetAttribute("name");
                    d.icon = reader.GetAttribute("var");


                    reader.ReadToFollowing("windDirection"); //get wind direction
                    d.windDirection = reader.GetAttribute("name");

                    reader.ReadToFollowing("windSpeed"); //get wind speed and unit
                    d.windSpeed = reader.GetAttribute("mps");
                    d.windUnit = reader.GetAttribute("unit");

                    reader.ReadToFollowing("temperature"); //get min and max temperature
                    d.tempLow = reader.GetAttribute("min");
                    d.tempHigh = reader.GetAttribute("max");

                    reader.ReadToFollowing("humidity"); //get humidity and unit
                    d.humidity = reader.GetAttribute("value");
                    d.percent = reader.GetAttribute("unit");

                   

                    //if day object not null add to the days list
                    if (d.date != null)
                    {
                        days.Add(d);
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }

        }
        public static void ExtractCurrent()
        {
            // current info is not included in forecast file so we need to use this file to get it
            XmlReader reader = XmlReader.Create($"http://api.openweathermap.org/data/2.5/weather?q={CurrentScreen.searchInput}&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            //TODO: find the city and current temperature and add to appropriate item in days list




            reader.ReadToFollowing("city"); //get city name
            days[0].location = reader.GetAttribute("name");


            reader.ReadToFollowing("temperature"); //get temperature values and unit
            days[0].currentTemp = reader.GetAttribute("value");
            days[0].tempLow = reader.GetAttribute("min");
            days[0].tempHigh = reader.GetAttribute("max");
            days[0].tempUnit = reader.GetAttribute("unit");

            reader.ReadToFollowing("humidity"); //get humidity and unit
            days[0].humidity = reader.GetAttribute("value");
            days[0].percent = reader.GetAttribute("unit");

            reader.ReadToFollowing("weather"); //get condition number, the value, and the icon
            days[0].condition = reader.GetAttribute("number");
            days[0].conditionName = reader.GetAttribute("value");
            days[0].icon = reader.GetAttribute("icon");

            reader.ReadToFollowing("lastupdate"); //get update time
            {
                days[0].updateTime = reader.GetAttribute("value");
            }

        }



    }
}
