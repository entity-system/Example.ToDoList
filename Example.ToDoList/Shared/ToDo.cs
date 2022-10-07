using System.ComponentModel.DataAnnotations;
using EntitySystem.Shared.Fluent.Domain;

namespace Example.ToDoList.Shared
{
    public class ToDo : Entity
    {
        [Required]
        public virtual string Text { get; set; }
    }
}
