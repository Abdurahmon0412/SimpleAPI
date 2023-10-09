using FileBaseContext.Abstractions.Models.FileSet;
using ToDoListAPI.Domain.Models;

namespace Backend_Project.Persistance.DataContexts;

public interface IDataContext
{
    
    IFileSet<User, Guid> Users { get; }
    IFileSet<ToDo, Guid> ToDos { get; }

    ValueTask SaveChangesAsync();
}