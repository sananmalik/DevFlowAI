using DevFlowAI.API.Interfaces;

namespace DevFlowAI.API.Agents
{
    public class DeveloperAgent : IAgent
    {
        public async Task<string> ExecuteAsync(string context)
        {
            await Task.Delay(1000);

            return $@"
Development Plan

Controllers:
- BooksController
- UsersController
- LoansController

Services:
- BookService
- UserService
- LoanService

Generated From:
{context}";
        }
    }
}