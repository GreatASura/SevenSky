using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RanobeLib.Models
{
    public class Chapter
    {
        public int Id { get; set; }
       
        public int BookId { get; set; }
        [ForeignKey("Book")]
        public string Title { get; set; }
        public double ChapterNumber { get; set; }
        public string Text { get; set; }
        public string DatePublish { get; set; }
        public Chapter ()
        {

        }
        public Chapter(int bookid, string title, double chapterNumber, string text,string date)
        {
            this.BookId = bookid;
            this.Title = title;
            this.ChapterNumber = chapterNumber;
            this.Text = text;
            this.DatePublish = date;
        }
        public Chapter(int id,int bookid, string title, double chapterNumber, string text, string date)
        {
            this.BookId = bookid;
            this.Title = title;
            this.ChapterNumber = chapterNumber;
            this.Text = text;
            this.DatePublish = date;
            this.Id = id;
        }
    }
}
