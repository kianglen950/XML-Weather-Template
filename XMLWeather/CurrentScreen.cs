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
            cityOutput.Text = Form1.days[0].location;
            dateOutput.Text = Form1.days[0].date;
            currentOutput.Text = $"{Math.Round(Convert.ToDouble(Form1.days[0].currentTemp), 0).ToString()}°C";
            minOutput.Text = $"{Math.Round(Convert.ToDouble(Form1.days[0].tempLow), 0).ToString()}°C";
            maxOutput.Text = $"{Math.Round(Convert.ToDouble(Form1.days[0].tempHigh), 0).ToString()}°C";
            conditionOutput.Text = Form1.days[0].condition;
            currentConditionLabel.Text =$"Condition: {Form1.days[0].conditionName}";
            humidityOutput.Text =$"Humidity: {Form1.days[0].humidity}{Form1.days[0].percent}";

            BackgroundChange();
        }


        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
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
            else if(b >= 300 && b <= 321) //drizzle
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
