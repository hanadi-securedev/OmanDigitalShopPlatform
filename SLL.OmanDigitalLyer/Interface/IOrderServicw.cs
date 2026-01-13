using DAL.OmanDigitalShop.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLL.OmanDigitalLyer.Interface
{
    /// <summary>
    /// واجهة خدمة الطلبات
    /// </summary>
    public interface IOrderService
    {
        // ============================================
        // عمليات القراءة
        // ============================================

        Task<IEnumerable<Order>> GetAllOrdersAsync();
        Task<Order?> GetOrderByIdAsync(int id);
        Task<IEnumerable<Order>> GetOrdersByUserIdAsync(string userId);
        Task<IEnumerable<Order>> GetOrdersByStatusAsync(OrderStatus status);

        // ============================================
        // عمليات الإنشاء والتحديث
        // ============================================

        Task<Order> CreateOrderAsync(Order order);
        Task UpdateOrderStatusAsync(int orderId, OrderStatus newStatus);
        Task CancelOrderAsync(int orderId);

        // ============================================
        // عمليات مساعدة
        // ============================================

        Task<bool> OrderExistsAsync(int id);
        Task<int> GetOrdersCountAsync();
        Task<int> GetPendingOrdersCountAsync();
    }
}
