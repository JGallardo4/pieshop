using System.Collections.Generic;

namespace pieshop.Models
{
    public class ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}