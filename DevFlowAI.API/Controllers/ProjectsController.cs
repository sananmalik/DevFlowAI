using DevFlowAI.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DevFlowAI.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProjectsController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public ProjectsController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet("{projectId}/messages")]
    public async Task<IActionResult> GetMessages(int projectId)
    {
        var messages = await _context.AgentMessages
            .Where(x => x.ProjectId == projectId)
            .OrderBy(x => x.CreatedAt)
            .ToListAsync();

        return Ok(messages);
    }
}