using System;
using EntitySystem.Client.Services;
using Example.ToDoList.Shared;

namespace Example.ToDoList.Client.Services
{
    public class ToDoService : EntityService<ToDo>
    {
        public ToDoService(IServiceProvider serviceProvider) : base("/api/to-do", serviceProvider)
        {
        }
    }
}
