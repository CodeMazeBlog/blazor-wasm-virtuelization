using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorProducts.Client.HttpRepository
{
	public class ProductHttpRepository : IProductHttpRepository
	{
		private readonly HttpClient _client;

		public ProductHttpRepository(HttpClient client)
		{
			_client = client;
		}

		public async Task<List<Product>> GetProducts()
		{
			var products =
				await _client.GetFromJsonAsync<List<Product>>("products");

			return products;
		}
	}
}
