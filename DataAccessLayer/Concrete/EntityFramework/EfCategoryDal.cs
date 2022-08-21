using DataAccessLayer.Abstract;
using EntityLayer.Conctete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntitiyRepositoryBase<Category, AppDBContext>, ICategoryDal
    {

    }
}
