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
        public Guid id { get { return id; } private set { id= value; } }
        public List<ApplicationUser> likes { get { return (List<ApplicationUser>)likes.Select(n => n); } }
        DateTime date;
        Guid sourceID;
        public Repost(Guid sourcePostId)
        {
            sourceID = sourcePostId;
            date = DateTime.Now;
            type = PostType.Repost;
            id = new Guid();
        }
        public void Like(ApplicationUser user)
        {
            likes.Add(user);
        }
        public void DisLike(ApplicationUser user)
        {
            likes.RemoveAll(m => m==user);
        }
    }
}