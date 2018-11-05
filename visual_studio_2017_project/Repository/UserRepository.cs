using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public IEnumerable<User> GetAllUsers()
        {
            return FindAll()
                .OrderBy(ow => ow.Username);
        }

        public User GetUserById(Guid userId)
        {
            return FindByCondition(user => user.Id.Equals(userId))
                    .DefaultIfEmpty(new User())
                    .FirstOrDefault();
        }
    }
}
