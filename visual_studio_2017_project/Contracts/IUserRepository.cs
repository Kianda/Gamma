using Entities.Models;
using System;
using System.Collections.Generic;

namespace Contracts
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(Guid userId);
    }
}
