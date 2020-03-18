using SQLDbContext.DBContext;
using SQLDbContext.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLDbContext.Repository.IRepository
{
    public interface IGenericModelRepository: IRepository<IGenericModel>
    {
        void Update(IGenericModel genericModel);
    }
}
