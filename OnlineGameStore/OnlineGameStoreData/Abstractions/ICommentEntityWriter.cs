using OnlineGameStoreData.Entities;

namespace OnlineGameStoreData.Abstractions
{
    public interface ICommentEntityWriter
    {
        CommentEntity CreateComment(CommentEntity comment, GameEntity game);
    }
}