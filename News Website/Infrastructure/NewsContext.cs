using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using News_Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace News_Website.Infrastructure
{
    public class NewsContext : DbContext
    {

        public NewsContext(DbContextOptions<NewsContext> options) : base(options)
        {

        }


        public DbSet<Category> Categories { get; set; }
        public DbSet<ContactUs> Contacts { get; set; }

        public DbSet<News> News { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }


    }
}
