using Anime_Catalogue_Business.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anime_Catalogue_Business.Interfaces
{
    public interface IAnimeService
    {
        List<GetAnimeDto> GetAll(GetAnimeDto dto);
    }
}
