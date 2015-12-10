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

        public IQueryable<GameEntity> ReadByGenre(string gameGenre)
        {
            var result = _databaseContext.GameGenres.Where(x => x.GenreName == gameGenre);
            var result2 = _databaseContext.Games.Where(x => result.Any(y => y.GameName == x.Name));
            
            return result2;
        }

        public IQueryable<GameEntity> ReadByPlatformType(string gamePlatformType)
        {
            var result = _databaseContext.Games.Where(x => x.Name == gamePlatformType);

            return result;
        }
    }
}
