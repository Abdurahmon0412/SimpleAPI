using System.Text.Json.Serialization;

namespace ToDoListAPI.Domain.Common;

public abstract class Entity : IEntity
{
    public Guid Id { get; set; }
}