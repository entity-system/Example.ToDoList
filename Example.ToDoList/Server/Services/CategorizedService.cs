using System;
using EntitySystem.Server.Services;
using Example.ToDoList.Shared;

namespace Example.ToDoList.Server.Services
{
    public class CategorizedService : EntityService<Categorized>
    {
        public CategorizedService(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }
    }
}
