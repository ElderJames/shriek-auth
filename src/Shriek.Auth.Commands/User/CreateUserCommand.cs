using System;
using Shriek.Commands;

namespace Shriek.Auth.Commands
{
    public class CreateUserCommand : Command<Guid>
    {
        public CreateUserCommand(Guid id) : base(id)
        {
        }

        public CreateUserCommand() : base(Guid.Empty) { }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

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
    }
}
