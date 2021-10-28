
using Bookstore.Entities.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Entities.Models
{
    /// <summary>
    /// Вид акции
    /// </summary>
    public class Promotion : ModelBase
    {
        /// <summary>
        /// Название акции
        /// </summary>
        [Required(ErrorMessage = "Поле (Title) - должно быть заполнено.", AllowEmptyStrings = false)]
        public string Title { get; set; }
        /// <summary>
        /// Процент скидки
        /// </summary>
        public int DiscountPercentage { get; set; }
    }
}
