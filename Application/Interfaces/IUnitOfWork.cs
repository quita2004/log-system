namespace Application.Interfaces
{
    public interface IUnitOfWork
    {
        ILogsRepostory Logs{ get; }
    }
}
