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
        private static List<TaskModel> listTask = new List<TaskModel>();
        
        public ActionResult Index()
        {
            return View(listTask);
        }

        public ActionResult Add(String description)
        {
            TaskModel task = new TaskModel();
            task.Description = description;
            task.Status = 0;
            task.Id = listTask.Count + 1;

            if (!listTask.Exists(m => m.Description.Equals(task.Description)))
                listTask.Add(task);

            return PartialView("GridTask", listTask);
        }

        public ActionResult Done(int Id)
        {
            TaskModel task = listTask.Find(i => i.Id == Id);
            if (task != null)
                task.Status = 1;

            return PartialView("GridTask", listTask);
        }

        public ActionResult Undo(int Id)
        {
            TaskModel task = listTask.Find(i => i.Id == Id);
            if (task != null)
                task.Status = 2;

            return PartialView("GridTask", listTask);
        }

        public ActionResult Delete(int Id)
        {
            TaskModel task = listTask.Find(i => i.Id == Id);
            if (task != null)
                listTask.Remove(task);

            return PartialView("GridTask", listTask);
        }
          
    }
}