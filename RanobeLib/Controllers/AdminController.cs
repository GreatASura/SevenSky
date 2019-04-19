using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RanobeLib.Models;
using RanobeLib.Data;
namespace RanobeLib.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BookManagment()
        {

            return View();
        }
        [HttpGet]
        public IActionResult AddBook()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult AddBook(string name,string author ,string discription)
        {
            Book newBook = new Book(name, author, discription);
            GlobalRules.uow.Books.Create(newBook);
            GlobalRules.uow.Save();
            return  Redirect("~/Home/Index");
        }
        [HttpGet]
        public IActionResult AddChapter()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddChapter(int bookid, string title, double chapterNumber,string text)
        {
            string datePublish = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            Chapter newChapter = new Chapter(bookid, title, chapterNumber, text, datePublish);
            GlobalRules.uow.Chapters.Create(newChapter);
            GlobalRules.uow.Save();
            return Redirect("~/Home/Index");
        }
        public void DeleteBook()
        {

        }
        
    }
}