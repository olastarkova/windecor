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
        private IProductReopository _repository;
        public ColorController(IProductReopository repo)
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
            var query = _repository.Rolcollections.Where(p => p.collectionEntity.Id == id).FirstOrDefault();

            return PartialView(query);
        }
    }
}