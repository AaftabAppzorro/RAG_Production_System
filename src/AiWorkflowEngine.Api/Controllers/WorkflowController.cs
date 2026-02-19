
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AiWorkflowEngine.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WorkflowController : ControllerBase
{
    private readonly WorkflowService _service;

    public WorkflowController(WorkflowService service)
    {
        _service = service;
    }

    [Authorize(Roles = "Finance")]
    [HttpPost("execute")]
    public async Task<IActionResult> Execute([FromBody] string instruction)
    {
        var result = await _service.ExecuteAsync(instruction, User.Identity?.Name ?? "Unknown");
        return Ok(result);
    }
}
