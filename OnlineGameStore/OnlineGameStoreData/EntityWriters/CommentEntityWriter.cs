using OnlineGameStoreData.Abstractions;
using OnlineGameStoreData.Entities;

namespace OnlineGameStoreData.EntityWriters
{
    public class CommentEntityWriter : ICommentEntityWriter
    {
        private readonly DatabaseContext _databaseContext;

        public CommentEntityWriter(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public CommentEntity CreateComment(CommentEntity comment)
        {
            var result = _databaseContext.Comments.Add(comment);

            _databaseContext.SaveChanges();
            return result;
        }
    }
}