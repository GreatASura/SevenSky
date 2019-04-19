using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RanobeLib.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;

namespace RanobeLib
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public BookContext()
            {

            }
        
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GlobalRules.ConectionSTR);
            }
        }
    }
}

