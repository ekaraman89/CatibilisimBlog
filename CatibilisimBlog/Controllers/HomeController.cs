using CatibilisimBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace CatibilisimBlog.Controllers
{
    public class HomeController : Controller
    {
        CatibilisimBlogEntities DB = new CatibilisimBlogEntities();



        public ActionResult Index()
        {
            
            return View(DB.Makale.ToList());
        }
    }
}