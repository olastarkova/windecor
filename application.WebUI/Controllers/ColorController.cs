using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using application.Domain.Abstract;


namespace application.WebUI.Controllers
{
    public class ColorController : Controller
    {
        private IRolReopository _repository;
        public ColorController(IRolReopository repo)
        {
            _repository = repo;
        }
        public PartialViewResult ColorEnumeration(int? id)
        {
            var query = _repository.Rolcollections.Where(p => p.collectionEntity.Id == id).ToList();

            return PartialView(query);
        }
        public PartialViewResult FirstColorEnumeration(int? id)
        {
            var query = _repository.Rolcollections.Where(p => p.collectionEntity.Id == id).ToList().Take(1);

            return PartialView(query);
        }
        [HttpPost]
        public ActionResult ChangeColorName(int? id)
        {
            var query = _repository.Rolcollections.Where(p => p.ID == id).ToList().Take(1);

            return PartialView(query);
         }
    }
}