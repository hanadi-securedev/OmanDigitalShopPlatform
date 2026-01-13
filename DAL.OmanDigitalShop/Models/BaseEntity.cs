using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.OmanDigitalShop.Models
{
    /// <summary>
    /// الكلاس الأساسي - كل الموديلات ترث منه
    /// </summary>
    public abstract class BaseEntity
    {
        public int Id { get; set; }

    }
}
