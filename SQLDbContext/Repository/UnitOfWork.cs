
using SQLDbContext.DBContext;
using SQLDbContext.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLDbContext.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SQLContext _dbContext;

        public UnitOfWork(SQLContext dbContext)
        {
            _dbContext = dbContext;
            Parent = new GenericModelRepository(_dbContext);
        }

        public IGenericModelRepository Parent { get; private set; }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
