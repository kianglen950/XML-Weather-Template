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
            date1Output.Text = Form1.days[1].date;
            min1Output.Text = Form1.days[1].tempLow;
            max1Output.Text = Form1.days[1].tempHigh;

            string url = $"https://openweathermap.org/img/wn/{Form1.days[0].icon}@2x.png";
            forecastIconBox.LoadAsync(url);
            BackgroundChange();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
        public void BackgroundChange()
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
    }
}
