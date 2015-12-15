using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineGameStoreData.Entities;

namespace OnlineGameStoreData.Abstractions
{
    public interface IGameEntityWriter
    {
        GameEntity CreateGame(GameEntity gameEntity);
        void DeleteGame(string key);
    }
}
