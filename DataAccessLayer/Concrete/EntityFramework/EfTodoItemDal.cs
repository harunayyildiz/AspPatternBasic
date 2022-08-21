using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Conctete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Concrete.EntityFramwork
{
    public class EfTodoItemDal : EfEntitiyRepositoryBase<TodoItem, AppDBContext>, ITodoItemDal
    {
      
    }
}
