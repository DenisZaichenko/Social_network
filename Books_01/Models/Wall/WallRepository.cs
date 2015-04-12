﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Books_01.Models.Wall
{
    public class WallRepository
    {
       private List<IWallPost> posts;
        public WallRepository()
        {
            posts = new List<IWallPost>();
            #region FakePosts
            posts.Add(new FeedBack(new Guid(),3,"GAVNO"));
            posts.Add(new FeedBack(new Guid(),1,"Хуйня"));
            posts.Add(new FeedBack(new Guid(),5,"ZAEBIS"));
            #endregion FakePosts
        }
        public void DeletePost(Guid id)
        {
            posts.RemoveAll(m => m.id == id);
        }
        public void MakeRepost(Guid sourcePostId)
        {
            Repost rep = new Repost(sourcePostId);
            posts.Add(rep);
        }
        public void AddFeedBack(Guid bookId, string text, int rating)
        {
            posts.Add(new FeedBack(bookId, rating, text));
        }
        public IEnumerable<IWallPost> getAllPosts()
        {
            return posts.Select(n => n);
        }
    }
}