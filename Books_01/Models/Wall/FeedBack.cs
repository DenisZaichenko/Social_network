using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Books_01.Models.Authorization;

namespace Books_01.Models.Wall
{
    public class FeedBack : IWallPost
    {
        public PostType type { get; private set; }
        public int id { get; private set; }
        private List<ApplicationUser> likes;
        string text;
        int bookId;
        int rating;
        public FeedBack(int id, int bookId, int rating, string text)
        {
            likes = new List<ApplicationUser>();
            this.id = id;
            this.bookId = bookId;
            this.rating = rating;
        }

        public void Like(ApplicationUser user)
        {
            likes.Add(user);
        }
        public void DisLike(ApplicationUser user)
        {
            likes.RemoveAll(m => m == user);
        }
        public IEnumerable<ApplicationUser> getLikes()
        {
            return likes.Select(n => n);
        }
    }
}