using Anime_Catalogue_Data.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anime_Catalogue_Data.Interfaces
{
    public interface IAnimeRepository
    {
        List<Anime> GetAll();
    }
}
