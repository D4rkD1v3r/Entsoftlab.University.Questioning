using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Rmi.University.Questioning.AdminUi.Models;

namespace Rmi.University.Questioning.AdminUi.Infrastructure {
  public class MapperProfile : Profile {
    public MapperProfile() {
      CreateMap<Data.Models.Faculty, Faculty>().ForMember(d => d.ShortName, opt => opt.MapFrom(src => src.Name));
      CreateMap<Faculty,Data.Models.Faculty>().ForMember(d => d.Name, opt => opt.MapFrom(src => src.ShortName));
    }
  }
}
