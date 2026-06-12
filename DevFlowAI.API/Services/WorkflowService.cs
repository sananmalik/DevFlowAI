using DevFlowAI.API.Agents;

namespace DevFlowAI.API.Services
{
    public class WorkflowService
    {
        private readonly ProductManagerAgent _pm;
        private readonly ArchitectAgent _architect;

        public WorkflowService(
            ProductManagerAgent pm,
            ArchitectAgent architect)
        {
            _pm = pm;
            _architect = architect;
        }

        public async Task<object> RunWorkflow(string projectDescription)
        {
            var pmOutput =
                await _pm.ExecuteAsync(projectDescription);

            var architectOutput =
                await _architect.ExecuteAsync(pmOutput);

            return new
            {
                ProductManager = pmOutput,
                Architect = architectOutput
            };
        }
    }
}