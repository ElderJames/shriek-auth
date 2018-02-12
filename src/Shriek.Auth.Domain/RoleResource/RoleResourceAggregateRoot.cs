using System;
using System.Collections.Generic;
using System.Text;

namespace Shriek.Auth.Domain.RoleResource
{
    public class RoleResourceAggregateRoot : AggregateRoot<Guid>
    {
        #region property

        /// <summary>
        ///
        /// </summary>
        public int RoleId { get; protected set; }

        /// <summary>
        ///
        /// </summary>
        public int ResourceId { get; protected set; }

        #endregion property

        #region ctor

        public RoleResourceAggregateRoot()
            : this(Guid.Empty)
        {
        }

        public RoleResourceAggregateRoot(Guid aggregateId)
            : base(aggregateId)
        {
        }

        #endregion ctor
    }
}