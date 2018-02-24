using Shriek.Auth.Commands.User;
using Shriek.Auth.Commands;
using Shriek.Events;
using Shriek.Exceptions;
using System;

namespace Shriek.Auth.Domain.User
{
    public class UserAggregateRoot : AggregateRoot<Guid>,
        IHandle<UserCreatedEvent>,
        IHandle<UserChangedEvent>
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
        public string Email { get; protected set; }

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

        public UserAggregateRoot(Guid aggregateId, CreateUserCommand command) : base(aggregateId)
        {
            if (string.IsNullOrEmpty(command.UserName))
                throw new DomainException("用户名为空");

            if (string.IsNullOrEmpty(command.Password))
                throw new DomainException("密码为空");

            if (string.IsNullOrEmpty(command.Email) && string.IsNullOrEmpty(command.MobileNumber))
                throw new DomainException("email和手机号都为空");

            ApplyChange(new UserCreatedEvent
            {
                AggregateId = this.AggregateId,
                UserName = command.UserName,
                Password = command.Password,
                Email = command.Email,
                DepartmentId = command.DepartmentId,
                MobileNumber = command.MobileNumber,
                Timestamp = DateTime.Now
            });
        }

        public UserAggregateRoot() : base(Guid.Empty)
        {
        }

        #endregion ctors

        #region create

        public void Handle(UserCreatedEvent e)
        {
            this.UserName = e.UserName;
            this.Password = e.Password;
            this.Email = e.Email;
            this.MobileNumber = e.MobileNumber;
            this.DepartmentId = e.DepartmentId;
            this.CreateDate = e.Timestamp;
            this.Creator = "sys";
        }

        #endregion create

        #region change

        public void Change(ChangeUserCommand command)
        {
            if (string.IsNullOrEmpty(command.Password))
                throw new DomainException("密码为空");

            if (string.IsNullOrEmpty(command.Email) && string.IsNullOrEmpty(command.MobileNumber))
                throw new DomainException("email和手机号都为空");

            this.ApplyChange(new UserChangedEvent
            {
                AggregateId = this.AggregateId,

                Password = command.Password,
                Email = command.Email,
                MobileNumber = command.MobileNumber,
                DepartmentId = command.DepartmentId,
                Timestamp = DateTime.Now,
            });
        }

        public void Handle(UserChangedEvent e)
        {
            this.Password = e.Password;
            this.Email = e.Email;
            this.MobileNumber = e.MobileNumber;
            this.DepartmentId = e.DepartmentId;
            this.EditDate = e.Timestamp;
            this.Creator = "sys";
        }

        #endregion change
    }
}