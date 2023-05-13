using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Booking
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int MovieId { get; set; }
        public int TheaterId { get; set; }
        public int SeatId { get; set; }

        public ICollection<Customer> Customers { get; set; }
        public ICollection<Movie> Movies { get; set; }
        public ICollection<Theater> Theaters { get; set; }
        public ICollection<Seat> Seats { get; set; }
    }
}
