using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RanobeLib.Models;

namespace RanobeLib.Data
{
    public class SQLBookRepository : IRepository<Book>
    {
        private BookContext data;
        public SQLBookRepository(BookContext context)
        {
            this.data = context;
            foreach (var book in data.Books)
            {
                foreach (var item in data.Chapters)
                {
                    if (item.BookId == book.Id)
                        book.Chapters.Add(item);
                }
                book.Chapters = book.Chapters.OrderBy(x => x.ChapterNumber).ToList();
            }
            
        }
        public void Create(Book item)
        {
            this.data.Books.Add(item);
        }

        public void Delete(int Id)
        {
            Book toDeleteBook = data.Books.Find(Id);
            if(toDeleteBook!=null)
            {
                data.Books.Remove(toDeleteBook);
            }
        }
        public Book GetItem(int Id)
        {
            Book toReturnBook = data.Books.Find(Id);
            if (toReturnBook == null)
                throw new Exception("No such book Error on Irep Book");
            return toReturnBook;
        }

        public IEnumerable<Book> GetItemList()
        {
            return data.Books;
        }

        public void Save()
        {
            data.SaveChanges();
        }

        public void Update(Book item)
        {
            data.Entry(item).State = EntityState.Modified;
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~SQLBookRepository()
        // {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
