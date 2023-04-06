using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anime_Catalogue_Data.Entitites
{
    public class Anime
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public string Genre { get; set; }
        public string Studio { get; set; }
        public DateTime ReleaseYear { get; set; }

    }
}
