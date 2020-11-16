using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorProducts.Server.Repository
{
	public interface IProductRepository
	{
		Task<VirtualizeResponse<Product>> GetProducts(ProductParameters productParams);
	}
}
