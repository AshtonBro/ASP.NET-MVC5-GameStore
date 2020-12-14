using System.Collections.Generic;
using GameStore.Domain.Entities;

namespace GameStore.Domain.Abstract
{
    /// <summary>
    /// Этот интерфейс использует интерфейс IEnumerable<T>, чтобы позволить вызывающему коду получать последовательность объектов Game, ничего не сообщая о том, как или где хранятся или извлекаются данные. Класс, зависящий от интерфейса IGameRepository, может получать объекты Game, ничего не зная о том, откуда они поступают или каким образом класс реализации будет их доставлять. В этом и состоит суть шаблона хранилища. В процессе разработки приложения мы будем возвращаться к интерфейсу IGameRepository, добавляя в него необходимые средства.
    /// </summary>
    public interface IGameRepository
    {
        IEnumerable<Game> Games { get; }
    }
}
