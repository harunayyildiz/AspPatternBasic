using DataAccessLayer.Abstract;
using EntityLayer.Conctete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract.Dapper
{
    public interface ITodoItemDapperRepository : IEntityRepository2<TodoItem>
    {
    }
}
