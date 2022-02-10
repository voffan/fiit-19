using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiliconValley
{
    class Picture
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
        public int PlacementId { get; set; }
        public Placement Placement { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }
    }
}
