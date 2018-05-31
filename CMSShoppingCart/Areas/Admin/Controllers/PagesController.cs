﻿using CMSShoppingCart.Models.Data;
using CMSShoppingCart.Models.ViewModels.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMSShoppingCart.Areas.Admin.Controllers
{
    public class PagesController : Controller
    {
        // GET: Admin/Pages
        public ActionResult Index()
        {
            List<PageVM> pagesList;

            using (Db db = new Db())
            {
                pagesList = db.Pages.ToArray().OrderBy(x => x.Sorting).Select(x => new PageVM(x)).ToList();
            }

                return View(pagesList);
        }
    }
}