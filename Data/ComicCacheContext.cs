using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ComicCache.Models;

namespace ComicCache.Data
{
    public class ComicCacheContext : DbContext
    {
        public ComicCacheContext (DbContextOptions<ComicCacheContext> options)
            : base(options)
        {
        }

        public DbSet<ComicCache.Models.Comic> Comic { get; set; }
    }
}
