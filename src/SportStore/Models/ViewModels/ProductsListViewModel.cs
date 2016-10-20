using System.Collections.Generic;
using SportsStore.Models;
using SportsStore.Models.ViewModels;

namespace SportsStore.Models.ViewModels
{
    public class ProductsListViewModel
    {
        public PagingInfo PagingInfo { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}