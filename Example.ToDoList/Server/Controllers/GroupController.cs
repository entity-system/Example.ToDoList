using EntitySystem.Server.Controllers;
using Example.ToDoList.Server.Services;
using Example.ToDoList.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Example.ToDoList.Server.Controllers;

[Route("/api/groups")]
public class GroupController : EntityController<GroupService, Group>
{
    public GroupController(GroupService entityService) : base(entityService)
    {
    }
}