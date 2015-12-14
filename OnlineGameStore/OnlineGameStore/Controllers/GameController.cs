using System.Linq;
using System.Web.Http;
using OnlineGameStoreData;
using OnlineGameStoreData.Abstractions;
using OnlineGameStoreData.Entities;
using OnlineGameStoreData.EntityReaders;

namespace OnlineGameStore.Controllers
{
    public class GameController : ApiController
    {
        private readonly IGameEntityReader _gameEntityReader;
        private readonly IGameEntityWriter _gameEntityWriter;

        public GameController(IGameEntityReader gameEntityReader, 
                                            IGameEntityWriter gameEntityWriter)
        {
            _gameEntityReader = gameEntityReader;
            _gameEntityWriter = gameEntityWriter;
        }

        [Route("games")]
        [HttpGet]
        public IQueryable<GameEntity> ReadAllGames()
        {
            var result = _gameEntityReader.ReadAll();
            return result;
        }

        [Route("games/key")]
        [HttpGet]
        public GameEntity ReadGameByKey(string key = "1")
        {
            var result = _gameEntityReader.ReadByKey(key);
            return result;
        }

        [Route("games/genre/{genre}")]
        [HttpGet]
        public IQueryable<GameEntity> ReadGameByGenre(string genre)
        {
            var result = _gameEntityReader.ReadByGenre(genre);
            return result;
        }

        [Route("games/platform/{type}")]
        [HttpGet]
        public IQueryable<GameEntity> ReadGameByPlatformType(string type)
        {
            var result = _gameEntityReader.ReadByPlatformType(type);
            return result;
        }

        [Route("games/new")]
        [HttpPost]
        public GameEntity CreateNewGame(GameEntity gameEntity)
        {
            // WARNING: HARDCODE
            // It will work only once, Game.Key is key value and can't be repeated
            if (gameEntity == null)
            {
                gameEntity = new GameEntity
                {
                    // TODO: gameKey should be writed another way
                    Key = "5", 
                    Name = "GameForTest",
                    Description = "Was created to test writing to database"
                };
            }

            var game = _gameEntityWriter.CreateGame(gameEntity);
            return game;
        }
    }
}
