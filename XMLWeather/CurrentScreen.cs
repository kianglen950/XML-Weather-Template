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
        public static string searchInput; //public string for getting the input on other screen
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();

        }

        public void DisplayCurrent()
        {//fill in each output with correct information
            cityOutput.Text = Form1.days[0].location;
            dateOutput.Text = Form1.days[0].date;
            currentOutput.Text = $"{Math.Round(Convert.ToDouble(Form1.days[0].currentTemp), 0).ToString()}°C"; //get temperature, and round to whole number
            minOutput.Text = $"{Math.Round(Convert.ToDouble(Form1.days[0].tempLow), 0).ToString()}°C";
            maxOutput.Text = $"{Math.Round(Convert.ToDouble(Form1.days[0].tempHigh), 0).ToString()}°C";
            currentConditionLabel.Text = Form1.days[0].conditionName;
            humidityOutput.Text = $"Humidity: {Form1.days[0].humidity}{Form1.days[0].percent}";
            windOutput.Text = $"Wind: {Math.Round(Convert.ToDouble(Form1.days[0].windSpeed), 1)} {Form1.days[0].windUnit} {Form1.days[0].windDirection}";
            sunRiseOutput.Text = $"Sun Rise: {Form1.days[0].sunRise}";
            sunSetOutput.Text = $"Sun Set: {Form1.days[0].sunSet}";
            updateOutput.Text = $"Last updated: {Form1.days[0].updateTime}";
            string url = $"https://openweathermap.org/img/wn/{Form1.days[0].icon}@2x.png"; //get the icon using the id in the url
            iconBox.LoadAsync(url); //load async to give the program time to run
            BackgroundChange(); //call background change method
        }


        private void forecastLabel_Click(object sender, EventArgs e) //change screen to forecast screen
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        public void BackgroundChange() //method to change background, does based off numbers given for each condition
        {
            int b = Convert.ToInt32(Form1.days[0].condition);
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
        private void searchButton_Click(object sender, EventArgs e) //city search
        {
            searchInput = cityInput.Text; //get input
            Form1.days.Clear(); //clear the list

            if (Form1.ExtractForecast()) //if else statement to make sure the input works in the url
            {
                Form1.ExtractCurrent();
                DisplayCurrent();
            }
            else
            {
                cityInput.Text = "Invalid Input"; //error message if not
            }


        }
    }

}
