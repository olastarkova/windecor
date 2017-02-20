using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using application.Domain.Enitites;
using application.Domain.Abstract;
using application.Domain.Concrete;
using application.WebUI.Models;

namespace application.WebUI.Controllers
{
    public class ProductController : Controller
    {
        public int PageSize = 10000; //Колличество товара на странице

        public IProductReopository repository;

        public ProductController(IProductReopository ProductRepository)
        {
            repository = ProductRepository;
        }

        // GET: Product
        public ViewResult List(string category, int page = 1)
        {

            var products = repository.Products.AsQueryable();
            if (category != null)
            {
                products = products.Where(p => p.CategoryEntity.Category == category);

            }

            products = products
               .OrderBy(p => p.Id)
               .Skip((page - 1) * PageSize)
               .Take(PageSize);
            var viewModel = new ProductsListViewModel
            {
                Products = products,

                //PagingInfo = new PagingInfo
                //{
                //    CurrentPage = page,
                //    ItemsPerPage = PageSize,
                //    TotalItems = category == null ?
                //    repository.Products.Count() :
                //    repository.Products.Where(e => e.Category == category).Count()
                //},
                CurrentCategory = category
            };
            return View(viewModel);

        }
        public ViewResult Details(int? id)
        {
            Product query = repository.Products.Where(p => p.Id == id).FirstOrDefault();

            return View(query);
        }
        //public FileContentResult getImage(int productId)
        //{
        //    Product rol = repository.rolshtorys.FirstOrDefault(p => p.Id == productId);
        //    if(rol !=null)
        //    {
        //        return File(rol.ImageData, rol.ImageMimeType);

        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
    }
}