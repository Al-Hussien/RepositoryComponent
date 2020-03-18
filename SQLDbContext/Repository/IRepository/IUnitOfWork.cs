using System;
using System.Collections.Generic;
using System.Text;

namespace SQLDbContext.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
