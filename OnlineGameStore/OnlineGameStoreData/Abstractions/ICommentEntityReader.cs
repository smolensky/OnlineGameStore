using System.Linq;
using OnlineGameStoreData.Entities;

namespace OnlineGameStoreData.Abstractions
{
    public interface ICommentEntityReader
    {
        IQueryable<CommentEntity> ReadCommentsByGameKey(string game);
    }
}