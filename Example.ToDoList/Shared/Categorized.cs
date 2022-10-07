using System.ComponentModel.DataAnnotations;
using EntitySystem.Shared.Fluent.Domain;

namespace Example.ToDoList.Shared
{
    public class Categorized : Entity
    {
        [Required]
        [ValidateComplexType]
        public virtual ToDo ToDo { get; set; }

        [Required]
        [ValidateComplexType]
        public virtual Group Group { get; set; }
    }
}
