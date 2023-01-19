
using AutoMapper;
using BLL.DTOs;
using DAL.Entities;

namespace BLL.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateAssignmentDTO, Assignment>();
        CreateMap<UpdateAssignmentDTO, Assignment>();
    }
}
