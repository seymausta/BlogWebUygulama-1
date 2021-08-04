using BlogPRestAPI.Data;
using BlogPRestAPI.Models;
using BlogPRestAPI.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPRestAPI.Repository
{
    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(DataContext repositoryContext )
            :base(repositoryContext)
        {

        }
        public Task<PagedList<Post>> GetValues(PagingParameters pagingParameters)
        {
            return Task.FromResult(PagedList<Post>.GetPagedList(FindAll().OrderBy(s=> s.Id), pagingParameters.PageNumber,pagingParameters.PageSize));
        }
    }
}
