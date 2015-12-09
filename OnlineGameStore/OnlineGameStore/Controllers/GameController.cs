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

        [Route("games/{id}")]
        [HttpGet]
        public GameEntity ReadGameByKey(string key = "1")
        {
            var result = _gameEntityReader.ReadByKey(key);
            return result;
        }
    }
}
