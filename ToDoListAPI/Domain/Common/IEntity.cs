using FileBaseContext.Abstractions.Models.Entity;

namespace ToDoListAPI.Domain.Common;

public interface IEntity : IFileSetEntity<Guid>
{
}