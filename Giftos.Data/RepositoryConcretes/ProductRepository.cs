using Giftos.Core.Models;
using Giftos.Core.RepositoryAbstracts;
using Giftos.Data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X.PagedList;

namespace Giftos.Data.RepositoryConcretes
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly AppDbContext _appDbContext;
        public ProductRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IPagedList<Product>> GetPaginatedProductsAsync(int pageIndex, int pageSize)
        {
            var query = _appDbContext.Products.AsQueryable();
            return await query.ToPagedListAsync(pageIndex, pageSize);   
        }
    }
}

