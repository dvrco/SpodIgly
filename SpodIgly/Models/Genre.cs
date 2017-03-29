using System.Collections.Generic;

namespace SpodIgly.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string IconFilename { get; set; }

        public virtual ICollection<Album> Albums { get; set; }
    }
}