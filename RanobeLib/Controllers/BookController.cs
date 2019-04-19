using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RanobeLib.Data;
using RanobeLib.Models;
namespace RanobeLib.Controllers
{
    public class BookController : Controller
    {
      
       
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DataTest()
        {
            ViewBag.Books = (new UnitOfWork()).Books.GetItemList();
            return View("data");
        }
        public string Data2()
        {
            var books = GlobalRules.uow.Chapters.GetItemList();
            return $"{books.First().Text}";
        }
        public IActionResult Info(int Id )
        {
            ViewBag.Book = GlobalRules.uow.Books.GetItem(Id);
            return View();
        }
        public IActionResult Chapter(int BookId, int ChapterId)
        {
           var Chapters   = GlobalRules.uow.Books.GetItem(BookId).Chapters;
            foreach (var item in Chapters)
            {
                if(item.ChapterNumber==ChapterId)
                {
                    ViewBag.Chapter = item;
                    break;
                }
                else
                {
                    ViewBag.Chapter = new Chapter(-1, BookId, "No Such Chapter", ChapterId, "...", "");
                    
                }
            }
               
            return View();
        }
    }
}