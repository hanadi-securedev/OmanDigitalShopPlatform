using DAL.OmanDigitalShop.IProductReapstory;
using DAL.OmanDigitalShop.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.OmanDigitalShop.Interface
{
    /// <summary>
    /// واجهة ريبوزيتوري الفئات
    /// تحتوي على عمليات إضافية خاصة بالفئات
    /// </summary>
    public interface ICategoryRepository : IGenericRepositery<Category>
    {
        // ============================================
        // عمليات خاصة بالفئات
        // ============================================

        /// <summary>
        /// الحصول على فئة مع منتجاتها
        /// </summary>
        Task<Category?> GetByIdWithProductsAsync(int id);

        /// <summary>
        /// الحصول على جميع الفئات مع عدد المنتجات
        /// </summary>
        Task<IEnumerable<Category>> GetAllWithProductCountAsync();

        /// <summary>
        /// الحصول على الفئات النشطة فقط
        /// </summary>
        Task<IEnumerable<Category>> GetActiveCategoriesAsync();

        /// <summary>
        /// التحقق من وجود فئة بنفس الاسم
        /// </summary>
        Task<bool> ExistsByNameAsync(string name);
    }
}
