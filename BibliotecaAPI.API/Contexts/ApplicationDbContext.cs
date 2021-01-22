using System;
using BibliotecaAPI.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaAPI.API.Contexts
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }
        public DbSet<Autor> Autores { get; set; }
    }
}
