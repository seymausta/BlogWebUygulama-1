﻿using BlogPRestAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPRestAPI.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
       
        public DbSet<Post> Posties { get; set; }
        public DbSet<User> Users { get; set; }
        //public DbSet<PostUpdateDto> UPosties { get; set; }

    }
}
