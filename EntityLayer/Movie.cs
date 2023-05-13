using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Adi { get; set; }
        [StringLength(200)]
        public string Aciklama { get; set; }
        public DateTime CikisTarihi { get; set; }
        [Required]
        public int Sure { get; set; }

        // İlişkiler

        public ICollection<Customer> Musteriler { get; set; }

        public ICollection<Theater> Salonlar { get; set; }

        public Genre Tur { get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }
}
