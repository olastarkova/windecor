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
        public int PageSize = 4; //Колличество товара на странице

        public IRoshtoryReopository repository;

        public ProductController(IRoshtoryReopository rolshotyRepository)
        {
            repository = rolshotyRepository;
        }

        // GET: Product
        public ViewResult List(int page = 1)
        {
            ProductsListViewModel viewModel = new ProductsListViewModel
            {
                Products = repository.rolshtorys
                .OrderBy(p => p.Id)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.rolshtorys.Count()
                }
                };
            return View(viewModel); 
               
        }  
    }
}