using DAL.OmanDigitalShop.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLL.OmanDigitalLyer.Interface
{
    /// <summary>
    /// واجهة خدمة المنتجات
    /// </summary>
    public interface IProductService
    {
        // ============================================
        // عمليات القراءة
        // ============================================

        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<IEnumerable<Product>> GetActiveProductsAsync();
        Task<Product?> GetProductByIdAsync(int id);
        Task<IEnumerable<Product>> GetProductsByCategoryAsync(int categoryId);
        Task<IEnumerable<Product>> SearchProductsAsync(string searchTerm);

        // ============================================
        // عمليات الإنشاء والتحديث والحذف
        // ============================================

        Task<Product> CreateProductAsync(Product product);
        Task UpdateProductAsync(Product product);
        Task DeleteProductAsync(int id);

        // ============================================
        // عمليات مساعدة
        // ============================================

        Task<bool> ProductExistsAsync(int id);
        Task<int> GetProductsCountAsync();
    }
}
