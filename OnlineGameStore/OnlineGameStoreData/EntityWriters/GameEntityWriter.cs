using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
