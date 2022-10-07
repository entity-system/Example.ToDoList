using EntitySystem.Server.Controllers;
using Example.ToDoList.Server.Services;
using Example.ToDoList.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Example.ToDoList.Server.Controllers;

[Route("/api/categorized")]
public class CategorizedController : EntityController<CategorizedService, Categorized>
{
    public CategorizedController(CategorizedService entityService) : base(entityService)
    {
    }
}