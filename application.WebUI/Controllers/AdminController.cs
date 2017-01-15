using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using application.Domain.Enitites;
using application.Domain.Concrete;
using application.Domain.Abstract;


namespace application.WebUI.Controllers
{
    public class AdminController : Controller
    {
        public IProductReopository repository;

        public AdminController(IProductReopository rolshotyRepository)
        {
            repository = rolshotyRepository;
        }
        public ViewResult Index()
        {
            return View(repository.Products);
        }
        public ActionResult Edit()
        {
            return View();
        }
        // GET: Admin
        //[HttpPost]
        //public ActionResult Edit(Product rolshtory, HttpPostedFileBase image = null)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        if (image != null)
        //        {
        //            rolshtory.ImageMimeType = image.ContentType;
        //            rolshtory.ImageData = new byte[image.ContentLength];
        //            image.InputStream.Read(rolshtory.ImageData, 0, image.ContentLength);
        //        }
        //        repository.SaveProduct(rolshtory);
        //        TempData["message"] = string.Format("Изменения в игре \"{0}\" были сохранены", rolshtory.Id);
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        // Что-то не так со значениями данных
        //        return View(rolshtory);
        //    }
        //}
    }
}