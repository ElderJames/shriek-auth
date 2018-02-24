using Shriek.Events;
using System;
using Shriek.Auth.Domain.User;

namespace Shriek.Auth.EventHandlers
{
    public class UserEventHandler : IEventHandler<UserCreatedEvent>, IEventHandler<UserChangedEvent>
    {
        private IUserRepository userRepository;

        public UserEventHandler(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public void Handle(UserCreatedEvent e)
        {
            throw new NotImplementedException();
        }

        public void Handle(UserChangedEvent e)
        {
            throw new NotImplementedException();
        }
    }
}