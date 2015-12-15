using System.Linq;
using OnlineGameStoreData.Abstractions;
using OnlineGameStoreData.Entities;

namespace OnlineGameStoreData.EntityReaders
{
    public class CommentEntityReader : ICommentEntityReader
    {
        private readonly DatabaseContext _databaseContext;

        public CommentEntityReader(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public IQueryable<CommentEntity> ReadCommentsByGameKey(string key)
        {
            var result = _databaseContext.Comments.Where(x => x.GameKey == key);
            return result;
        }
    }
}