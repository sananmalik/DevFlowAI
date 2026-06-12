using DevFlowAI.API.Interfaces;

namespace DevFlowAI.API.Agents
{
    public class ProductManagerAgent : IAgent
    {
        public async Task<string> ExecuteAsync(string context)
        {
            await Task.Delay(100);

            return $"Requirements generated for: {context}";
        }
    }
}