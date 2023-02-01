using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace task1_2_2023.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            List<Student> emp = new List<Student>();
            emp.Add(new Student { ID = 5, Name = "Ayah", Major = "Network", Faculity = "balqa'a" });
            emp.Add(new Student { ID = 2, Name = "Rama", Major = "Finace", Faculity = "Yurmouk" });

            return View(emp);
        }
    }
}