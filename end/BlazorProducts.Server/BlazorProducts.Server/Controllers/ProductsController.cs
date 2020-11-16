using System;
using System.Threading.Tasks;
using BlazorProducts.Server.Repository;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace BlazorProducts.Server.Controllers
{
	[Route("api/products")]
	[ApiController]
	public class ProductsController : ControllerBase
	{
		private readonly IProductRepository _repo;

		public ProductsController(IProductRepository repo)
		{
			_repo = repo;
		}

		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] ProductParameters productParams)
		{
			var products = await _repo.GetProducts(productParams);
			return Ok(products);
		}
	}
}