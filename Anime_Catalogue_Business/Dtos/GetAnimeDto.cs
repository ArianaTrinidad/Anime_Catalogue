using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anime_Catalogue_Business.Dtos
{
    public class GetAnimeDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Autor { get; set; }
        public string Categoria { get; set; }
        public string Genero { get; set; }
        public string Estudio { get; set; }
        public string AnioEstreno { get; set; }
    }
}
