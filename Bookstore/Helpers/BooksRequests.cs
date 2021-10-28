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
    /// Статический класс реализует запросы книг
    /// </summary>
    public static class BooksRequests
    {
        public static IQueryable<Book> GetAllBooks(BookStoreContext context, object param)
        {
            return context.Books.Include(b => b.Authors).Where(b => b is Book);
        }

        public static IQueryable<Book> GetAvailableBooks(BookStoreContext context, object param) 
        {
            return context.Books.Include(b => b.Authors).Where(b => b.AvailableCount > 0);
        }

        public static IQueryable<Book> GetNewAvailableBooks(BookStoreContext context, object param) 
        {
            return context.Books.Include(b => b.Authors).Where(b => b.AvailableCount > 0 &&
            b.Released == DateTime.Now.Year);
        }

        public static IQueryable<Book> GetSortedBooksBySoldCountAcc(BookStoreContext context, object param) 
        {
            return context.Books.Include(b => b.Authors).OrderBy(b => b.SoldCount); 
        }

        public static IQueryable<Book> GetSortedBooksBySoldCountDecc(BookStoreContext context, object param) 
        {
            return context.Books.Include(b => b.Authors).OrderByDescending(b => b.SoldCount);
        }

        public static IQueryable<Book> GetBookByTitle(BookStoreContext context, object param)
        {
            var book = context.Books.Include(b => b.Authors).Include(b => b.Previous).
                Include(b => b.Genre).Include(b => b.Publisher).Where(
                b => b.Title == param.ToString());
            return book;
        }
    }
}
