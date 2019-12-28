namespace pieshop.Models
{
	public class PieRepository : IPieRepository
	{
		private readonly AppDbContext _appDbContext;

		public PieRepository(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}
	}
}
