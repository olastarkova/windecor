using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using application.Domain.Abstract;
using application.WebUI.Models;

namespace application.WebUI.Controllers
{
    public class NavController : Controller
    {
        private IProductReopository repository;

        public NavController(IProductReopository repo)
        {
            repository = repo;
        }
        // GET: Nav
       public PartialViewResult Menu(string category=null)
        {
            //ViewBag.SelectedCategory = category;

            IEnumerable<string> categories = repository.rolCategories
                .Select(c => c.Category)
                .OrderBy(c => c);

            return PartialView(categories);
        }
    }
}