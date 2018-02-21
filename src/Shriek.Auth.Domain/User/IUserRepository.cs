using System;
using System.Collections.Generic;
using System.Text;

namespace Shriek.Auth.Domain.User
{
    public interface IUserRepository
    {
        int Create(UserAggregateRoot root);

        UserAggregateRoot ReBuild(Guid aggregateId);

        int Update(UserAggregateRoot root);
    }
}
