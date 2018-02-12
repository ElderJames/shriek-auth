using System;

namespace Shriek.Auth.Domain.Resource
{
    public class ResourceAggregateRoot : AggregateRoot<Guid>
    {
        #region properties

        /// <summary>
        /// 父级ID
        /// </summary>
        public Guid ParentId { get; protected set; }

        /// <summary>
        /// 序号
        /// </summary>
        public int SerialNumber { get; protected set; }

        /// <summary>
        /// 菜单名称
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// 菜单编码
        /// </summary>
        public string Code { get; protected set; }

        /// <summary>
        /// 菜单地址
        /// </summary>
        public string Url { get; protected set; }

        /// <summary>
        /// 类型：0导航菜单；1操作按钮。
        /// </summary>
        public int Type { get; protected set; }

        /// <summary>
        /// 菜单图标
        /// </summary>
        public string Icon { get; protected set; }

        /// <summary>
        /// 菜单备注
        /// </summary>
        public string Remarks { get; protected set; }

        #endregion properties

        #region ctors

        protected ResourceAggregateRoot() : base(Guid.Empty)
        {
        }

        protected ResourceAggregateRoot(Guid aggregateId) : base(aggregateId)
        {
        }

        #endregion ctors
    }
}