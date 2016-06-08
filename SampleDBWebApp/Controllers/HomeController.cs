using SampleDBWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleDBWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Student> students = new List<Student>();
            using (SchoolContext context = new SchoolContext())
            {
                students.AddRange(context.Students);
            }
            return View(students);
        }
    }
}