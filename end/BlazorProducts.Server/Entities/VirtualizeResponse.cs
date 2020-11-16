using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
	public class VirtualizeResponse<T>
	{
		public List<T> Items { get; set; }
		public int TotalSize { get; set; }
	}
}
