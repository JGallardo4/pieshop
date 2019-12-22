using System.Collections.Generic;

namespace pieshop.Models
{
	public interface ICategoryRepository
	{
		public IEnumerable<Category> GetAllCategories();
	}
}