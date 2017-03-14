using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using application.Domain.Abstract;
using application.WebUI.Models;

namespace application.WebUI.Controllers
{
    public class EavesController : Controller
    {
        public IEavesRepository _repository;

        public EavesController(IEavesRepository repo)
        {
            _repository = repo;
        }
        // GET: Eaves
        public ViewResult Series(string category)
        {
            var query = _repository.EavesCollections.AsQueryable();
            if (category != null)
            {
                query = query.Where(p => p.eavesCategoriesEntity.Name == category);
            }
            var viewModel = new ProductsListViewModel
            {
                EavesCollection = query,
                CurrentCategory = category
            };
            return View(viewModel);
        }
        public ViewResult Details(int? id)
        {
            var query = _repository.EavesCollections.Where(q => q.Id == id).FirstOrDefault();

            return View(query);
        }
        public ViewResult ItemDetails(int? id)
        {
            var itemDetail = _repository.EavesCollectionItems.Where(i => i.Id == id).FirstOrDefault();
            return View(itemDetail);
        }
        public PartialViewResult EavesItems(int? id)
        {
            var eavesItems = _repository.EavesCollectionItems.Where(e => e.eavesCollectionEntity.Id == id).ToList();

            return PartialView(eavesItems);
        }
        public PartialViewResult EavesColor(int? id)
        {
            var eavesColor = _repository.EavesItemsColors.Where(e => e.eavesCollectionItemsEntity.Id == id).ToList();
            return PartialView(eavesColor);
        }
        public PartialViewResult FirstEavesColor(int? id)
        {
            var firstEavesColor = _repository.EavesItemsColors.Where(e => e.eavesCollectionItemsEntity.Id == id).ToList().Take(1);
            return PartialView(firstEavesColor);
        }
    }
}