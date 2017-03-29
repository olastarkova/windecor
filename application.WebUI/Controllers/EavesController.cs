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
        public PartialViewResult PipeEaves(int? id)
        {
            var pipeEaves = _repository.PipesColors.Where(p => p.eavesCollectionEntity.Id == id).ToList().Take(1);
            return PartialView(pipeEaves);
        }
        public PartialViewResult PipeEavesAllColors(int? id, int? id2)
        {
            var pipeEavesAllColorsAdditional = _repository.EavesItemsColors.Where(q => q.eavesCollectionItemsEntity.Id ==id2).FirstOrDefault();
           
            var pipeEavesAllColors = _repository.PipesColors.Where(p => p.eavesCollectionEntity.Id == id && p.eavesColorsEntity.Id == pipeEavesAllColorsAdditional.eavesColorsEntity.Id).GroupBy(p => p.pipesEntity.Id).Select(s=>s.FirstOrDefault()).ToList();
            return PartialView(pipeEavesAllColors);
        }
        public PartialViewResult PipeSizeAll (int? id)
        {
            var pipeSizeAllAdditional = _repository.PipesColors.Where(p => p.eavesCollectionEntity.Id == id).First();

            var pipeSizeAll = _repository.EavesSizes.Where(p => p.eavesCollectionEntity.Id == id && p.pipesEntity.Id == pipeSizeAllAdditional.pipesEntity.Id).OrderBy(p => p.pipesSizeEntity.Id).ToList();
            return PartialView(pipeSizeAll);
        }
        public PartialViewResult PipeItemAll(int? id, int?id2)
        {
            var pipeItemAllAdditional = _repository.EavesItemsColors.Where(p => p.eavesCollectionItemsEntity.Id == id2).First();
            
            var pipeItemAll = _repository.EavesCollectionTypes.Where(p => p.eavesCollectionEntity.Id == id && p.eavesColorsEntity.Id == pipeItemAllAdditional.eavesColorsEntity.Id).ToList();
            return PartialView(pipeItemAll);
        }
        public PartialViewResult PipeFasteningAll(int? id, int? id2)
        {
            var pipeFasteningAllAdditional = _repository.EavesItemsColors.Where(p => p.eavesCollectionItemsEntity.Id == id2).FirstOrDefault();
            var pipeFasteningAllAdditional2 = _repository.EavesCollectionTypes.Where(p => p.eavesCollectionEntity.Id == id).FirstOrDefault();
            var pipeFasteningAll = _repository.EavesCollectionFasteningsByColors.Where(p => p.eavesCollectionFasteningsEntity.eavesCollectionEntity.Id == id && p.eavesCollectionFasteningsEntity.eavesTypesEntity.Id == pipeFasteningAllAdditional2.eavesTypesEntity.Id && p.eavesColors.Id == pipeFasteningAllAdditional.eavesColorsEntity.Id).ToList();
            return PartialView(pipeFasteningAll);
        }
        public PartialViewResult PipeFasteningNameAll(int? id, int? id2)
        {
            var pipeFasteningAllAdditional = _repository.EavesItemsColors.Where(p => p.eavesCollectionItemsEntity.Id == id2).FirstOrDefault();
            var pipeFasteningAllAdditional2 = _repository.EavesCollectionTypes.Where(p => p.eavesCollectionEntity.Id == id).FirstOrDefault();
            var pipeFasteningNameAll = _repository.EavesCollectionFasteningsByColors.Where(p => p.eavesCollectionFasteningsEntity.eavesCollectionEntity.Id == id && p.eavesCollectionFasteningsEntity.eavesTypesEntity.Id == pipeFasteningAllAdditional2.eavesTypesEntity.Id && p.eavesColors.Id == pipeFasteningAllAdditional.eavesColorsEntity.Id).Take(1).ToList();

            return PartialView(pipeFasteningNameAll);
        }
        public PartialViewResult PipeRingAll(int? id, int? id2)
        {
            var pipeRingAllAdditional = _repository.EavesItemsColors.Where(p => p.eavesCollectionItemsEntity.Id == id2).FirstOrDefault();
            var pipeRingAll = _repository.EavesCollectionRings.Where(p => p.eavesCollectionEntity.Id == id && p.eavesColorsEntity.Id == pipeRingAllAdditional.eavesColorsEntity.Id).ToList();
            return PartialView(pipeRingAll);
        }
        public PartialViewResult PipeRingNameAll(int? id, int? id2)
        {
            var pipeRingNameAllAdditional = _repository.EavesItemsColors.Where(p => p.eavesCollectionItemsEntity.Id == id2).FirstOrDefault();
            var pipeRingNameAll = _repository.EavesCollectionRings.Where(p => p.eavesCollectionEntity.Id == id && p.eavesColorsEntity.Id == pipeRingNameAllAdditional.eavesColorsEntity.Id).Take(1).ToList();
            return PartialView(pipeRingNameAll);
        }
        [HttpPost]
        public PartialViewResult ChangePipeEavesAllColors(int? id)
        {
            var eavesColor = _repository.EavesColors.Where(e => e.Id == id).ToList();
            return PartialView(eavesColor);
        }
        [HttpPost]
        public PartialViewResult ChangePipeList(int? id, int? idcol)
        {
            var query = _repository.PipesColors.Where(q => q.eavesColorsEntity.Id == id && q.eavesCollectionEntity.Id == idcol).ToList();
            return PartialView(query);
        }
        [HttpPost]
        public PartialViewResult ChangePipeName(int? id)
        {
            var changeName = _repository.Pipes.Where(c => c.Id == id).ToList();

            return PartialView(changeName);
        }
        [HttpPost]
        public ActionResult ChangeSizeList(int? id, int? idcol)
        {
            var query = _repository.EavesSizes.Where(c => c.pipesEntity.Id == id && c.eavesCollectionEntity.Id == idcol).ToList();
            return PartialView(query);
        }
        [HttpPost]
        public ActionResult ChangeFasteningName(int? id)
        {
            var changeName = _repository.EavesCollectionFastenings.Where(c => c.Id == id).ToList();
            return PartialView(changeName);
        }
    }
}
