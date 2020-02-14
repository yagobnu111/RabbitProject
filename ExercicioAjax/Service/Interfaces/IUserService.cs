using Model;
using Service.Model.User;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IUserService
    {
        Task Add(UserModelInsert user);
        Task Update(UserModelUpdate user);
        Task<User> GetById(Guid id);
        Task<List<User>> GetAll();
        Task Delete(Guid id);
    }
}
