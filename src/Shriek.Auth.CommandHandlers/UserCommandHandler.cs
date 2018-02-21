using Shriek.Commands;
using Shriek.Auth.Commands;
using Shriek.Auth.Domain.User;
using Shriek.Exceptions;

namespace Shriek.Auth.CommandHandlers
{
    public class UserCommandHandler : ICommandHandler<CreateUserCommand>
    {
        public void Execute(ICommandContext context, CreateUserCommand command)
        {
            var root = context.GetAggregateRoot(command.AggregateId, () => new UserAggregateRoot(command.AggregateId, command));

            if (!root.CanCommit)
                throw new DomainException("");
        }
    }
}
