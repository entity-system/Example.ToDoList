using EntitySystem.Server.Controllers;
using Example.ToDoList.Server.Services;
using Example.ToDoList.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Example.ToDoList.Server.Controllers;

[Route("/api/to-do")]
public class ToDoController : EntityController<ToDoService, ToDo>
{
    public ToDoController(ToDoService entityService) : base(entityService)
    {
    }
}