using Shriek.Auth.Commands.Department;
using Shriek.Auth.Domain.Department;
using Shriek.Commands;

namespace Shriek.Auth.CommandHandlers
{
    public class DepartmentCommandHandler : ICommandHandler<CreateDepartmentCommand>
    {
        public void Execute(ICommandContext context, CreateDepartmentCommand command)
        {
            var root = context.GetAggregateRoot(command.AggregateId, () => new DepartmentAggregateRoot(command));

            if (!root.CanCommit)
                return;
        }
    }
}