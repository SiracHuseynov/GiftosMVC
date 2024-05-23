﻿using Giftos.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X.PagedList;

namespace Giftos.Business.Services.Abstracts
{
    public interface IProductService
    {
        Task AddProductAsync(Product product);
        void DeleteProduct(int id);
        void UpdateProduct(int id, Product newProduct);
        Product GetProduct(Func<Product, bool>? func = null);
        List<Product> GetAllProducts(Func<Product, bool>? func = null);
        Task<IPagedList<Product>> GetPaginatedProductAsync(int pageIndex, int pageSize);


    }
}
