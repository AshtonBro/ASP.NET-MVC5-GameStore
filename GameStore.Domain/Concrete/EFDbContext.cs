using GameStore.Domain.Entities;
using System.Data.Entity;

namespace GameStore.Domain.Concrete
{
    /// <summary>
    /// Класс контекста, который будет ассоциировать модель с базой данных.
    /// </summary>
    public class EFDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }

    }
}
