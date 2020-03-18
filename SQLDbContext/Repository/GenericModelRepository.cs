using SQLDbContext.DBContext;
using SQLDbContext.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLDbContext.Repository
{
    public class GenericModelRepository : Repository<IGenericModel>, IGenericModelRepository
    {
        private readonly SQLContext _dbContext;
        public GenericModelRepository(SQLContext dbContext): base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Update(IGenericModel genericModel)
        {
            var objFromDb = _dbContext.GenericModels.FirstOrDefault(s => s.Id == genericModel.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = genericModel.Name;
            }
        }
    }
}
