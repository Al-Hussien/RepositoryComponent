using System;
using System.Collections.Generic;
using System.Text;

namespace SQLDbContext.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericModelRepository Parent { get; }
        void Save();
    }
}
