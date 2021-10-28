using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Entities.Models.Base
{
    /// <summary>
    /// Базовый абстрактный класс моделей
    /// </summary>
    public abstract class ModelBase
    {
        /// <summary>
        /// Id модели
        /// </summary>
        public int Id { get; set; }
    }
}
