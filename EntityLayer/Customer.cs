using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(20)]
        public string Adi { get; set; }
        [Required, StringLength(20)]
        public string Soyadi { get; set; }
        [Required, StringLength(15)]
        public string Telefon { get; set; }
        public string Email { get; set; }
        [Required]
        public bool UyeMi { get; set; }
        public DateTime KayitTarihi { get; set; }

        // İlişkiler

        public ICollection<Seat> Koltuklar { get; set; }

        public ICollection<Movie> Filmler { get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }
}
