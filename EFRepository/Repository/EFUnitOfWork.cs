using Microsoft.EntityFrameworkCore;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFRepository.Repository
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly DbContext _dbContext; 

        public EFUnitOfWork(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

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
