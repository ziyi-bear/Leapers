using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leapers
{
    /*
     * 這裡用於建立新的物件-JSON資料的物件格式
     * 格式來源:http://openweathermap.org/current
     * 最後更新日期2016/08/04
     * 
    */
    public class OpenWeatherJsonData
    {
        public class Coord //JSON內的物件資料格式
        {
            public double lon { get; set; } //API說明文件:City geo location, longitude
            public double lat { get; set; } //API說明文件:City geo location, latitude
        }
        public class weather //JSON內的物件資料格式 API說明文件:(more info Weather condition codes)
        {
            public int id { get; set; } //API說明文件:Weather condition id
            public string main { get; set; } //API說明文件:Group of weather parameters (Rain, Snow, Extreme etc.)
            public string description { get; set; } //API說明文件:Weather condition within the group
            public string icon { get; set; } //API說明文件:Weather icon id
        }
        public class main //JSON內的物件資料格式
        {
            public double temp { get; set; } //API說明文件:Temperature. Unit Default: Kelvin, Metric: Celsius, Imperial: Fahrenheit.
            public double pressure { get; set; } //API說明文件:Atmospheric pressure (on the sea level, if there is no sea_level or grnd_level data), hPa
            public int humidity { get; set; } //API說明文件:Humidity, %
            public double temp_min { get; set; } //API說明文件:Minimum temperature at the moment. This is deviation from current temp that is possible for large cities and megalopolises geographically expanded (use these parameter optionally). Unit Default: Kelvin, Metric: Celsius, Imperial: Fahrenheit.
            public double temp_max { get; set; } //API說明文件:Maximum temperature at the moment. This is deviation from current temp that is possible for large cities and megalopolises geographically expanded (use these parameter optionally). Unit Default: Kelvin, Metric: Celsius, Imperial: Fahrenheit.
            public double sea_level { get; set; } //API說明文件:Atmospheric pressure on the sea level, hPa
            public double grnd_level { get; set; } //API說明文件:Atmospheric pressure on the ground level, hPa
        }
        public class wind
        {
            public double speed { get; set; } //API說明文件
        }
        public OpenWeatherJsonData()
        {

        }
    }
}
