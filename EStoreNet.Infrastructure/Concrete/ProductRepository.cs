using EStoreNet.Core.Abstract;
using EStoreNet.Core.Entitites;
using EStoreNet.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStoreNet.Infrastructure.Concrete
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreContext context;
        public ProductRepository(StoreContext context)
        {
            this.context = context;
        }

        public async Task<Product> GetProductByIdAsync(int id) => await context.Products.FindAsync(id);

        public async Task<IReadOnlyList<Product>> GetProductsAsync() => await context.Products.ToListAsync();
    }
}
