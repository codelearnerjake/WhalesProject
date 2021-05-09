using System.Collections.Generic;
using System.Linq;

namespace Whales.Models
{
    public class WhaleRepository : IWhalesRepository
    {
        private readonly AppDbContext _appDbContext;

        public WhaleRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Whale> AllWhales {
            get
            {
                return _appDbContext.Whales;
            }
        }

        public Whale GetWhaleById(int whaleId)
        {
            return _appDbContext.Whales.FirstOrDefault(whale => whale.Id == whaleId);
        }

        public void AddWhale(Whale whale)
        {
            _appDbContext.Whales.Add(whale);
            _appDbContext.SaveChanges();
        }

        public void EditWhale(Whale whale)
        {
            _appDbContext.Whales.Update(whale);
            _appDbContext.SaveChanges();
        }

        public void DeleteWhale(Whale whale)
        {
            _appDbContext.Whales.Attach(whale);
            _appDbContext.Whales.Remove(whale);
            _appDbContext.SaveChanges();
        }
    }
}
