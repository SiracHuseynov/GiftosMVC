﻿using Giftos.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X.PagedList;

namespace Giftos.Core.RepositoryAbstracts
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<IPagedList<Product>> GetPaginatedProductsAsync(int pageIndex, int pageSize);
    }
}
