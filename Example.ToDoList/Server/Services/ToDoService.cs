using System;
using EntitySystem.Server.Services;
using Example.ToDoList.Shared;

namespace Example.ToDoList.Server.Services;

public class ToDoService : EntityService<ToDo>
{
    public ToDoService(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }
}