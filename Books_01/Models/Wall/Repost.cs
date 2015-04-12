using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Books_01.Models.Authorization;

namespace Books_01.Models.Wall
{
    public class Repost:IWallPost
    {
        public PostType type { get { return type; } private set { type = value; } }
        public int id { get { return id; } private set { id= value; } }
        private List<ApplicationUser> likes;
        DateTime date;
        int sourceID;
        public Repost(int id,int sourcePostId)
        {
            sourceID = sourcePostId;
            date = DateTime.Now;
            type = PostType.Repost;
            this.id = id;
        }
        public void Like(ApplicationUser user)
        {
            likes.Add(user);
        }
        public void DisLike(ApplicationUser user)
        {
            likes.RemoveAll(m => m==user);
        }
        public IEnumerable<ApplicationUser> getLikes()
        {
            return likes.Select(n => n);
        }
    }
}