using DAL.OmanDigitalShop.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.OmanDigitalShop.IProductReapstory
{
    public interface IGenericRepositery <T>
    {
        Task<IEnumerable<T>> GetAllAsync(); // Returns a list of all entity
        Task<T> GetByIdAsync(int Id); // Returns a entity by its ID
        Task AddAsync(T enetity);  // Adds a new entity
        Task UpdateAsync(T enetity); // Updates an existing entity
        Task DeleteAsync(int id); // Deletes a entity by its ID
    }
}
