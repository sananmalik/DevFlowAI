using DevFlowAI.API.Agents;
using DevFlowAI.API.Data;
using Microsoft.EntityFrameworkCore;

namespace DevFlowAI.API.Services
{
    public class WorkflowService
    {
        private readonly ProductManagerAgent _pm;
        private readonly ArchitectAgent _architect;
        private readonly DeveloperAgent _developer;
        private readonly QAAgent _qa;
        private readonly ReleaseAgent _release;
        private readonly ApplicationDbContext _context;

        public WorkflowService(
               ProductManagerAgent pm,
               ArchitectAgent architect,
               DeveloperAgent developer,
               QAAgent qa,
               ReleaseAgent release,
               ApplicationDbContext context)
        {
               _pm = pm;
               _architect = architect;
               _developer = developer;
               _qa = qa;
               _release = release;
               _context = context;
        }

        public async Task<object> RunWorkflow(string projectDescription)
        {
            var pmOutput =
               await _pm.ExecuteAsync(projectDescription);

            var architectOutput =
                await _architect.ExecuteAsync(pmOutput);

            var developerOutput =
                await _developer.ExecuteAsync(architectOutput);

            var qaOutput =
                await _qa.ExecuteAsync(developerOutput);

            var releaseOutput =
                await _release.ExecuteAsync(qaOutput);

            return new
            {
                ProductManager = pmOutput,
                Architect = architectOutput,
                Developer = developerOutput,
                QA = qaOutput,
                Release = releaseOutput
            };
        }
    }
}