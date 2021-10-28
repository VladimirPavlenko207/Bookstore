using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Enums
{
    /// <summary>
    /// Действия с акциями
    /// </summary>
    public enum PromOperations
    {
        None,
        /// <summary>
        /// Редактирование акций
        /// </summary>
        PromEdit,
        /// <summary>
        /// Редактирование периодов акций
        /// </summary>
        PromPeriodEdit
    }
}
