
using DAL.Entities;
using DAL.Enums;

namespace DAL.Repository;

public interface IAssignmentRepository
{
    Task<Assignment?> GetAssignmentById(int id);
    Task<IEnumerable<Assignment>> GetAssignmentsByStatus(EnumStatus status);
    Task DeleteAssignment(int id);
    Task UpdateAssignmentById(Assignment assignment);
    Task PutAssignment(Assignment assignment);
}
