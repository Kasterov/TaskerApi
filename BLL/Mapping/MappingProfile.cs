
using AutoMapper;
using BLL.DTOs;
using DAL.Entities;
using DAL.Enums;

namespace BLL.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateAssignmentDTO, Assignment>();
        CreateMap<UpdateAssignmentDTO, Assignment>();
    }
}
