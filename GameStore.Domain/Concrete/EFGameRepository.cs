using System.Collections.Generic;
using GameStore.Domain.Entities;
using GameStore.Domain.Abstract;

namespace GameStore.Domain.Concrete
{
    /// <summary>
    /// Класс EFGameRepository представляет необходимое хранилище. Он реализует интерфейс IGameRepository и использует экземпляр EFDbContext для извлечения данных из базы посредством Entity Framework.
    /// </summary>
    public class EFGameRepository : IGameRepository
    {
        EFDbContext context = new EFDbContext();
        public IEnumerable<Game> Games
        {
            get 
            {
                return context.Games;
            }
        }
    }
}
