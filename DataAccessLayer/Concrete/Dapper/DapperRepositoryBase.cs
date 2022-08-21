using Dapper.Contrib.Extensions;
using Dapper.FluentMap;
using Dapper.FluentMap.Dommel;
using DataAccessLayer.Abstract.Dapper;
using DataAccessLayer.Concrete.Dapper.Mapping;
using EntityLayer.Abstract;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Text;

namespace DataAccessLayer.Concrete.Dapper
{
    public class DapperRepositoryBase<TEntity> : IEntityRepository2<TEntity> where TEntity : class
    {
        private readonly IConfiguration _configuration;
        protected readonly SqlConnection conn;


        public DapperRepositoryBase(IConfiguration configuration)
        {
            _configuration = configuration;
            if (FluentMapper.EntityMaps.IsEmpty) //EntityMap ler boş ise Map'le
            {
                FluentMapper.Initialize(c =>
                {
                    c.AddMap(new TodoItemDapperMap());
                    c.AddMap(new CategoryDapperMap());
                    c.ForDommel();
                });
            }

            conn = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));

        }
        public void Add(TEntity entity)
        {
            conn.Insert(entity);
        }

        public void Delete(TEntity entity)
        {
            conn.Delete(entity);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            return conn.Get<TEntity>(filter);
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            return conn.GetAll<TEntity>();
        }

        public void Update(TEntity entity)
        {
            conn.Update(entity);
        }

        public DapperRepositoryBase()
        {
            Dispose();
        }

        public void Dispose()
        {
            if (Equals(!_disposed))
            {
                conn.Close();
                conn.Dispose();
                _disposed = true;
            }
            GC.SuppressFinalize(this);
        }

        private bool _disposed = false;
    }
}
