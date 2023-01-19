using AutoMapper;
using BLL.DTOs;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Enums;
using DAL.Repository;

namespace BLL.Services;

public class AssignmentService : IAssignmentService
{
    private readonly IAssignmentRepository _assignmentRepository;
    private readonly IMapper _mapper;

    public AssignmentService(IAssignmentRepository assignmentRepository,
        IMapper mapper)
    {
        _assignmentRepository = assignmentRepository;
        _mapper = mapper;
    }
    public async Task CreateAssignment(CreateAssignmentDTO assignemnt)
    {
        var assignmentModel = _mapper.Map<Assignment>(assignemnt);

        assignmentModel.Status = AssignmentStatus.Todo;

        await _assignmentRepository.PutAssignment(assignmentModel);
    }

    public async Task DeleteAssignment(int id)
    {
        await _assignmentRepository.DeleteAssignment(id);
    }

    public async Task<IEnumerable<Assignment>> GetAllAssignments()
    {
        var assignments = await _assignmentRepository.GetAllAssignments();

        return assignments;
    }

    public async Task<IEnumerable<Assignment>> GetAssignementsByStatus(AssignmentStatus status)
    {
        var assignments = await _assignmentRepository
            .GetAssignmentsByStatus(status);

        return assignments;
    }

    public async Task<Assignment> GetAssignment(int id)
    {
        var assignment = await _assignmentRepository.GetAssignmentById(id);

        return assignment;
    }

    public async Task PatchAssignmentStatus(int id, AssignmentStatus status)
    {
        await _assignmentRepository.PatchAssignmentStatusById(id, status);
    }

    public async Task UpdateAssignment(int id, UpdateAssignmentDTO assignemnt)
    {
        var assignmentMaped = _mapper.Map<Assignment>(assignemnt);

        assignmentMaped.Id = id;

        await _assignmentRepository.UpdateAssignmentById(assignmentMaped);
    }
}
