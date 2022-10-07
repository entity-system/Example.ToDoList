using System;
using EntitySystem.Server.Services;
using Example.ToDoList.Shared;

namespace Example.ToDoList.Server.Services;

public class GroupService : EntityService<Group>
{
    public GroupService(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }
}