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
        string title;
        string author;// можно будет сделать его отдельным классом и смотреть все его книги
        DateTime year;
        string imagePath;
        List<FeedBack> feedBacks;

        public Book()
        {
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