using Bookstore.Entities;
using Bookstore.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Helpers
{
    /// <summary>
    /// Статический класс реализует запросы авторов
    /// </summary>
    public static class AuthorsRequests
    {
        public static IQueryable<Author> GetMorePopularFirstAuthors(BookStoreContext context, object param)
        {
            return context.Authors.Include(a => a.Books).
                   OrderByDescending(a => a.Books.Sum(b => b.SoldCount)); 
        }
        public static IQueryable<Author> GetLessPopularFirstAuthors(BookStoreContext context, object param)
        {
            return context.Authors.Include(a => a.Books).
                   OrderBy(a => a.Books.Sum(b => b.SoldCount));
        }

        public static IQueryable<Author> GetALLAuthors(BookStoreContext context, object param)
        {
            return context.Authors;
        }

        public static IQueryable<Author> GetAuthorByName(BookStoreContext context, object param)
        {
            return context.Authors.Where(a => a.Name == param.ToString());
        }
    }
}
