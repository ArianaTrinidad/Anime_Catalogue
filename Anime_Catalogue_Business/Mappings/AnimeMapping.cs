using Anime_Catalogue_Business.Dtos;
using Anime_Catalogue_Data.Entitites;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anime_Catalogue_Business.Mappings
{
    public class AnimeMapping : Profile
    {
        public AnimeMapping()
        {
            CreateMap<Anime, GetAnimeDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Autor, opt => opt.MapFrom(src => src.Author))
                .ForMember(dest => dest.Categoria, opt => opt.MapFrom(src => src.Category))
                .ForMember(dest => dest.Genero, opt => opt.MapFrom(src => src.Genre))
                .ForMember(dest => dest.Estudio, opt => opt.MapFrom(src => src.Studio))
                .ForMember(dest => dest.AnioEstreno, opt => opt.MapFrom(src => src.ReleaseYear.ToString("yyyy")))
                ;

            CreateMap<GetAnimeDto, Anime>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Nombre))
                .ForMember(dest => dest.Author, opt => opt.MapFrom(src => src.Autor))
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Categoria))
                .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genero))
                .ForMember(dest => dest.Studio, opt => opt.MapFrom(src => src.Estudio))
                .ForMember(dest => dest.ReleaseYear, opt => opt.MapFrom(src => src.AnioEstreno))
                ;
        }
    }
}
