using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataViewToController.Controllers
{
    public class TestController : Controller
    { 
        //For First time binding
        public ActionResult Index()
        {
            ViewModels.Programming programming = new ViewModels.Programming();
            programming.selectedType = 1;
            programming.selectedLanguange = "Microsoft C#";

            
            return View(programming);
        }


        //4 methods to pass data from view to controller
        //1. FormCollection
        //2. Strong Type Model Binding
        //3. Parameter
        //4. HTTP Web Request
        [HttpPost]
        public JsonResult Form(FormCollection f, ViewModels.Programming programming, string parameter)
        {
             
            List<string> formCollection = new List<string>();
            List<string> request = new List<string>();
            List<string> viewmodel = new List<string>();
            List<string> parameters = new List<string>();
            
            //1. FormCollection
            foreach (var a in f.AllKeys) {
                formCollection.Add("name=" + a + ",Value=" + f[a]);
            }

            //2. Strong Type Model Binding
            viewmodel.Add("selectedType=" + programming.selectedType.ToString());
            viewmodel.Add("selectedLanguange=" + programming.selectedLanguange);

            //3. Parameter
            parameters.Add(parameter);

            //4. HTTP Web Request
            request.Add(Request["parameter"].ToString());

            return Json(new { formCollection, viewmodel,parameters, request });
        }

        //4. AJAX Call
        [HttpPost]
        public JsonResult Ajax(string AJAXParameter1, string AJAXParameter2)
        {
            List<string> data = new List<string>();
            data.Add("AJAXParameter1=" + AJAXParameter1);
            data.Add("AJAXParameter2=" + AJAXParameter2);
            return Json(new { data, result = "OK" });
        }

         
    }
}
