using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineGameStoreData.Entities;

namespace OnlineGameStoreData.Abstractions
{
    public interface IGameEntityReader
    {
        IQueryable<GameEntity> ReadAll();
        GameEntity ReadByKey(string key);
        IQueryable<GameEntity> ReadByGenre(GameGenreEntity gameGenre);
        IQueryable<GameEntity> ReadByPlatformType(GamePlatformTypeEntity gamePlatformType);
    }
}
