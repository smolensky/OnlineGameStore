using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using OnlineGameStoreData.Abstractions;
using OnlineGameStoreData.Entities;

namespace OnlineGameStoreData.EntityWriters
{
    public class GameEntityWriter : IGameEntityWriter
    {
        private readonly DatabaseContext _databaseContext;

        public GameEntityWriter(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public GameEntity CreateGame(GameEntity gameEntity)
        {
            var result = _databaseContext.Games.Add(gameEntity);

            _databaseContext.SaveChanges();
            return result;
        }

        public void DeleteGame(string key)
        {
            var gameToDelete = _databaseContext.Games.FirstOrDefault(x => x.Key == key);
            if (gameToDelete != null)
            {
                _databaseContext.Games.Remove(gameToDelete);
            }

            _databaseContext.SaveChanges();
        }
    }
}
