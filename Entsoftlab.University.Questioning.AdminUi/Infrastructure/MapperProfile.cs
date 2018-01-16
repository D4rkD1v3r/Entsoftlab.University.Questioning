using AutoMapper;
using Entsoftlab.University.Questioning.Data.Models;

namespace Entsoftlab.University.Questioning.AdminUi.Infrastructure {
  public class MapperProfile : Profile {
    public MapperProfile() {
      CreateMap<Faculty, Models.Faculty>().ForMember(d => d.ShortName, opt => opt.MapFrom(src => src.Name));
      CreateMap<Models.Faculty,Faculty>().ForMember(d => d.Name, opt => opt.MapFrom(src => src.ShortName));
      CreateMap<Department, Models.Department>().ForMember(d => d.ShortName, opt => opt.MapFrom(src => src.Name));
      CreateMap<Models.Department, Department>().ForMember(d => d.Name, opt => opt.MapFrom(src => src.ShortName));
    }
  }
}
