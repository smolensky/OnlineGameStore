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

        public GameEntity ReadByKey(string key)
        {
            var result = _databaseContext.Games.FirstOrDefault(x => x.Key == key);

            return result;
        }

        public IQueryable<GameEntity> ReadByGenre(GameGenreEntity gameGenre)
        {
            var result = _databaseContext.Games.Where(x => x.Name == gameGenre.GameName);

            return result;
        }

        public IQueryable<GameEntity> ReadByPlatformType(GamePlatformTypeEntity gamePlatformType)
        {
            var result = _databaseContext.Games.Where(x => x.Name == gamePlatformType.GameName);

            return result;
        }
    }
}
