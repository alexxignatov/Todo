using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Todo.Controllers
{
    public class MainController : Controller
    {
        List<string> repository = new List<string>() { "do homework", "sleep" };

        [HttpGet]
        public ActionResult Index()
        {
            return View(repository);
        }

        public ActionResult Update(string val)
        {
            return View(val);
        }

        public ActionResult UpdateAjax(string val)
        {
            repository.Add(val);
            return PartialView("_UpdatePartial", val);
        }
    }
}
