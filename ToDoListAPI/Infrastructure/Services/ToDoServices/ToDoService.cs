using System.Linq.Expressions;
using ToDoListAPI.Application.Interfaces;
using ToDoListAPI.Domain.Models;

namespace ToDoListAPI.Infrastructure.Services.ToDoServices
{
    public class ToDoService : IEntityBaseService<ToDo>
    {
        public ValueTask<ToDo> CreateAsync(ToDo entity, bool saveChanges = true, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public ValueTask<ToDo> DeleteAsync(Guid id, bool saveChanges = true, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public ValueTask<ToDo> DeleteAsync(ToDo entity, bool saveChanges = true, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ToDo> Get(Expression<Func<ToDo, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public ValueTask<ICollection<ToDo>> GetAsync(IEnumerable<Guid> ids, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public ValueTask<ToDo> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public ValueTask<ToDo> UpdateAsync(ToDo entity, bool saveChanges = true, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}