﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical_10.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index(string id)
        {
            ViewBag.Name = id;
            return View();
        }
    }
}