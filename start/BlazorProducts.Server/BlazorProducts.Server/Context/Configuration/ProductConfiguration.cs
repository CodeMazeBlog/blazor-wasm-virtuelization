using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProducts.Server.Context.Configuration
{
	public class ProductConfiguration : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			var count = 0;

			builder.HasData
			(
				//Mugs
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Travel Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161969.4889/mug,travel,x1000,center-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 11
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Classic Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063377597.4889/ur,mug_lifestyle,square,1000x1000.u2.jpg",
					Price = 22
				},
				//Clothing
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Code Maze Logo T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,vneck,x1900,101010:01c5ca27c6,front-c,160,70,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 20
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Pullover Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodie,mens,101010:01c5ca27c6,front,square_three_quarter,x1000-bg,f8f8f8.1u2.jpg",
					Price = 30
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Fitted Scoop T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodiez,mens,101010:01c5ca27c6,front,square_three_quarter,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 40
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Zipped Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,fitted_scoop,x2000,101010:01c5ca27c6,front-c,160,143,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 55
				},
				//Phone
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPhone Case & Cover",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,iphone_11_soft,back,a,x1000-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Case & Skin for Samsung Galaxy",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,samsung_galaxy_s10_snap,back,a,x1000-pad,1000x1000,f8f8f8.1u2.jpg",
					Price = 35
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPad Case & Skin",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063329780.4889/mwo,x1000,ipad_2_snap-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 45
				},
				//Home
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Wall Clock",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161997.4889/clkc,bamboo,white,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 25
				},
				//Mugs
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Travel Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161969.4889/mug,travel,x1000,center-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 11
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Classic Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063377597.4889/ur,mug_lifestyle,square,1000x1000.u2.jpg",
					Price = 22
				},
				//Clothing
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Code Maze Logo T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,vneck,x1900,101010:01c5ca27c6,front-c,160,70,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 20
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Pullover Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodie,mens,101010:01c5ca27c6,front,square_three_quarter,x1000-bg,f8f8f8.1u2.jpg",
					Price = 30
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Fitted Scoop T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodiez,mens,101010:01c5ca27c6,front,square_three_quarter,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 40
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Zipped Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,fitted_scoop,x2000,101010:01c5ca27c6,front-c,160,143,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 55
				},
				//Phone
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPhone Case & Cover",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,iphone_11_soft,back,a,x1000-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Case & Skin for Samsung Galaxy",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,samsung_galaxy_s10_snap,back,a,x1000-pad,1000x1000,f8f8f8.1u2.jpg",
					Price = 35
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPad Case & Skin",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063329780.4889/mwo,x1000,ipad_2_snap-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 45
				},
				//Home
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Wall Clock",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161997.4889/clkc,bamboo,white,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 25
				},
				//Mugs
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Travel Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161969.4889/mug,travel,x1000,center-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 11
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Classic Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063377597.4889/ur,mug_lifestyle,square,1000x1000.u2.jpg",
					Price = 22
				},
				//Clothing
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Code Maze Logo T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,vneck,x1900,101010:01c5ca27c6,front-c,160,70,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 20
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Pullover Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodie,mens,101010:01c5ca27c6,front,square_three_quarter,x1000-bg,f8f8f8.1u2.jpg",
					Price = 30
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Fitted Scoop T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodiez,mens,101010:01c5ca27c6,front,square_three_quarter,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 40
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Zipped Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,fitted_scoop,x2000,101010:01c5ca27c6,front-c,160,143,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 55
				},
				//Phone
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPhone Case & Cover",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,iphone_11_soft,back,a,x1000-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Case & Skin for Samsung Galaxy",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,samsung_galaxy_s10_snap,back,a,x1000-pad,1000x1000,f8f8f8.1u2.jpg",
					Price = 35
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPad Case & Skin",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063329780.4889/mwo,x1000,ipad_2_snap-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 45
				},
				//Home
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Wall Clock",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161997.4889/clkc,bamboo,white,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 25
				},
				//Mugs
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Travel Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161969.4889/mug,travel,x1000,center-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 11
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Classic Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063377597.4889/ur,mug_lifestyle,square,1000x1000.u2.jpg",
					Price = 22
				},
				//Clothing
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Code Maze Logo T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,vneck,x1900,101010:01c5ca27c6,front-c,160,70,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 20
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Pullover Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodie,mens,101010:01c5ca27c6,front,square_three_quarter,x1000-bg,f8f8f8.1u2.jpg",
					Price = 30
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Fitted Scoop T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodiez,mens,101010:01c5ca27c6,front,square_three_quarter,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 40
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Zipped Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,fitted_scoop,x2000,101010:01c5ca27c6,front-c,160,143,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 55
				},
				//Phone
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPhone Case & Cover",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,iphone_11_soft,back,a,x1000-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Case & Skin for Samsung Galaxy",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,samsung_galaxy_s10_snap,back,a,x1000-pad,1000x1000,f8f8f8.1u2.jpg",
					Price = 35
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPad Case & Skin",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063329780.4889/mwo,x1000,ipad_2_snap-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 45
				},
				//Home
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Wall Clock",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161997.4889/clkc,bamboo,white,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 25
				},
				//Mugs
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Travel Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161969.4889/mug,travel,x1000,center-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 11
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Classic Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063377597.4889/ur,mug_lifestyle,square,1000x1000.u2.jpg",
					Price = 22
				},
				//Clothing
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Code Maze Logo T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,vneck,x1900,101010:01c5ca27c6,front-c,160,70,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 20
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Pullover Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodie,mens,101010:01c5ca27c6,front,square_three_quarter,x1000-bg,f8f8f8.1u2.jpg",
					Price = 30
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Fitted Scoop T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodiez,mens,101010:01c5ca27c6,front,square_three_quarter,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 40
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Zipped Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,fitted_scoop,x2000,101010:01c5ca27c6,front-c,160,143,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 55
				},
				//Phone
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPhone Case & Cover",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,iphone_11_soft,back,a,x1000-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Case & Skin for Samsung Galaxy",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,samsung_galaxy_s10_snap,back,a,x1000-pad,1000x1000,f8f8f8.1u2.jpg",
					Price = 35
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPad Case & Skin",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063329780.4889/mwo,x1000,ipad_2_snap-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 45
				},
				//Home
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Wall Clock",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161997.4889/clkc,bamboo,white,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 25
				},
				//Mugs
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Travel Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161969.4889/mug,travel,x1000,center-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 11
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Classic Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063377597.4889/ur,mug_lifestyle,square,1000x1000.u2.jpg",
					Price = 22
				},
				//Clothing
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Code Maze Logo T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,vneck,x1900,101010:01c5ca27c6,front-c,160,70,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 20
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Pullover Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodie,mens,101010:01c5ca27c6,front,square_three_quarter,x1000-bg,f8f8f8.1u2.jpg",
					Price = 30
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Fitted Scoop T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodiez,mens,101010:01c5ca27c6,front,square_three_quarter,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 40
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Zipped Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,fitted_scoop,x2000,101010:01c5ca27c6,front-c,160,143,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 55
				},
				//Phone
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPhone Case & Cover",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,iphone_11_soft,back,a,x1000-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Case & Skin for Samsung Galaxy",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,samsung_galaxy_s10_snap,back,a,x1000-pad,1000x1000,f8f8f8.1u2.jpg",
					Price = 35
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPad Case & Skin",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063329780.4889/mwo,x1000,ipad_2_snap-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 45
				},
				//Home
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Wall Clock",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161997.4889/clkc,bamboo,white,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 25
				},
				//Mugs
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Travel Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161969.4889/mug,travel,x1000,center-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 11
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Classic Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063377597.4889/ur,mug_lifestyle,square,1000x1000.u2.jpg",
					Price = 22
				},
				//Clothing
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Code Maze Logo T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,vneck,x1900,101010:01c5ca27c6,front-c,160,70,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 20
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Pullover Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodie,mens,101010:01c5ca27c6,front,square_three_quarter,x1000-bg,f8f8f8.1u2.jpg",
					Price = 30
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Fitted Scoop T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodiez,mens,101010:01c5ca27c6,front,square_three_quarter,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 40
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Zipped Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,fitted_scoop,x2000,101010:01c5ca27c6,front-c,160,143,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 55
				},
				//Phone
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPhone Case & Cover",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,iphone_11_soft,back,a,x1000-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Case & Skin for Samsung Galaxy",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,samsung_galaxy_s10_snap,back,a,x1000-pad,1000x1000,f8f8f8.1u2.jpg",
					Price = 35
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPad Case & Skin",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063329780.4889/mwo,x1000,ipad_2_snap-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 45
				},
				//Home
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Wall Clock",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161997.4889/clkc,bamboo,white,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 25
				},
				//Mugs
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Travel Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161969.4889/mug,travel,x1000,center-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 11
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Classic Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063377597.4889/ur,mug_lifestyle,square,1000x1000.u2.jpg",
					Price = 22
				},
				//Clothing
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Code Maze Logo T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,vneck,x1900,101010:01c5ca27c6,front-c,160,70,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 20
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Pullover Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodie,mens,101010:01c5ca27c6,front,square_three_quarter,x1000-bg,f8f8f8.1u2.jpg",
					Price = 30
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Fitted Scoop T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodiez,mens,101010:01c5ca27c6,front,square_three_quarter,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 40
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Zipped Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,fitted_scoop,x2000,101010:01c5ca27c6,front-c,160,143,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 55
				},
				//Phone
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPhone Case & Cover",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,iphone_11_soft,back,a,x1000-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Case & Skin for Samsung Galaxy",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,samsung_galaxy_s10_snap,back,a,x1000-pad,1000x1000,f8f8f8.1u2.jpg",
					Price = 35
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPad Case & Skin",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063329780.4889/mwo,x1000,ipad_2_snap-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 45
				},
				//Home
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Wall Clock",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161997.4889/clkc,bamboo,white,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 25
				},
				//Mugs
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Travel Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161969.4889/mug,travel,x1000,center-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 11
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Classic Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063377597.4889/ur,mug_lifestyle,square,1000x1000.u2.jpg",
					Price = 22
				},
				//Clothing
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Code Maze Logo T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,vneck,x1900,101010:01c5ca27c6,front-c,160,70,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 20
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Pullover Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodie,mens,101010:01c5ca27c6,front,square_three_quarter,x1000-bg,f8f8f8.1u2.jpg",
					Price = 30
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Fitted Scoop T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodiez,mens,101010:01c5ca27c6,front,square_three_quarter,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 40
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Zipped Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,fitted_scoop,x2000,101010:01c5ca27c6,front-c,160,143,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 55
				},
				//Phone
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPhone Case & Cover",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,iphone_11_soft,back,a,x1000-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Case & Skin for Samsung Galaxy",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,samsung_galaxy_s10_snap,back,a,x1000-pad,1000x1000,f8f8f8.1u2.jpg",
					Price = 35
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPad Case & Skin",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063329780.4889/mwo,x1000,ipad_2_snap-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 45
				},
				//Home
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Wall Clock",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161997.4889/clkc,bamboo,white,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 25
				},
				//Mugs
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Travel Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161969.4889/mug,travel,x1000,center-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 11
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Classic Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063377597.4889/ur,mug_lifestyle,square,1000x1000.u2.jpg",
					Price = 22
				},
				//Clothing
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Code Maze Logo T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,vneck,x1900,101010:01c5ca27c6,front-c,160,70,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 20
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Pullover Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodie,mens,101010:01c5ca27c6,front,square_three_quarter,x1000-bg,f8f8f8.1u2.jpg",
					Price = 30
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Fitted Scoop T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodiez,mens,101010:01c5ca27c6,front,square_three_quarter,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 40
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Zipped Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,fitted_scoop,x2000,101010:01c5ca27c6,front-c,160,143,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 55
				},
				//Phone
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPhone Case & Cover",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,iphone_11_soft,back,a,x1000-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Case & Skin for Samsung Galaxy",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,samsung_galaxy_s10_snap,back,a,x1000-pad,1000x1000,f8f8f8.1u2.jpg",
					Price = 35
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPad Case & Skin",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063329780.4889/mwo,x1000,ipad_2_snap-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 45
				},
				//Home
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Wall Clock",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161997.4889/clkc,bamboo,white,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 25
				},
				//Mugs
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Travel Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161969.4889/mug,travel,x1000,center-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 11
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Classic Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063377597.4889/ur,mug_lifestyle,square,1000x1000.u2.jpg",
					Price = 22
				},
				//Clothing
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Code Maze Logo T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,vneck,x1900,101010:01c5ca27c6,front-c,160,70,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 20
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Pullover Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodie,mens,101010:01c5ca27c6,front,square_three_quarter,x1000-bg,f8f8f8.1u2.jpg",
					Price = 30
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Fitted Scoop T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodiez,mens,101010:01c5ca27c6,front,square_three_quarter,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 40
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Zipped Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,fitted_scoop,x2000,101010:01c5ca27c6,front-c,160,143,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 55
				},
				//Phone
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPhone Case & Cover",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,iphone_11_soft,back,a,x1000-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Case & Skin for Samsung Galaxy",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,samsung_galaxy_s10_snap,back,a,x1000-pad,1000x1000,f8f8f8.1u2.jpg",
					Price = 35
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPad Case & Skin",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063329780.4889/mwo,x1000,ipad_2_snap-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 45
				},
				//Home
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Wall Clock",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161997.4889/clkc,bamboo,white,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 25
				},
				//Mugs
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Travel Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161969.4889/mug,travel,x1000,center-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 11
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Classic Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063377597.4889/ur,mug_lifestyle,square,1000x1000.u2.jpg",
					Price = 22
				},
				//Clothing
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Code Maze Logo T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,vneck,x1900,101010:01c5ca27c6,front-c,160,70,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 20
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Pullover Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodie,mens,101010:01c5ca27c6,front,square_three_quarter,x1000-bg,f8f8f8.1u2.jpg",
					Price = 30
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Fitted Scoop T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodiez,mens,101010:01c5ca27c6,front,square_three_quarter,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 40
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Zipped Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,fitted_scoop,x2000,101010:01c5ca27c6,front-c,160,143,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 55
				},
				//Phone
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPhone Case & Cover",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,iphone_11_soft,back,a,x1000-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Case & Skin for Samsung Galaxy",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,samsung_galaxy_s10_snap,back,a,x1000-pad,1000x1000,f8f8f8.1u2.jpg",
					Price = 35
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPad Case & Skin",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063329780.4889/mwo,x1000,ipad_2_snap-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 45
				},
				//Home
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Wall Clock",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161997.4889/clkc,bamboo,white,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 25
				},
				//Mugs
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Travel Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161969.4889/mug,travel,x1000,center-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 11
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Classic Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063377597.4889/ur,mug_lifestyle,square,1000x1000.u2.jpg",
					Price = 22
				},
				//Clothing
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Code Maze Logo T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,vneck,x1900,101010:01c5ca27c6,front-c,160,70,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 20
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Pullover Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodie,mens,101010:01c5ca27c6,front,square_three_quarter,x1000-bg,f8f8f8.1u2.jpg",
					Price = 30
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Fitted Scoop T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodiez,mens,101010:01c5ca27c6,front,square_three_quarter,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 40
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Zipped Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,fitted_scoop,x2000,101010:01c5ca27c6,front-c,160,143,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 55
				},
				//Phone
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPhone Case & Cover",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,iphone_11_soft,back,a,x1000-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Case & Skin for Samsung Galaxy",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,samsung_galaxy_s10_snap,back,a,x1000-pad,1000x1000,f8f8f8.1u2.jpg",
					Price = 35
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPad Case & Skin",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063329780.4889/mwo,x1000,ipad_2_snap-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 45
				},
				//Home
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Wall Clock",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161997.4889/clkc,bamboo,white,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 25
				},
				//Mugs
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Travel Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161969.4889/mug,travel,x1000,center-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 11
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Classic Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063377597.4889/ur,mug_lifestyle,square,1000x1000.u2.jpg",
					Price = 22
				},
				//Clothing
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Code Maze Logo T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,vneck,x1900,101010:01c5ca27c6,front-c,160,70,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 20
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Pullover Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodie,mens,101010:01c5ca27c6,front,square_three_quarter,x1000-bg,f8f8f8.1u2.jpg",
					Price = 30
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Fitted Scoop T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodiez,mens,101010:01c5ca27c6,front,square_three_quarter,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 40
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Zipped Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,fitted_scoop,x2000,101010:01c5ca27c6,front-c,160,143,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 55
				},
				//Phone
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPhone Case & Cover",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,iphone_11_soft,back,a,x1000-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Case & Skin for Samsung Galaxy",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,samsung_galaxy_s10_snap,back,a,x1000-pad,1000x1000,f8f8f8.1u2.jpg",
					Price = 35
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPad Case & Skin",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063329780.4889/mwo,x1000,ipad_2_snap-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 45
				},
				//Home
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Wall Clock",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161997.4889/clkc,bamboo,white,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 25
				},
				//Mugs
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Travel Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161969.4889/mug,travel,x1000,center-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 11
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Classic Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063377597.4889/ur,mug_lifestyle,square,1000x1000.u2.jpg",
					Price = 22
				},
				//Clothing
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Code Maze Logo T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,vneck,x1900,101010:01c5ca27c6,front-c,160,70,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 20
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Pullover Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodie,mens,101010:01c5ca27c6,front,square_three_quarter,x1000-bg,f8f8f8.1u2.jpg",
					Price = 30
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Fitted Scoop T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodiez,mens,101010:01c5ca27c6,front,square_three_quarter,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 40
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Zipped Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,fitted_scoop,x2000,101010:01c5ca27c6,front-c,160,143,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 55
				},
				//Phone
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPhone Case & Cover",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,iphone_11_soft,back,a,x1000-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Case & Skin for Samsung Galaxy",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,samsung_galaxy_s10_snap,back,a,x1000-pad,1000x1000,f8f8f8.1u2.jpg",
					Price = 35
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPad Case & Skin",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063329780.4889/mwo,x1000,ipad_2_snap-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 45
				},
				//Home
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Wall Clock",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161997.4889/clkc,bamboo,white,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 25
				},
				//Mugs
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Travel Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161969.4889/mug,travel,x1000,center-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 11
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Classic Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063377597.4889/ur,mug_lifestyle,square,1000x1000.u2.jpg",
					Price = 22
				},
				//Clothing
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Code Maze Logo T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,vneck,x1900,101010:01c5ca27c6,front-c,160,70,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 20
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Pullover Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodie,mens,101010:01c5ca27c6,front,square_three_quarter,x1000-bg,f8f8f8.1u2.jpg",
					Price = 30
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Fitted Scoop T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodiez,mens,101010:01c5ca27c6,front,square_three_quarter,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 40
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Zipped Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,fitted_scoop,x2000,101010:01c5ca27c6,front-c,160,143,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 55
				},
				//Phone
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPhone Case & Cover",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,iphone_11_soft,back,a,x1000-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Case & Skin for Samsung Galaxy",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,samsung_galaxy_s10_snap,back,a,x1000-pad,1000x1000,f8f8f8.1u2.jpg",
					Price = 35
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPad Case & Skin",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063329780.4889/mwo,x1000,ipad_2_snap-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 45
				},
				//Home
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Wall Clock",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161997.4889/clkc,bamboo,white,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 25
				},
				//Mugs
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Travel Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161969.4889/mug,travel,x1000,center-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 11
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Classic Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063377597.4889/ur,mug_lifestyle,square,1000x1000.u2.jpg",
					Price = 22
				},
				//Clothing
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Code Maze Logo T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,vneck,x1900,101010:01c5ca27c6,front-c,160,70,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 20
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Pullover Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodie,mens,101010:01c5ca27c6,front,square_three_quarter,x1000-bg,f8f8f8.1u2.jpg",
					Price = 30
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Fitted Scoop T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodiez,mens,101010:01c5ca27c6,front,square_three_quarter,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 40
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Zipped Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,fitted_scoop,x2000,101010:01c5ca27c6,front-c,160,143,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 55
				},
				//Phone
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPhone Case & Cover",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,iphone_11_soft,back,a,x1000-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Case & Skin for Samsung Galaxy",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,samsung_galaxy_s10_snap,back,a,x1000-pad,1000x1000,f8f8f8.1u2.jpg",
					Price = 35
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPad Case & Skin",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063329780.4889/mwo,x1000,ipad_2_snap-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 45
				},
				//Home
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Wall Clock",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161997.4889/clkc,bamboo,white,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 25
				},
				//Mugs
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Travel Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161969.4889/mug,travel,x1000,center-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 11
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Classic Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063377597.4889/ur,mug_lifestyle,square,1000x1000.u2.jpg",
					Price = 22
				},
				//Clothing
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Code Maze Logo T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,vneck,x1900,101010:01c5ca27c6,front-c,160,70,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 20
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Pullover Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodie,mens,101010:01c5ca27c6,front,square_three_quarter,x1000-bg,f8f8f8.1u2.jpg",
					Price = 30
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Fitted Scoop T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodiez,mens,101010:01c5ca27c6,front,square_three_quarter,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 40
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Zipped Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,fitted_scoop,x2000,101010:01c5ca27c6,front-c,160,143,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 55
				},
				//Phone
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPhone Case & Cover",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,iphone_11_soft,back,a,x1000-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Case & Skin for Samsung Galaxy",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,samsung_galaxy_s10_snap,back,a,x1000-pad,1000x1000,f8f8f8.1u2.jpg",
					Price = 35
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPad Case & Skin",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063329780.4889/mwo,x1000,ipad_2_snap-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 45
				},
				//Home
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Wall Clock",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161997.4889/clkc,bamboo,white,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 25
				},
				//Mugs
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Travel Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161969.4889/mug,travel,x1000,center-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 11
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Classic Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063377597.4889/ur,mug_lifestyle,square,1000x1000.u2.jpg",
					Price = 22
				},
				//Clothing
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Code Maze Logo T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,vneck,x1900,101010:01c5ca27c6,front-c,160,70,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 20
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Pullover Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodie,mens,101010:01c5ca27c6,front,square_three_quarter,x1000-bg,f8f8f8.1u2.jpg",
					Price = 30
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Fitted Scoop T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodiez,mens,101010:01c5ca27c6,front,square_three_quarter,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 40
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Zipped Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,fitted_scoop,x2000,101010:01c5ca27c6,front-c,160,143,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 55
				},
				//Phone
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPhone Case & Cover",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,iphone_11_soft,back,a,x1000-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Case & Skin for Samsung Galaxy",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,samsung_galaxy_s10_snap,back,a,x1000-pad,1000x1000,f8f8f8.1u2.jpg",
					Price = 35
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPad Case & Skin",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063329780.4889/mwo,x1000,ipad_2_snap-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 45
				},
				//Home
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Wall Clock",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161997.4889/clkc,bamboo,white,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 25
				},
				//Mugs
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Travel Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161969.4889/mug,travel,x1000,center-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 11
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Classic Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063377597.4889/ur,mug_lifestyle,square,1000x1000.u2.jpg",
					Price = 22
				},
				//Clothing
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Code Maze Logo T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,vneck,x1900,101010:01c5ca27c6,front-c,160,70,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 20
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Pullover Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodie,mens,101010:01c5ca27c6,front,square_three_quarter,x1000-bg,f8f8f8.1u2.jpg",
					Price = 30
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Fitted Scoop T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodiez,mens,101010:01c5ca27c6,front,square_three_quarter,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 40
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Zipped Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,fitted_scoop,x2000,101010:01c5ca27c6,front-c,160,143,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 55
				},
				//Phone
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPhone Case & Cover",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,iphone_11_soft,back,a,x1000-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Case & Skin for Samsung Galaxy",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,samsung_galaxy_s10_snap,back,a,x1000-pad,1000x1000,f8f8f8.1u2.jpg",
					Price = 35
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPad Case & Skin",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063329780.4889/mwo,x1000,ipad_2_snap-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 45
				},
				//Home
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Wall Clock",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161997.4889/clkc,bamboo,white,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 25
				},
				//Mugs
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Travel Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161969.4889/mug,travel,x1000,center-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 11
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Classic Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063377597.4889/ur,mug_lifestyle,square,1000x1000.u2.jpg",
					Price = 22
				},
				//Clothing
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Code Maze Logo T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,vneck,x1900,101010:01c5ca27c6,front-c,160,70,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 20
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Pullover Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodie,mens,101010:01c5ca27c6,front,square_three_quarter,x1000-bg,f8f8f8.1u2.jpg",
					Price = 30
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Fitted Scoop T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodiez,mens,101010:01c5ca27c6,front,square_three_quarter,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 40
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Zipped Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,fitted_scoop,x2000,101010:01c5ca27c6,front-c,160,143,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 55
				},
				//Phone
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPhone Case & Cover",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,iphone_11_soft,back,a,x1000-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Case & Skin for Samsung Galaxy",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,samsung_galaxy_s10_snap,back,a,x1000-pad,1000x1000,f8f8f8.1u2.jpg",
					Price = 35
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPad Case & Skin",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063329780.4889/mwo,x1000,ipad_2_snap-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 45
				},
				//Home
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Wall Clock",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161997.4889/clkc,bamboo,white,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 25
				},
				//Mugs
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Travel Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161969.4889/mug,travel,x1000,center-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 11
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Classic Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063377597.4889/ur,mug_lifestyle,square,1000x1000.u2.jpg",
					Price = 22
				},
				//Clothing
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Code Maze Logo T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,vneck,x1900,101010:01c5ca27c6,front-c,160,70,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 20
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Pullover Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodie,mens,101010:01c5ca27c6,front,square_three_quarter,x1000-bg,f8f8f8.1u2.jpg",
					Price = 30
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Fitted Scoop T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodiez,mens,101010:01c5ca27c6,front,square_three_quarter,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 40
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Zipped Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,fitted_scoop,x2000,101010:01c5ca27c6,front-c,160,143,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 55
				},
				//Phone
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPhone Case & Cover",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,iphone_11_soft,back,a,x1000-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Case & Skin for Samsung Galaxy",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,samsung_galaxy_s10_snap,back,a,x1000-pad,1000x1000,f8f8f8.1u2.jpg",
					Price = 35
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPad Case & Skin",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063329780.4889/mwo,x1000,ipad_2_snap-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 45
				},
				//Home
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Wall Clock",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161997.4889/clkc,bamboo,white,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 25
				},
				//Mugs
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Travel Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161969.4889/mug,travel,x1000,center-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 11
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Classic Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063377597.4889/ur,mug_lifestyle,square,1000x1000.u2.jpg",
					Price = 22
				},
				//Clothing
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Code Maze Logo T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,vneck,x1900,101010:01c5ca27c6,front-c,160,70,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 20
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Pullover Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodie,mens,101010:01c5ca27c6,front,square_three_quarter,x1000-bg,f8f8f8.1u2.jpg",
					Price = 30
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Fitted Scoop T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodiez,mens,101010:01c5ca27c6,front,square_three_quarter,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 40
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Zipped Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,fitted_scoop,x2000,101010:01c5ca27c6,front-c,160,143,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 55
				},
				//Phone
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPhone Case & Cover",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,iphone_11_soft,back,a,x1000-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Case & Skin for Samsung Galaxy",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,samsung_galaxy_s10_snap,back,a,x1000-pad,1000x1000,f8f8f8.1u2.jpg",
					Price = 35
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPad Case & Skin",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063329780.4889/mwo,x1000,ipad_2_snap-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 45
				},
				//Home
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Wall Clock",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161997.4889/clkc,bamboo,white,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 25
				},
				//Mugs
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Travel Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161969.4889/mug,travel,x1000,center-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 11
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Classic Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063377597.4889/ur,mug_lifestyle,square,1000x1000.u2.jpg",
					Price = 22
				},
				//Clothing
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Code Maze Logo T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,vneck,x1900,101010:01c5ca27c6,front-c,160,70,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 20
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Pullover Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodie,mens,101010:01c5ca27c6,front,square_three_quarter,x1000-bg,f8f8f8.1u2.jpg",
					Price = 30
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Fitted Scoop T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodiez,mens,101010:01c5ca27c6,front,square_three_quarter,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 40
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Zipped Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,fitted_scoop,x2000,101010:01c5ca27c6,front-c,160,143,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 55
				},
				//Phone
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPhone Case & Cover",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,iphone_11_soft,back,a,x1000-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Case & Skin for Samsung Galaxy",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,samsung_galaxy_s10_snap,back,a,x1000-pad,1000x1000,f8f8f8.1u2.jpg",
					Price = 35
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPad Case & Skin",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063329780.4889/mwo,x1000,ipad_2_snap-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 45
				},
				//Home
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Wall Clock",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161997.4889/clkc,bamboo,white,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 25
				},
				//Mugs
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Travel Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161969.4889/mug,travel,x1000,center-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 11
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Classic Mug",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063377597.4889/ur,mug_lifestyle,square,1000x1000.u2.jpg",
					Price = 22
				},
				//Clothing
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Code Maze Logo T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,vneck,x1900,101010:01c5ca27c6,front-c,160,70,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 20
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Pullover Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodie,mens,101010:01c5ca27c6,front,square_three_quarter,x1000-bg,f8f8f8.1u2.jpg",
					Price = 30
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Fitted Scoop T-Shirt",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodiez,mens,101010:01c5ca27c6,front,square_three_quarter,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 40
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Zipped Hoodie",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,fitted_scoop,x2000,101010:01c5ca27c6,front-c,160,143,1000,1000-bg,f8f8f8.u2.jpg",
					Price = 55
				},
				//Phone
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPhone Case & Cover",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,iphone_11_soft,back,a,x1000-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Case & Skin for Samsung Galaxy",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,samsung_galaxy_s10_snap,back,a,x1000-pad,1000x1000,f8f8f8.1u2.jpg",
					Price = 35
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "iPad Case & Skin",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1063329780.4889/mwo,x1000,ipad_2_snap-pad,1000x1000,f8f8f8.u2.jpg",
					Price = 45
				},
				//Home
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Wall Clock",
					ItemNumber = ++count,
					Supplier = "Code Maze",
					ImageUrl = "https://ih1.redbubble.net/image.1062161997.4889/clkc,bamboo,white,1000x1000-bg,f8f8f8.u2.jpg",
					Price = 25
				}
			);
		}
	}
}
