using System;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaAPI.API.Contexts
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }
    }
}
