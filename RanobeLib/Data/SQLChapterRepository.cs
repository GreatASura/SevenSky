using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RanobeLib.Models;

namespace RanobeLib.Data
{
    public class SQLChapterRepository:IRepository<Chapter>
    {
        private BookContext data;
        public SQLChapterRepository(BookContext context)
        {
            this.data = context;
        }
        public void Create(Chapter item)
        {
            this.data.Chapters.Add(item);
        }

        public void Delete(int Id)
        {
            Chapter toDeleteChapter = data.Chapters.Find(Id);
            if (toDeleteChapter != null)
            {
                data.Chapters.Remove(toDeleteChapter);
            }
        }
        public Chapter GetItem(int Id)
        {
            Chapter toReturnChapter = data.Chapters.Find(Id);
            if (toReturnChapter == null)
                throw new Exception("No such Chapter Error on Irep Chapter");
            return toReturnChapter;
        }

        public IEnumerable<Chapter> GetItemList()
        {
            return data.Chapters;
        }

        public void Save()
        {
            data.SaveChanges();
        }

        public void Update(Chapter item)
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
