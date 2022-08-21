using BussinessLayer.Abstract;
using BussinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using DataAccessLayer.Concrete.EntityFramwork;
using EntityLayer.Conctete;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLayer.DependencyResolvers.Ninject
{
    class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            //İsterse To->bunu ver
            Bind<ITodoItemServices>().To<TodoItemManager>().InSingletonScope();
            Bind<ITodoItemDal>().To<EfTodoItemDal>().InSingletonScope();
            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();
            //InSingletonScope(): Tek Nesne Bir Defa Üretilsin
        }
    }
}
