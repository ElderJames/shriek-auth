using System;
using Shriek.Auth.Commands.Department;
using Shriek.Events;
using Shriek.Exceptions;

namespace Shriek.Auth.Domain.Department
{
    public class DepartmentAggregateRoot : AggregateRoot<Guid>,
        IEventHandler<DepartmentCreatedEvent>
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

        public DepartmentAggregateRoot(CreateDepartmentCommand command) : base(command.AggregateId)
        {
            if (string.IsNullOrEmpty(command.Name))
                throw new DomainException("部门名称不能为空");

            ApplyChange(new DepartmentCreatedEvent()
            {
                AggregateId = this.AggregateId,
                Name = command.Name,
                Code = command.Code,
                ContactNumber = command.ContactNumber,
                Manager = command.Manager,
                ParentId = command.ParentId,
                Remarks = command.Remarks,
                Timestamp = DateTime.Now,
            });
        }

        public DepartmentAggregateRoot() : base(Guid.Empty)
        {
        }

        #endregion ctors

        #region create

        public void Handle(DepartmentCreatedEvent e)
        {
            this.Name = e.Name;
            this.Code = e.Code;
            this.ContactNumber = e.ContactNumber;
            this.Manager = e.Manager;
            this.ParentId = e.ParentId;
            this.Remarks = e.Remarks;
            this.CreateDate = e.Timestamp;
            this.Creator = "sys";
        }

        #endregion create
    }
}