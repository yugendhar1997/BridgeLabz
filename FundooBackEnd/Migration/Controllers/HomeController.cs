using Microsoft.AspNetCore.Mvc;
using Migration.Migrations;
using Migration.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Migration.Controllers
{
    public class HomeController : System.Web.Mvc.Controller
    {
        UserContext UContext;
        public HomeController()
        {
            UContext = new UserContext();
        }

        public System.Web.Mvc.ActionResult Index()
        {
            List<Student> list = new List<Student>();
            list = UContext.student.ToList();
            return View(model: list);
        }
    }
}
