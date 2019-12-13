using System.Collections.Generic;

namespace pieshop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Fungus Pies", Description="All fungus-based pies"},
                new Category{CategoryId=2, CategoryName="Fruit Pies", Description="All pies made from alien fruits"},
                new Category{CategoryId=3, CategoryName="Bean Pies", Description="Pies with bean fillings"}
            };
    }
}