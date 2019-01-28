﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(String Category)
        {
            ViewBag.Message = "Your categories Page.";
            ViewBag.CategoryName = Category;
            return View();
        }
    }
}