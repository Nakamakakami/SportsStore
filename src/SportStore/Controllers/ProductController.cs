using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using SportsStore.Models.ViewModels;

namespace SportsStore.Controllers
{

    public class ProductController : Controller
    {
        private IProductRepository repository;
        public int PageSize { get; set; } = 2;
        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }
        public ViewResult List(string category,int page = 1) => View(new ProductsListViewModel
        {
            Products = repository.Products
            .Where(p=> category == null || p.Category == category)
            .OrderBy(p => p.ProductID)
            .Skip((page - 1) * PageSize)
            .Take(PageSize),
            PagingInfo = new PagingInfo
            {
                CurrentPage = page,
                ItemsPerPage = PageSize,
                TotalItems = repository.Products.Count()
            }, CurrentCategory = category
        });
    }

}