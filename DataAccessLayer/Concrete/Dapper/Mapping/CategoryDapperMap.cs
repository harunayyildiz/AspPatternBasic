using Dapper.FluentMap.Dommel.Mapping;
using EntityLayer.Conctete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Concrete.Dapper.Mapping
{
    public class CategoryDapperMap : DommelEntityMap<Category>
    {
        public CategoryDapperMap()
        {
            ToTable("Category");
            Map(p => p.CategoryId).IsKey().IsIdentity();
        }
    }
}

//Map'lemek için : Dapper.FluentMap.Dommel.Mapping paketini kullanıyoruz.