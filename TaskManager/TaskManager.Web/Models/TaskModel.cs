using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskManager.Web.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
    }
}