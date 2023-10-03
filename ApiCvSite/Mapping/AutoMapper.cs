using AutoMapper;
using DtoLayer.Dtos.aboutDto;
using DtoLayer.Dtos.educationDto;
using DtoLayer.Dtos.experienceDto;
using DtoLayer.Dtos.projectDto;
using EntityLayer.concrete;
using System.Runtime;

namespace ApiCvSite.Mapping
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<experienceAddDto, experience>().ReverseMap();
            CreateMap<experienceUpdateDto, experience>().ReverseMap();
            CreateMap<experienceListDto, experience>().ReverseMap();

            CreateMap<educationAddDto, education>().ReverseMap();
            CreateMap<educationUpdateDto, education>().ReverseMap();
            CreateMap<educationListDto, education>().ReverseMap();

            CreateMap<projectAddDto, project>().ReverseMap();
            CreateMap<projectUpdateDto, project>().ReverseMap();
            CreateMap<projectListDto, project>().ReverseMap();

            CreateMap<aboutAddDto, about>().ReverseMap();
            CreateMap<aboutUpdateDto, about>().ReverseMap();
            CreateMap<aboutListDto, about>().ReverseMap();
        }
    }
}
