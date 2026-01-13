using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.OmanDigitalShop.Models.Orders
{
    /// <summary>
    /// حالات الطلب المختلفة
    /// </summary>
    public enum OrderStatus
    {
        // الطلب في انتظار المعالجة
        Pending = 0,

        // تم تأكيد الطلب
        Confirmed = 1,

        // جاري الشحن
        Shipping = 2,

        // تم التوصيل
        Delivered = 3,

        // تم الإلغاء
        Cancelled = 4
    }
}
