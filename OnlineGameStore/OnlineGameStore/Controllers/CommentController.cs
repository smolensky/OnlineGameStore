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

        public CommentController(ICommentEntityReader commentEntityReader, ICommentEntityWriter commentEntityWriter)
        {
            _commentEntityReader = commentEntityReader;
            _commentEntityWriter = commentEntityWriter;
        }

        [Route("game/{key}/comments")]
        [HttpGet]
        public IQueryable<CommentEntity> ReadCommentsByGameKey(string key)
        {
            var result = _commentEntityReader.ReadCommentsByGameKey(key);
            return result;
        }
    }
}
