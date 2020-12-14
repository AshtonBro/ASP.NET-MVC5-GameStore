

namespace GameStore.Domain.Entities
{
    /// <summary>
    /// Класс Game включает в себя параметры игры, описание, тип и тд.
    /// </summary>
    public class Game
    {
        public int GameId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Categoty { get; set; }
        public decimal Price { get; set; }
    }
}
