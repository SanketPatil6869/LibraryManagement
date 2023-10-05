using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LibraryManagementApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace LibraryManagementApp.Data
{
    public class LibraryManagementAppContext : IdentityDbContext
    {
        public LibraryManagementAppContext (DbContextOptions<LibraryManagementAppContext> options)
            : base(options)
        {
        }

        public DbSet<LibraryManagementApp.Models.Book> Book { get; set; } = default!;
    }
}
