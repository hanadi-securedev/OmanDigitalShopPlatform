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
    /// واجهة ريبوزيتوري المنتجات
    /// تحتوي على عمليات إضافية خاصة بالمنتجات
    /// </summary>
    public interface IProductRepository : IGenericRepositery<Product>
    {
        // ============================================
        // عمليات خاصة بالمنتجات
        // ============================================

        /// <summary>
        /// الحصول على جميع المنتجات مع الفئات
        /// </summary>
        Task<IEnumerable<Product>> GetAllWithCategoryAsync();

        /// <summary>
        /// الحصول على منتج مع الفئة
        /// </summary>
        Task<Product?> GetByIdWithCategoryAsync(int id);

        /// <summary>
        /// الحصول على منتجات فئة معينة
        /// </summary>
        Task<IEnumerable<Product>> GetByCategoryIdAsync(int categoryId);

        /// <summary>
        /// الحصول على المنتجات النشطة فقط
        /// </summary>
        Task<IEnumerable<Product>> GetActiveProductsAsync();

        /// <summary>
        /// البحث في المنتجات بالاسم
        /// </summary>
        Task<IEnumerable<Product>> SearchByNameAsync(string searchTerm);
    }
}
