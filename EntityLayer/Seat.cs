using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Seat
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public char Sıra { get; set; }
        [Required]
        public int No { get; set; }
        [Required]
        public double Fiyat { get; set; }
        public bool MusaitMi { get; set; }

        // İlişkiler

        public Customer Musteri { get; set; }

        public ICollection<Theater> Salonlar { get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }
}
