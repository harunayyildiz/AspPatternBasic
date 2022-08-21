using DataAccessLayer.Abstract.Dapper;
using EntityLayer.Conctete;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Concrete.Dapper
{
    public class CategoryDapperRepository : DapperRepositoryBase<Category>, ICategoryDapperRepository
    {
        public CategoryDapperRepository(IConfiguration configuration) : base(configuration)
        {
        }
    }
}
