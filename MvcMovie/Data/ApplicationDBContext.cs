using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data{
    public class ApplicationDBContext:DbContext{
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) :base(options){

        }
        public DbSet<Ticket> Tickets { get; set; }
    }
}