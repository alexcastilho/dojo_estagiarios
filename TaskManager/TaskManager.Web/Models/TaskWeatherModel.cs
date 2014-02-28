using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskManager.Web.Models
{
    public class TaskWeatherModel
    {
        public List<TaskModel> Tasks { get; set; }
        public WeatherReference.Weather Weather { get; set; }

        public TaskWeatherModel()
        {
            Tasks = new List<TaskModel>();
        }

    }
}