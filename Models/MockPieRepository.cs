using System.Collections.Generic;

namespace pieshop.Models
{
    public class MockPieRepository : IPieRepository
    {
        public IEnumerable<Pie> AllPies => 
            new List<Pie>
            {
                new Pie {PieId=1, Name="Brain Pie", Price=15.95M, ShortDescription="Made with false morel (Gyromitra esculenta)"},
                new Pie {PieId=2, Name="Bleeding Tooth Pie", Price=16.00M, ShortDescription="Made with Hydnellum pecki"},
                new Pie {PieId=3, Name="Glow Pie", Price=12.50M, ShortDescription="Made with bioluminiscent mushrooms"},

                new Pie {PieId=4, Name="Pepino Pie", Price=16.75M, ShortDescription="Made with Pepino Fruit from South America"},
                new Pie {PieId=5, Name="Kumquat Pie", Price=14.25M, ShortDescription="Made with Kumquat Fruit from China"},
                new Pie {PieId=6, Name="Kiwano Pie", Price=15.75M, ShortDescription="Made with Kiwano Fruit from South Africa"},

                new Pie {PieId=7, Name="Navy Bean Pie", Price=13.99M, ShortDescription="With butter, chocolate, and vanilla"},
                new Pie {PieId=8, Name="Sweet Red Bean Pie", Price=14.50M, ShortDescription="Made with read beans"},
                new Pie {PieId=9, Name="Edamame Pie", Price=16.25M, ShortDescription="Made with edamame beans, mozarella, and zucchini"}
            };

        public IEnumerable<Pie> PiesOfTheWeek => throw new System.NotImplementedException();

        public Pie GetPieById(int pieId)
        {
            throw new System.NotImplementedException();
        }
    }
}