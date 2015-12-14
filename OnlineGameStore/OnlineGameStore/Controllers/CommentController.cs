using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OnlineGameStoreData;
using OnlineGameStoreData.Abstractions;
using OnlineGameStoreData.Entities;

namespace OnlineGameStore.Controllers
{
    public class CommentController : ApiController
    {
        private readonly ICommentEntityReader _commentEntityReader;
        private readonly ICommentEntityWriter _commentEntityWriter;
        private readonly IGameEntityReader _gameEntityReader;

        public CommentController(ICommentEntityReader commentEntityReader, ICommentEntityWriter commentEntityWriter, IGameEntityReader gameEntityReader)
        {
            _commentEntityReader = commentEntityReader;
            _commentEntityWriter = commentEntityWriter;
            _gameEntityReader = gameEntityReader;
        }

        [Route("game/{key}/comments")]
        [HttpGet]
        public IQueryable<CommentEntity> ReadCommentsByGameKey(string key)
        {
            var result = _commentEntityReader.ReadCommentsByGameKey(key);
            return result;
        }

        [Route("game/{key}/newcomment")]
        [HttpPost]
        public CommentEntity CreateComment(string key, CommentEntity commentEntity)
        {
            if (commentEntity == null)
            {
                commentEntity = new CommentEntity
                {
                    Game = _gameEntityReader.ReadByKey(key),
                    Name = "Commentator",
                    Body = "Test comment"
                };
            }
            var result = _commentEntityWriter.CreateComment(commentEntity);
            return result;
        }
    }
}
