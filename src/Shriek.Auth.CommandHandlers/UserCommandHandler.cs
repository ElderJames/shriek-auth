using Shriek.Auth.Commands.User;
using Shriek.Commands;
using Shriek.Auth.Commands;
using Shriek.Auth.Domain.User;
using Shriek.Exceptions;
using System;

namespace Shriek.Auth.CommandHandlers
{
    public class UserCommandHandler : ICommandHandler<CreateUserCommand>, ICommandHandler<ChangeUserCommand>
    {
        public void Execute(ICommandContext context, CreateUserCommand command)
        {
            var root = context.GetAggregateRoot(command.AggregateId, () => new UserAggregateRoot(command.AggregateId, command));

            if (!root.CanCommit)
                throw new DomainException("");
        }

        public void Execute(ICommandContext context, ChangeUserCommand command)
        {
            var root = context.GetAggregateRoot<Guid, UserAggregateRoot>(command.AggregateId);
            if (root == null)
                return;

            root.Change(command);

            if (!root.CanCommit)
                throw new DomainException("");
        }
    }
}