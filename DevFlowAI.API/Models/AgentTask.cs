using System.ComponentModel.DataAnnotations;
namespace DevFlowAI.API.Models;

public class AgentTask
{
    [Key]
    public int TaskId { get; set; }

    public int ProjectId { get; set; }

    public string AssignedAgent { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string Status { get; set; } = "Pending";

    public DateTime CreatedAt { get; set; } = DateTime.Now;
}