using System;
using EntitySystem.Client.Services;
using Example.ToDoList.Shared;

namespace Example.ToDoList.Client.Services
{
    public class GroupService : EntityService<Group>
    {
        public GroupService(IServiceProvider serviceProvider) : base("/api/groups", serviceProvider)
        {
        }
    }
}
