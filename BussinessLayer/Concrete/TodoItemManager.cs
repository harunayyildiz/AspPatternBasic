using BussinessLayer.Abstract;
using BussinessLayer.ValidationRules.FluentValidation;
using DataAccessLayer.Abstract;
using EntityLayer.Conctete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLayer.Concrete
{
    public class TodoItemManager : ITodoItemServices
    {
        private readonly ITodoItemDal _todoItemDal;

        public TodoItemManager(ITodoItemDal todoItemDal)
        {
            _todoItemDal = todoItemDal;
        }
        public void Add(TodoItem todo)
        {
            ValidationTool.Validate(new TodoItemValidation(), todo);
            _todoItemDal.Add(todo);
        }

        public void Delete(TodoItem todo)
        {
            _todoItemDal.Delete(todo);
        }

        public List<TodoItem> GetAll()
        {
            return _todoItemDal.GetAll();
        }

        public List<TodoItem> GetTodoItemByCategory(int categoryId)
        {
            return _todoItemDal.GetAll(p => p.CategoryId == categoryId);
        }

        public List<TodoItem> GetTodoItemBySubjectName(string subject)
        {
            return _todoItemDal.GetAll(p => p.Subject.ToLower().Contains(subject.ToLower()));
        }

        public void Update(TodoItem todo)
        {
            ValidationTool.Validate(new TodoItemValidation(), todo);
            _todoItemDal.Update(todo);
        }
    }
}
