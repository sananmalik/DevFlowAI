using Microsoft.AspNetCore.Mvc;
using DevFlowAI.API.DTOs;
using DevFlowAI.API.Services;

namespace DevFlowAI.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WorkflowController : ControllerBase
    {
        private readonly WorkflowService _workflowService;

        public WorkflowController(WorkflowService workflowService)
        {
            _workflowService = workflowService;
        }

        [HttpPost("start")]
        public async Task<IActionResult> StartWorkflow(ProjectRequestDto request)
        {
            var result = await _workflowService.RunWorkflow(
                request.Description);

            return Ok(result);
        }
    }
}