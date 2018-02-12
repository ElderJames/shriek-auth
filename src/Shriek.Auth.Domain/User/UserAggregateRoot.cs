using System;

namespace Shriek.Auth.Domain.User
{
    public class UserAggregateRoot : AggregateRoot<Guid>
    {
        #region properties

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; protected set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; protected set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// 邮箱地址
        /// </summary>
        public string EMail { get; protected set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string MobileNumber { get; protected set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { get; protected set; }

        /// <summary>
        /// 上次登录时间
        /// </summary>
        public DateTime LastLoginTime { get; protected set; }

        /// <summary>
        /// 登录次数
        /// </summary>
        public int LoginTimes { get; protected set; }

        /// <summary>
        /// 所属部门实体
        /// </summary>
        public Guid DepartmentId { get; protected set; }

        #endregion properties

        #region ctors

        protected UserAggregateRoot(Guid aggregateId) : base(aggregateId)
        {
        }

        protected UserAggregateRoot() : base(Guid.Empty)
        {
        }

        #endregion ctors
    }
}