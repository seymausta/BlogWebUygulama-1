using BlogPRestAPI.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPRestAPI.Repository
{
    public class RepositoryBase<T>: IRepositoryBase<T> where T: class
    {
        protected DataContext RepositoryContext { get; set; }

        public RepositoryBase(DataContext repositoryContext)
        {
            this.RepositoryContext = repositoryContext;
        }

        public IQueryable<T> FindAll()
        {
            return this.RepositoryContext.Set<T>().AsNoTracking();
        }
    }
}
