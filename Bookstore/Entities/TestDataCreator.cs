using Bookstore.Entities.Models;
using Bookstore.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Entities
{
    public static class TestDataCreator
    {
        public static void CreateData(BookStoreContext context)
        {
            context.Users.Add(new User { UserName = "user1", Password = "user1" });
            context.Users.Add(new Admin { UserName = "admin1", Password = "admin1" });

            context.Authors.AddRange(
                new Author { Name = "Стивен Кинг" },
                new Author { Name = "Джоан Роулинг" },
                new Author { Name = "Карлос Кастанеда" },
                new Author { Name = "Федор Достоевский" },
                new Author { Name = "Дарья Донцова" },
                new Author { Name = "Ричард Бах" },
                new Author { Name = "Агата Кристи" }
                );

            context.Publishers.AddRange(
                new Publisher { Name = "Клуб Семейного Досуга" },
                new Publisher { Name = "А-ба-ба-га-ла-ма-га" },
                new Publisher { Name = "Snowdrop" },
                new Publisher { Name = "София" },
                new Publisher { Name = "Азбука" },
                new Publisher { Name = "Синдбад" },
                new Publisher { Name = "Виват" }
                );

            context.Genres.AddRange(
                 new Genre { Title = "Фэнтези" },
                 new Genre { Title = "Мистический триллер" },
                 new Genre { Title = "Детектив" },
                 new Genre { Title = "Эзотерика и оккультизм" },
                 new Genre { Title = "Классическая проза" },
                 new Genre { Title = "Иронический детектив" }
                );

            context.Promotions.AddRange(
                new Promotion { Title = "Скидка 10 %", DiscountPercentage = 10 },
                new Promotion { Title = $"Скидка 20 %", DiscountPercentage = 20 }
                );
            context.SaveChanges();

            context.Books.AddRange(
                CreateBook(context, "Сияние", "Стивен Кинг", "Клуб Семейного Досуга",
                "Мистический триллер", 2020, 512, 320, 670, null, 200),
                CreateBook(context, "Мертвая зона", "Стивен Кинг", "Клуб Семейного Досуга",
                "Мистический триллер", 2021, 544, 150, 330, null, 200),
                 CreateBook(context, "Гарри Поттер 1", "Джоан Роулинг", "А-ба-ба-га-ла-ма-га",
                "Фэнтези", 2017, 485, 250, 500, null, 100)
                );
            context.SaveChanges();

            context.PromotionPeriods.AddRange(
                new PromotionPeriod
                {
                    Promotion = context.Promotions.FirstOrDefault(p => p.DiscountPercentage == 10),
                    Begin = DateTime.Now,
                    End = DateTime.Now + TimeSpan.FromDays(10),
                    Books = context.Books.Where(b => b.Authors.Contains(
                        AuthorsRequests.GetAuthorByName(context, "Стивен Кинг").FirstOrDefault())).ToList()
                }
                ) ;
            context.SaveChanges();

            context.Books.Add(CreateBook(context,
                "Гарри Поттер 2", "Джоан Роулинг", "А-ба-ба-га-ла-ма-га", "Фэнтези",
                2018, 535, 250, 500, context.Books.FirstOrDefault(b => b.Title == "Гарри Поттер 1"), 100)
               );
            context.SaveChanges();
        }

        private static Book CreateBook(BookStoreContext context, 
            string title, string authors, string publisher,string genre, 
            int released, int pages, int costPrice, int price, Book previous, int count)
        {
            Book book = new()
            {
                Title = title,
                Released = released,
                Pages = pages,
                CostPrice = costPrice,
                Price = price,
                Previous = previous,
                AvailableCount = count,
                Publisher = context.Publishers.FirstOrDefault(e => e.Name == publisher),
                Genre = context.Genres.FirstOrDefault(e => e.Title == genre)
            };
            AddAuthorsToBook(context, book, authors);

            return book;
        }

        private static void AddAuthorsToBook(BookStoreContext context, Book book, string authors)
        {
            var names = authors.Split(',');
            foreach (var name in names)
            {
                var author = AuthorsRequests.GetAuthorByName(context, name).FirstOrDefault();
                if (author is not null)
                    book.Authors.Add(author);
            }
        }
    }
}
