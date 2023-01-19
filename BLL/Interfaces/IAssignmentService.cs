using BLL.DTOs;
using DAL.Entities;
using DAL.Enums;
using System.Collections.Generic;

namespace BLL.Interfaces;

public interface IAssignmentService
{
    Task CreateAssignment(CreateAssignmentDTO assignemnt);
    Task UpdateAssignment(int id, UpdateAssignmentDTO assignemnt);
    Task<IEnumerable<Assignment>> GetAssignementsByStatus(AssignmentStatus status);
    Task DeleteAssignment(int id);
    Task<Assignment> GetAssignment(int id);
    Task PatchAssignmentStatus(int id, AssignmentStatus status);
    Task<IEnumerable<Assignment>> GetAllAssignments();
}
