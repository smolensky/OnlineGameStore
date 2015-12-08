using System.Linq;
using OnlineGameStoreData.Entities;

namespace OnlineGameStoreData.Abstractions
{
    public interface ICommentEntityReader
    {
        IQueryable<CommentEntity> ReadAll(GameEntity game);
    }
}