using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPRestAPI.Data
{
    public class AppRepository : IAppRepository
    {
        DataContext _context;
        public AppRepository(DataContext context)
        {
            _context = context; 
        }

        public void Create<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public bool SaveAll()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
