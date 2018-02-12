using System;

namespace Shriek.Auth.Domain.Role
{
    public class RoleAggregateRoot : AggregateRoot<Guid>
    {
        #region properties

        public string Code { get; protected set; }

        public string Name { get; protected set; }

        public string Remarks { get; protected set; }

        #endregion properties

        #region ctors

        protected RoleAggregateRoot(Guid aggregateId) : base(aggregateId)
        {
        }

        protected RoleAggregateRoot() : base(Guid.Empty)
        {
        }

        #endregion ctors
    }
}