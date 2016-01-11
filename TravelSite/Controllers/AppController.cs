using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelSite.Services;
using TravelSite.ViewModels;

namespace TravelSite.Controllers
{
    public class AppController : Controller
    {
        //private IMailService _mailService;

        //public AppController()
        //{

        //}

        //public AppController(IMailService service)
        //{
        //    _mailService = service;
        //}

        // GET: App
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                DebugMailService service = new DebugMailService();
                service.SendMail(model.Email, model.Name, "Hello", model.Message);
            }
            ModelState.Clear();
            ViewBag.Message = "Mail Sent . Thanks !!";
            return View();
        }


    }
}