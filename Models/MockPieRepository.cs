using System.Collections.Generic;
using System.Linq;

namespace pieshop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Pie> AllPies => new List<Pie>
				{
          new Pie{PieId=1, Name="Brain Pie", Price=15.95M,
            ShortDescription="Made with false morel (Gyromitra esculenta)",
            Category=_categoryRepository.AllCategories.ToList()[0],
						ImageUrl="/images/brain.jpg"},						
          new Pie{PieId=2, Name="Bleeding Tooth Pie", Price=16.00M,
            ShortDescription="Made with Hydnellum pecki",
            Category=_categoryRepository.AllCategories.ToList()[0],
						ImageUrl="/images/bleeding-tooth.jpg"},
          new Pie{PieId=3, Name="Glow Pie", Price=12.50M,
            ShortDescription="Made with bioluminiscent mushrooms",
            Category=_categoryRepository.AllCategories.ToList()[0],
						ImageUrl="/images/glow.jpg"},
          new Pie{PieId=4, Name="Pepino Pie", Price=16.75M,
            ShortDescription="Made with Pepino Fruit from South America",
            Category=_categoryRepository.AllCategories.ToList()[1],
						ImageUrl="/images/pepino.jpg"},                  
          new Pie{PieId=5, Name="Kumquat Pie", Price=14.25M,
            ShortDescription="Made with Kumquat Fruit from China",
            Category=_categoryRepository.AllCategories.ToList()[1],
						ImageUrl="/images/kumquat.jpg"},
          new Pie{PieId=6, Name="Kiwano Pie", Price=15.75M,
            ShortDescription="Made with Kiwano Fruit from South Africa",
            Category=_categoryRepository.AllCategories.ToList()[1],
						ImageUrl="/images/kiwano.jpg"},
          new Pie{PieId=7, Name="Navy Bean Pie", Price=13.99M,
            ShortDescription="With butter, chocolate, and vanilla",
            Category=_categoryRepository.AllCategories.ToList()[2],
						ImageUrl="/images/bean.jpg"},
          new Pie{PieId=8, Name="Sweet Red Bean Pie", Price=14.50M,
            ShortDescription="Made with read beans",
            Category=_categoryRepository.AllCategories.ToList()[2],
						ImageUrl="/images/red-bean.jpg"},
          new Pie{PieId=9, Name="Edamame Pie", Price=16.25M,
            ShortDescription="Made with edamame beans, mozarella, and zucchini",
            Category=_categoryRepository.AllCategories.ToList()[2],
						ImageUrl="/images/edamame.jpg"}
        };

        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
