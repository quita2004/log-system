using Core.Entities;

namespace Application.Interfaces
{
    public interface ILogsRepostory : IGenericRepository<Logs>
    {
        public Task<IEnumerable<Logs>> Get();
    }
}
