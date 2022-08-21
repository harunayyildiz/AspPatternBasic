using Dapper.FluentMap.Dommel.Mapping;
using EntityLayer.Conctete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Concrete.Dapper.Mapping
{
    public class TodoItemDapperMap : DommelEntityMap<TodoItem>
    {
        public TodoItemDapperMap()
        {
            ToTable("TodoItem");
            Map(p => p.Id).IsKey();
        }
    }
}
