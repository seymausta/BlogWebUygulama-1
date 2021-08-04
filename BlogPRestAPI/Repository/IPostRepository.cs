using BlogPRestAPI.Models;
using BlogPRestAPI.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPRestAPI.Repository
{
   public interface IPostRepository : IRepositoryBase<Post>
    {
        Task<PagedList<Post>> GetValues(PagingParameters pagingParameteres);
    }
}
