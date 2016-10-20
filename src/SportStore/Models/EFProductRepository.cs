using SportsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore.Models
{
    public class EFProductRepository : IProductRepository
    {
        public ApplicationDbContext Context{ get; }
        public EFProductRepository(ApplicationDbContext ctx)
        {
            Context = ctx;
        }

        public IEnumerable<Product> Products => Context.Products;
    }
}
