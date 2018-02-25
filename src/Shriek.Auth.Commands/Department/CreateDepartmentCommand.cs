using System;
using Shriek.Commands;

namespace Shriek.Auth.Commands.Department
{
    public class CreateDepartmentCommand : Command<Guid>
    {
        public CreateDepartmentCommand(Guid aggregateId) : base(aggregateId)
        {
        }

        public CreateDepartmentCommand() : base(Guid.Empty)
        {
        }

        /// <summary>
        /// 部门名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 部门编号
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 部门负责人
        /// </summary>
        public string Manager { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string ContactNumber { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { get; set; }

        /// <summary>
        /// 父级部门ID
        /// </summary>
        public Guid ParentId { get; set; }
    }
}