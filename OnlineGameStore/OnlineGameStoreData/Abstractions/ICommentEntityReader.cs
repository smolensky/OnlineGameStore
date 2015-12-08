using System.Linq;
using OnlineGameStoreData.Entities;

namespace OnlineGameStoreData.Abstractions
{
    public interface ICommentEntityReader
    {
        IQueryable<GameEntity> ReadAll(GameEntity game);
    }
}