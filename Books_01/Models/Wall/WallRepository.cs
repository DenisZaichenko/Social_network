using System;
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
            posts.Add(new FeedBack(2,2,3,"GAVNO"));
            posts.Add(new FeedBack(3,2,1,"Хуйня"));
            posts.Add(new FeedBack(4,2,5,"ZAEBIS"));
            #endregion FakePosts
        }
        public void DeletePost(int id)
        {
            posts.RemoveAll(m => m.id == id);
        }
        public void MakeRepost(int id,int sourcePostId)
        {
            Repost rep = new Repost(1,sourcePostId);
            posts.Add(rep);
        }
        public void AddFeedBack(int id, int bookId, string text, int rating)
        {
            posts.Add(new FeedBack(id,bookId, rating, text));
        }
        public IEnumerable<IWallPost> getAllPosts()
        {
            return posts.Select(n => n);
        }
    }
}