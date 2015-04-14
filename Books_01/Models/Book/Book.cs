using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Books_01.Models.Wall;

namespace Books_01.Models.Book
{
    public class Book:Controller
    {
        public int id;
        public string title;
        public string author;// можно будет сделать его отдельным классом и смотреть все его книги
        public DateTime year;
        public string imagePath="Content/images/default.png";
        public List<FeedBack> feedBacks;
        public Book(string title,string author, DateTime year)
        {
            this.title = title;
            this.author = author;
            this.year = year;
            feedBacks = new List<FeedBack>();
        }

        public void Rate(FeedBack feed, bool needPostOnTheWall)
        {
            feedBacks.Add(feed);
            if(needPostOnTheWall)
            {
                //Здесь передаем на стену, 
            }
        }

    }
}