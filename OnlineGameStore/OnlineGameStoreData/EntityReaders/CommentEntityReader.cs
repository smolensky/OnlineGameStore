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

        public IQueryable<CommentEntity> ReadAll(GameEntity game)
        {
            var result = _databaseContext.Comments.All(x => x.Game.Key == game.Key);
            return result;
        }
    }
}