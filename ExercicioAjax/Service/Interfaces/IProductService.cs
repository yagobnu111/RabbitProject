using Model;
using Repository.Pagination;
using Service.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IProductService
    {
        Task Add(ProductModelInsert product);
        Task Update(ProductModelUpdate product);
        Task Delete(Guid id);
        Task<List<Product>> GetAll(ProductPagination pagination);
        Task<List<Product>> GetAllJson(ProductPagination pagination);   
        Task<Product> GetById(Guid id);
        Task<bool> NameExists(string name, Guid id);
    }
}
