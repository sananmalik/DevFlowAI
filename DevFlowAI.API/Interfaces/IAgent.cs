namespace DevFlowAI.API.Interfaces;

public interface IAgent
{
    Task<string> ExecuteAsync(string context);
}