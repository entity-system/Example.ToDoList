using System;
using EntitySystem.Client.Services;
using Example.ToDoList.Shared;

namespace Example.ToDoList.Client.Services
{
    public class CategorizedService : EntityService<Categorized>
    {
        public CategorizedService(IServiceProvider serviceProvider) : base("/api/categorized", serviceProvider)
        {
        }
    }
}
