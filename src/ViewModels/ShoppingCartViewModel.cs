using System;
using pieshop.Models;

namespace pieshop.Models
{
	public class ShoppingCartViewModel
	{
		public decimal shoppingCartTotal { get; set; }

		public ShoppingCart ShoppingCart { get; set; }
	}
}