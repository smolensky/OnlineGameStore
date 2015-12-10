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
            var gameGenres = _databaseContext.GameGenres.Where(x => x.GenreName == gameGenre);
            var result = _databaseContext.Games.Where(x => gameGenres.Any(y => y.GameName == x.Name));
            
            return result;
        }

        public IQueryable<GameEntity> ReadByPlatformType(string gamePlatformType)
        {
            var gameType = _databaseContext.GamePlatformTypes.Where(x => x.TypeName == gamePlatformType);
            var result = _databaseContext.Games.Where(x => gameType.Any(y => y.GameName == x.Name));

            return result;
        }
    }
}
