using Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Example.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<BikeModel> list = new List<BikeModel>();
            list.Add(new BikeModel("001", "bmx", "model1", "blue"));
            list.Add(new BikeModel("002", "bmx", "model1", "red"));
            list.Add(new BikeModel("003", "bmx", "model1", "pink"));


            return View(list);
        }
    }
}