﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clientes.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        public ActionResult Index()
        {
            return View();
        }
    }
}