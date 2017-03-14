using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using application.Domain.Abstract;

namespace application.WebUI.Controllers
{
    public class SizeRolController : Controller
    {
        private IRolReopository _repository;

        public SizeRolController(IRolReopository repo)
        {
            _repository = repo;
        }

        public PartialViewResult SizeRol()
        {
            var query = _repository.rolSize.Where(r => r.TypyId == 1);

            return PartialView(query);
        }
        public PartialViewResult SizeUniversal(int id)
        {
            if (id == 2)
            {
                var query = _repository.rolSize.Where(r => r.TypyId == 2).Where(p => p.IsDayNight == true);
                return PartialView(query);
            }
            else
            {
                var query = _repository.rolSize.Where(r => r.TypyId == 2).Where(p => p.IsDayNight == false);
                return PartialView(query);
            }
        }
    }
}