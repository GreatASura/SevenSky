using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace RanobeLib.Models
{
    public class Book 
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        
        public string Discription { get; set; }
        [NotMapped]
        public  List<Chapter> Chapters { get; set; }
        public Book()
        {
            Chapters = new List<Chapter>();
        }
        public Book(string name,string author, string discription)
        {
            Chapters = new List<Chapter>();
            this.Name = name;
            this.Author = author;
            this.Discription = discription;

        }
    }
}
