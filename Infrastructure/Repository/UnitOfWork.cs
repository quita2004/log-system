using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public ILogsRepostory Logs{ get; }
        public UnitOfWork(ILogsRepostory logsRepostory)
        {
            Logs = logsRepostory;
        }
    }
}
