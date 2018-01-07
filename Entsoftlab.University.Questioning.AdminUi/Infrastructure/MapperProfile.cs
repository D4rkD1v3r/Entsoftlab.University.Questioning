using AutoMapper;
using Entsoftlab.University.Questioning.AdminUi.Models;

namespace Entsoftlab.University.Questioning.AdminUi.Infrastructure {
  public class MapperProfile : Profile {
    public MapperProfile() {
      CreateMap<Entsoftlab.University.Questioning.Data.Models.Faculty, Faculty>().ForMember(d => d.ShortName, opt => opt.MapFrom(src => src.Name));
      CreateMap<Faculty,Entsoftlab.University.Questioning.Data.Models.Faculty>().ForMember(d => d.Name, opt => opt.MapFrom(src => src.ShortName));
    }
  }
}
