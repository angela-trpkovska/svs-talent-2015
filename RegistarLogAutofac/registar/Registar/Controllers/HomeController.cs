using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Registar.BusinessLayer;
using Registar.BusinessLayer.Contracts;
using Registar.Models;
using System.Data.Entity;
using Registar.DataLayer;
using Registar.DomainModel;
using log4net;
using System.IO;


namespace Registar.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
             //call BL
            //BikeSearchCommand _command = new BikeSearchCommand();
            //BikeSearchResult _result = CommandInvoker.InvokeCommand<BikeSearchCommand, BikeSearchResult>(_command);
            //
          
            BikeSearchResult result=new BikeSearchResult();
            result.Result=new List<Bike>();
            //return View("Index",_result.Result);
            return View("Index", result.Result);
        }

        public ActionResult Index3()
        {
            return View("Index3");
        
        }

        //result to convert data to json
       [HttpPost]
        public ActionResult JsonData()
        {
            BikeSearchCommand _command = new BikeSearchCommand();
            BikeSearchResult _result = CommandInvoker.InvokeCommand<BikeSearchCommand, BikeSearchResult>(_command);
            return Json( _result.Result, JsonRequestBehavior.AllowGet);
            
        }
        

 


        public ActionResult Index2()
        {
            List<BikeModel> _result = new List<BikeModel>();
            _result.Add(new BikeModel() { Colour = "red", Model = "R1", Producer = "Specialized", RegNumber = "007" });
            _result.Add(new BikeModel() { Colour = "red", Model = "R1", Producer = "Specialized", RegNumber = "007" });
            _result.Add(new BikeModel() { Colour = "red", Model = "R1", Producer = "Specialized", RegNumber = "007" });
            _result.Add(new BikeModel() { Colour = "red", Model = "R1", Producer = "Specialized", RegNumber = "007" });
            //
            this.ViewBag.SomeNewProperty = "theValue";
            this.ViewData["SomeNewProperty"] = "theValue";
            //
            return View("Index",_result);
        }

    }
}
