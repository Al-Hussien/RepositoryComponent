using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLDbContext.DBContext
{
    public class SQLContext : IdentityDbContext
    {
        public SQLContext(DbContextOptions<SQLContext> options)
            : base(options)
        {
        }
        public DbSet<IGenericModel> GenericModels { get; set; }

        public DbSet<IGenericModel> GetCollection<IGenericModelT>()
        {
            return this.Set<IGenericModel>();
        }
    }
}
/*This code is not used in branch : NewWay1*/

