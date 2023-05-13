using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Context : DbContext
    {
        public Context() :base("Server=ASUS;Database=SinemaGiseUygulamasi;Integrated Security=true")
        {
        
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Theater> Theaters { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }
}
