using System;
using Shriek.Auth.Domain.Department;
using Shriek.Events;

namespace Shriek.Auth.EventHandlers
{
    public class DepartmentEventHandler : IEventHandler<DepartmentCreatedEvent>
    {
        public void Handle(DepartmentCreatedEvent e)
        {
            throw new NotImplementedException();
        }
    }
}