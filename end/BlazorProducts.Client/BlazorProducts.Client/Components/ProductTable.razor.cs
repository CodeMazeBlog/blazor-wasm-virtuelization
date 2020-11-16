using Entities;
using Entities.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProducts.Client.Components
{
	public partial class ProductTable
	{
		[Parameter]
		public List<Product> Products { get; set; }

		[Parameter]
		public int TotalSize { get; set; }

		[Parameter]
		public EventCallback<ProductParameters> OnScroll { get; set; }

		private async ValueTask<ItemsProviderResult<Product>> LoadProducts(ItemsProviderRequest request)
		{
			var productNum = Math.Min(request.Count, TotalSize - request.StartIndex);
			await OnScroll.InvokeAsync(new ProductParameters
			{
				StartIndex = request.StartIndex,
				PageSize = productNum == 0 ? request.Count : productNum
			});

			return new ItemsProviderResult<Product>(Products, TotalSize);
		}
	}
}
