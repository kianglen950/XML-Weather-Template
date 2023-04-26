using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()//get forecast info
        {
            locationOutput.Text = Form1.days[0].location;
            date1Output.Text = Form1.days[1].date; //day 1 info, change index other days
            min1Output.Text = $"{Math.Round(Convert.ToDouble(Form1.days[1].tempLow), 0).ToString()}°C"; //round to whole number
            max1Output.Text = $"{Math.Round(Convert.ToDouble(Form1.days[1].tempHigh), 0).ToString()}°C";
            
            date2Output.Text = Form1.days[2].date;
            min2Output.Text = $"{Math.Round(Convert.ToDouble(Form1.days[2].tempLow), 0).ToString()}°C";
            max2Output.Text = $"{Math.Round(Convert.ToDouble(Form1.days[2].tempHigh), 0).ToString()}°C";
            
            date3Output.Text = Form1.days[3].date;
            min3Output.Text = $"{Math.Round(Convert.ToDouble(Form1.days[3].tempLow), 0).ToString()}°C";
            max3Output.Text = $"{Math.Round(Convert.ToDouble(Form1.days[3].tempHigh), 0).ToString()}°C";
            
            date4Output.Text = Form1.days[4].date;
            min4Output.Text = $"{Math.Round(Convert.ToDouble(Form1.days[4].tempLow), 0).ToString()}°C";
            max4Output.Text = $"{Math.Round(Convert.ToDouble(Form1.days[4].tempHigh), 0).ToString()}°C";
            
            date5Output.Text = Form1.days[5].date;
            min5Output.Text = $"{Math.Round(Convert.ToDouble(Form1.days[5].tempLow), 0).ToString()}°C";
            max5Output.Text = $"{Math.Round(Convert.ToDouble(Form1.days[5].tempHigh), 0).ToString()}°C";

            date6Output.Text = Form1.days[6].date;
            min6Output.Text = $"{Math.Round(Convert.ToDouble(Form1.days[6].tempLow), 0).ToString()}°C";
            max6Output.Text = $"{Math.Round(Convert.ToDouble(Form1.days[6].tempHigh), 0).ToString()}°C";

            string day1Url = $"https://openweathermap.org/img/wn/{Form1.days[1].icon}@2x.png"; //icon for each condition, change index for each
            forecastIconBox.LoadAsync(day1Url);
            string day2Url = $"https://openweathermap.org/img/wn/{Form1.days[2].icon}@2x.png";
            forecastIconBox2.LoadAsync(day2Url);
            string day3Url = $"https://openweathermap.org/img/wn/{Form1.days[3].icon}@2x.png";
            forecastIconBox3.LoadAsync(day3Url);
            string day4Url = $"https://openweathermap.org/img/wn/{Form1.days[4].icon}@2x.png";
            forecastIconBox4.LoadAsync(day4Url);
            string day5Url = $"https://openweathermap.org/img/wn/{Form1.days[5].icon}@2x.png";
            forecastIconBox5.LoadAsync(day5Url);
            string day6Url = $"https://openweathermap.org/img/wn/{Form1.days[6].icon}@2x.png";
            forecastIconBox6.LoadAsync(day6Url);
            
            BackgroundChange();
        }

        private void label3_Click(object sender, EventArgs e) //change screen back to current
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
        public void BackgroundChange() //background change based off condition
        {
            int b = Convert.ToInt32(Form1.days[1].condition);
            if (b == 800) //clear
            {
                this.BackColor = Color.SkyBlue;
            }
            else if (b >= 801 && b <= 804) //clouds
            {
                this.BackColor = Color.LightSlateGray;
            }
            else if (b >= 200 && b <= 232) //thunderstorm
            {
                this.BackColor = Color.DarkSlateGray;
            }
            else if (b >= 300 && b <= 321) //drizzle
            {
                this.BackColor = Color.LightSteelBlue;

            }
            else if (b >= 500 && b <= 531) //rain
            {
                this.BackColor = Color.DodgerBlue;
            }
            else if (b >= 600 && b <= 622) //snow
            {
                this.BackColor = Color.DimGray;
            }
            else if (b >= 700 && b <= 781) //atmosphere
            {
                this.BackColor = Color.Tan;
            }

        }
    }
}
