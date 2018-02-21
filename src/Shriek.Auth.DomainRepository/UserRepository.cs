using Shriek.Auth.Domain.User;
using System;

namespace Shriek.Auth.DomainRepository
{
    public class UserRepository : IUserRepository
    {
        public int Create(UserAggregateRoot root)
        {
            throw new NotImplementedException();
        }

        public UserAggregateRoot ReBuild(Guid aggregateId)
        {
            throw new NotImplementedException();
        }

        public int Update(UserAggregateRoot root)
        {
            throw new NotImplementedException();
        }
    }
}
