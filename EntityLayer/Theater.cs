using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Theater
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Numarasi { get; set; }
        public int KoltukSayisi { get; set; }

        // İlişkiler

        public ICollection<Employee> Personeller { get; set; }

        public ICollection<Movie> Filmler { get; set; }

        public ICollection<Seat> Koltuklar { get; set; }

        public ICollection<Booking> Bookings { get; set; }

    }
}
