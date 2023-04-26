using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    public class Day
    { //delcare variables
        public string date, currentTemp, currentTime, condition, conditionName, location, tempHigh, tempLow, 
            windSpeed, windDirection, precipitation, visibility, humidity, percent, tempUnit, icon, windUnit, sunRise, sunSet, updateTime;

        public Day()
        { //make them usable on other screens
            date = currentTemp = currentTime = condition = location = tempHigh = tempLow
                = windSpeed = windDirection = precipitation = visibility = humidity = percent = tempUnit = conditionName = icon = windUnit = sunRise = sunSet = updateTime = "";
        }
    }
}
