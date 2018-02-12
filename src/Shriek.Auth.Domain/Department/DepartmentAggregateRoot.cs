using System;

namespace Shriek.Auth.Domain.Department
{
    public class DepartmentAggregateRoot : AggregateRoot<Guid>
    {
        #region properties

        /// <summary>
        /// 部门名称
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// 部门编号
        /// </summary>
        public string Code { get; protected set; }

        /// <summary>
        /// 部门负责人
        /// </summary>
        public string Manager { get; protected set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string ContactNumber { get; protected set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { get; protected set; }

        /// <summary>
        /// 父级部门ID
        /// </summary>
        public Guid ParentId { get; protected set; }

        #endregion properties

        #region ctors

        protected DepartmentAggregateRoot(Guid aggregateId) : base(aggregateId)
        {
        }

        protected DepartmentAggregateRoot() : base(Guid.Empty)
        {
        }

        #endregion ctors
    }
}