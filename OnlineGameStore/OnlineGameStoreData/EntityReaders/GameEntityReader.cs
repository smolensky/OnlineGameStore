using System.Linq;
using OnlineGameStoreData.Abstractions;
using OnlineGameStoreData.Entities;

namespace OnlineGameStoreData.EntityReaders
{
    public class GameEntityReader : IGameEntityReader
    {
        private readonly DatabaseContext _databaseContext;

        public GameEntityReader(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public IQueryable<GameEntity> ReadAll()
        {
            var result = _databaseContext.Games;

            return result;
        }
    }
}
