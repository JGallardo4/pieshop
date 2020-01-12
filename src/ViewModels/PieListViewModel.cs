using System.Collections.Generic;
using pieshop.Models;

namespace pieshop.Models
{
	public class PieListViewModel
	{
		public IEnumerable<Pie> Pies { get; set; }
		public string CurrentCategory { get; set; }		
	}
}