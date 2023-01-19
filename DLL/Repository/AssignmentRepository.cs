
using DAL.Data;
using DAL.Entities;
using DAL.Enums;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository;

public class AssignmentRepository : IAssignmentRepository
{
    private readonly TaskerDbContext _DbContext;

    public AssignmentRepository(TaskerDbContext dbContext)
    {
        _DbContext = dbContext;
    }

    public async Task DeleteAssignment(int id)
    {
        var assignment = await GetAssignmentById(id);

        _DbContext.Assignments.Remove(assignment);
        await _DbContext.SaveChangesAsync();
    }

    public async Task<IEnumerable<Assignment>> GetAllAssignments()
    {
        var assignments = await _DbContext.Assignments.ToListAsync();

        return assignments;
    }

    public async Task<Assignment?> GetAssignmentById(int id)
    {
        var assignment = await _DbContext.Assignments
            .FirstOrDefaultAsync(x => x.Id == id);

        return assignment is not null ? assignment : null; 
    }

    public async Task<IEnumerable<Assignment>> GetAssignmentsByStatus(AssignmentStatus status)
    {
        var assignments = await _DbContext.Assignments
            .Where(x => x.Status == status)
            .Select(x => new Assignment
            {
                Id = x.Id,
                Status = x.Status,
                Description = x.Description,
                Name = x.Name
            })
            .ToListAsync();

        return assignments;
    }

    public async Task PatchAssignmentStatusById(int id, AssignmentStatus status)
    {
        var assignment = await GetAssignmentById(id);

        assignment.Status = status;

        await _DbContext.SaveChangesAsync();
    }

    public async Task PutAssignment(Assignment assignment)
    {
        await _DbContext.Assignments.AddAsync(assignment);
        await _DbContext.SaveChangesAsync();
    }

    public async Task UpdateAssignmentById(Assignment assignment)
    {
        var assignmentToChange = await GetAssignmentById(assignment.Id);

        assignmentToChange.Name = assignment.Name;
        assignmentToChange.Description = assignment.Description;
        assignmentToChange.Status = assignment.Status;

        await _DbContext.SaveChangesAsync();
    }
}
