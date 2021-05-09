using System.Collections.Generic;

namespace Whales.Models
{
    public interface IWhalesRepository
    {
        IEnumerable<Whale> AllWhales { get; }
        Whale GetWhaleById(int whaleId);
        void AddWhale(Whale whale);
        void EditWhale(Whale whale);
        void DeleteWhale(Whale whaleId);
    }
}
