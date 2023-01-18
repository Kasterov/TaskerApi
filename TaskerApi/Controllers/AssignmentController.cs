using Microsoft.AspNetCore.Mvc;

namespace TaskerApi.Controllers;

[ApiController]
[Route("[controller]")]
public class AssignmentController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAllAssignment()
    {
        return Ok("GET");
    }

    [HttpPost]
    public async Task<IActionResult> CreateAssignment()
    {
        return Ok("POST");
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteAssignment()
    {
        return Ok("DELETE");
    }

    [HttpPut]
    public async Task<IActionResult> UpdateAssignment()
    {
        return Ok("PUT");
    }
}