using System;
using System.Collections.Generic;
using System.Text;
using Battlebus.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Battlebus.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options){}
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<SavedPolitician> SavedPoliticians { get; set; }
        public DbSet<Note> Notes { get; set; }
    }
}
