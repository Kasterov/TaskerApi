
using DAL.Entities;
using DAL.Enums;

namespace DAL.Repository;

public interface IAssignmentRepository
{
    Task<Assignment?> GetAssignmentById(int id);
    Task<IEnumerable<Assignment>> GetAssignmentsByStatus(AssignmentStatus status);
    Task DeleteAssignment(int id);
    Task UpdateAssignmentById(Assignment assignment);
    Task PatchAssignmentStatusById(int id, AssignmentStatus status);
    Task PutAssignment(Assignment assignment);
    Task<IEnumerable<Assignment>> GetAllAssignments();
}
