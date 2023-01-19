using BLL.DTOs;
using BLL.Interfaces;
using DAL.Enums;
using Microsoft.AspNetCore.Mvc;

namespace TaskerApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AssignmentController : ControllerBase
{
    private readonly IAssignmentService _assignmentService;

    public AssignmentController(IAssignmentService assignmentService)
    {
        _assignmentService = assignmentService;
    }

    [HttpGet("assignment/{id}")]
    public async Task<IActionResult> GetAssignmentById([FromRoute] int id)
    {
        var assignment = await _assignmentService.GetAssignment(id);

        return Ok(assignment);
    }

    [HttpGet("assignments")]
    public async Task<IActionResult> GetAllAssignments()
    {
        var assignments = await _assignmentService.GetAllAssignments();

        return Ok(assignments);
    }

    [HttpPost("assignment")]
    public async Task<IActionResult> CreateAssignment(
        [FromBody] CreateAssignmentDTO assignmentDTO)
    {
        await _assignmentService.CreateAssignment(assignmentDTO);

        return Ok("POST");
    }

    [HttpDelete("assignment/{id}")]
    public async Task<IActionResult> DeleteAssignment([FromRoute] int id)
    {
        await _assignmentService.DeleteAssignment(id);

        return Ok("DELETE");
    }

    [HttpPut("assignment/{id}")]
    public async Task<IActionResult> UpdateAssignment([FromRoute] int id,
        [FromBody] UpdateAssignmentDTO assignmentDTO)
    {
        await _assignmentService.UpdateAssignment(id, assignmentDTO);

        return Ok("PUT");
    }

    [HttpPatch("assignment/{id}/{status}")]
    public async Task<IActionResult> UpdateAssignmentStatus([FromRoute] AssignmentStatus status,
        [FromRoute] int id)
    {
        await _assignmentService.PatchAssignmentStatus(id, status);

        return Ok("PUTCH");
    }

    [HttpGet("assignments/{status}")]
    public async Task<IActionResult> GetAssignmentsByStatus([FromRoute] AssignmentStatus status)
    {
        var assignments = await _assignmentService.GetAssignementsByStatus(status);

        return Ok(assignments);
    }
}