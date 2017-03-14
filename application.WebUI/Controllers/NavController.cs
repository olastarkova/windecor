using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using application.Domain.Abstract;


namespace application.WebUI.Controllers
{
    public class NavController : Controller
    {
        private IRolReopository _repository;

        public NavController(IRolReopository repo)
        {
            _repository = repo;
        }

        // GET: Nav
        public PartialViewResult Menu(string category = null)
        {
            IEnumerable<string> categories = _repository.rolCategories
                .Select(c => c.Category)
                .OrderBy(c => c);

            return PartialView(categories);
        }
    }
}