using EntityLayer.Conctete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLayer.Abstract
{
    public interface ITodoItemServices
    {
        List<TodoItem> GetAll();
        List<TodoItem> GetTodoItemByCategory(int categoryId);
        List<TodoItem> GetTodoItemBySubjectName(string subject);
        void Add(TodoItem todo);
        void Update(TodoItem todo);
        void Delete(TodoItem todo);
    }
}
