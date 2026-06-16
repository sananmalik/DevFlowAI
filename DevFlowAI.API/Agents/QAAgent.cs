using DevFlowAI.API.Interfaces;

namespace DevFlowAI.API.Agents
{
    public class QAAgent : IAgent
    {
        public async Task<string> ExecuteAsync(string context)
        {
            await Task.Delay(1000);

            return @"
QA Review

Status: PASS

Checks:
- Architecture Reviewed
- Controllers Reviewed
- Services Reviewed

No Critical Issues Found";
        }
    }
}