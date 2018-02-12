using System;

namespace Shriek.Auth.Domain.UserRole
{
    /// <summary>
    /// 用户权限聚合
    /// </summary>
    public class UserRoleAggregateRoot : AggregateRoot<Guid>
    {
        #region properties

        /// <summary>
        ///
        /// </summary>
        public int RoleId { get; protected set; }

        /// <summary>
        ///
        /// </summary>
        public long UserId { get; protected set; }

        #endregion properties

        #region ctors

        protected UserRoleAggregateRoot(Guid aggregateId) : base(aggregateId)
        {
        }

        protected UserRoleAggregateRoot() : base(Guid.Empty)
        {
        }

        #endregion ctors
    }
}