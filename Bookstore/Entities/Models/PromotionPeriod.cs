using Bookstore.Entities.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Entities.Models
{
    /// <summary>
    /// Период данной акции
    /// </summary>
    public class PromotionPeriod : ModelBase
    {
        /// <summary>
        /// Данная акция
        /// </summary>
        public Promotion Promotion { get; set; }
        /// <summary>
        /// Начало периода акции
        /// </summary>
        public DateTime Begin { get; set; }
        /// <summary>
        /// Конец периода акции
        /// </summary>
        public DateTime End { get; set; }
        /// <summary>
        /// Список книг, на которые распространяется акция
        /// </summary>
        public List<Book> Books { get; set; } 
    }
}
