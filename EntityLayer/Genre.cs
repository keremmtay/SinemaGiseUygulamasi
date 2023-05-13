using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Adi { get; set; }
        [Required]
        public int YasSiniri { get; set; }

        // İlişkiler

        public ICollection<Movie> Filmler { get; set; }
    }
}
