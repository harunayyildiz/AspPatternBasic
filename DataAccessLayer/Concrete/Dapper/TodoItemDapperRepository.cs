using Dapper;
using DataAccessLayer.Abstract.Dapper;
using EntityLayer.Conctete;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Concrete.Dapper
{
    public class TodoItemDapperRepository : DapperRepositoryBase<TodoItem>, ITodoItemDapperRepository
    {
        public TodoItemDapperRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public IEnumerable<TodoItem> GetAll() => conn.Query<TodoItem, Category, TodoItem>(
            @"Select * from TodoItem INNER JOIN Category ON TodoItem.CategoryId = CategoryId"
            
            );
    }
}
