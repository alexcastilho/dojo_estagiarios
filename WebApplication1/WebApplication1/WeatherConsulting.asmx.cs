using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for WeatherConsulting
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WeatherConsulting : System.Web.Services.WebService
    {

        [WebMethod]
        public Weather.Model.Weather GetWeather(string city)
        {
            Weather.Model.Weather weather = new Weather.Model.Weather();
            weather.City = city;
            weather.Temperature = Convert.ToDouble(new Random().Next(10, 50));
            if (weather.Temperature >= 30)
            {
                weather.Description = "Ensolarado";
            }
            else if (weather.Temperature > 10 && weather.Temperature < 30)
            {
                weather.Description = "Nublado";
            }
            else
            {
                weather.Description = "Chuvoso";
            }

            return weather;

        }
    }
}
