using Shriek.Events;
using System;

namespace Shriek.Auth.Domain.User
{
    public class UserChangedEvent : Event<Guid>
    {
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 邮箱地址
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string MobileNumber { get; set; }

        /// <summary>
        /// 所属部门实体
        /// </summary>
        public Guid DepartmentId { get; set; }
    }
}