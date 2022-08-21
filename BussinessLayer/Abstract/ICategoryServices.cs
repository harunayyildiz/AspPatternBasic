using EntityLayer.Conctete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLayer.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
