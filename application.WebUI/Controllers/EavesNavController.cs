using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using application.Domain.Abstract;

namespace application.WebUI.Controllers
{
    public class EavesNavController : Controller
    {
        private IEavesRepository _repository;
        public EavesNavController (IEavesRepository repo)
        {
            _repository = repo;
        }
        // GET: EavesNav
        public PartialViewResult EavesMenu(string category = null)
        {
            IEnumerable<string> eavesCategories = _repository.EavesCatogories
                .Select(c => c.Name)
                .OrderBy(c => c);

            return PartialView(eavesCategories);
        }
    }
}