﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmarTaxiWeb.Controllers
{
    public class ManagementController : Controller
    {
        // GET: Management
        public ActionResult Index()
        {
            return View();
        }

        // GET: Management/CamarasTaxistas
        public ActionResult CamarasTaxistas()
        {
            return View();
        }

        // GET: Management/Mensajeria
        public ActionResult Mensajeria()
        {
            return View();
        }
       
    }
}
