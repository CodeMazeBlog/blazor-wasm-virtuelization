using BlazorProducts.Server.Context;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProducts.Server.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _context;

        public ProductRepository(ProductContext context)
        {
            _context = context;
        }

		public async Task<VirtualizeResponse<Product>> GetProducts(ProductParameters productParams)
		{
			var totalSize = await _context.Products.CountAsync();
			var items = await _context.Products
				.OrderBy(p => p.ItemNumber)
				.Skip(productParams.StartIndex)
				.Take(productParams.PageSize)
				.ToListAsync();

			return new VirtualizeResponse<Product> { Items = items, TotalSize = totalSize };
		}
	}
}
