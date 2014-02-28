using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskManager.Web.Models;

namespace TaskManager.Web.Controllers
{
    public class HomeController : Controller
    {
        private static TaskWeatherModel Tasks = new TaskWeatherModel();
        
        public ActionResult Index()
        {
            WeatherReference.WeatherConsultingSoapClient weatherReference = new WeatherReference.WeatherConsultingSoapClient();
            var weather = weatherReference.GetWeather("Campinas");
            Tasks.Weather = weather;
            return View(Tasks);
        }

        public ActionResult Add(String description)
        {
            TaskModel task = new TaskModel();
            task.Description = description;
            task.Status = 0;
            task.Id = Tasks.Tasks.Count + 1;

            if (!Tasks.Tasks.Exists(m => m.Description.Equals(task.Description)))
                Tasks.Tasks.Add(task);

            return PartialView("GridTask", Tasks);
        }

        public ActionResult Done(int Id)
        {
            TaskModel task = Tasks.Tasks.Find(i => i.Id == Id);
            if (task != null)
                task.Status = 1;

            return PartialView("GridTask", Tasks);
        }

        public ActionResult Undo(int Id)
        {
            TaskModel task = Tasks.Tasks.Find(i => i.Id == Id);
            if (task != null)
                task.Status = 2;

            return PartialView("GridTask", Tasks);
        }

        public ActionResult Delete(int Id)
        {
            TaskModel task = Tasks.Tasks.Find(i => i.Id == Id);
            if (task != null)
                Tasks.Tasks.Remove(task);

            return PartialView("GridTask", Tasks);
        }
          
    }
}