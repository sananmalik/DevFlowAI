using DevFlowAI.API.Interfaces;

namespace DevFlowAI.API.Agents
{
    public class ArchitectAgent : IAgent
    {
        public async Task<string> ExecuteAsync(string context)
        {
            await Task.Delay(1000);

            return $@"
Architecture Design

Backend: ASP.NET Core
Database: SQL Server

Recommended Tables:
- Users
- Products
- Orders

Based On:
{context}
";
        }
    }
}