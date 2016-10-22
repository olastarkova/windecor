using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using application.Domain.Abstract;

namespace application.WebUI.Controllers
{
    public class ArticleController : Controller
    {
        private IroshtoryReopository repository;
        
        public ArticleController(IroshtoryReopository rolshtoryRepository)
        {
            this.repository = rolshtoryRepository;

        }
       public ViewResult List()
        {
            return View(repository.rolshtorys);
        }
    }
}