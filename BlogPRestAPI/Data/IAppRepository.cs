using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPRestAPI.Data
{
    public interface IAppRepository
    {
        void Create<T>(T entity) where T:class;
        bool SaveAll();

    }
}
