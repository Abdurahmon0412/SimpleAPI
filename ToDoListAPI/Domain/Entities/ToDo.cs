using ToDoListAPI.Domain.Common;

namespace ToDoListAPI.Domain.Models
{
    public class ToDo : SoftDeletedEntity
    {
        public string Name { get; set; }
        public Guid UserId { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}