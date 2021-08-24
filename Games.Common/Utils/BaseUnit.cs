using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace IronLogic.OCS.Admin.Common.Utils
{
    public class BaseUnit : DbContext
    {
        protected readonly string _connection;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection">Connection String</param>
        public BaseUnit(string connection)
        {
            _connection = connection;
            Init();
        }
        public BaseUnit(DbContextOptions options) : base(options)
        {
            Init();
        }
        //protected RepositoryQueryable _queryable;
        //public IRepositoryQueryable Queryable => _queryable;

        protected virtual void Init()
        {
            //_queryable = new RepositoryQueryable(this.Database);
        }
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
