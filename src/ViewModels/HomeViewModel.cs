using System.Collections.Generic;

namespace pieshop.Models
{
	public class HomeViewModel
	{
		public IEnumerable<Pie> PiesOfTheWeek { get; set; }
	}
}