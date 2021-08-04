using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPRestAPI.Models
{
    public class PostCreateDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
    }
}
