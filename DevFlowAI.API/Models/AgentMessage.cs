using System.ComponentModel.DataAnnotations;
namespace DevFlowAI.API.Models;

public class AgentMessage
{
    [Key]
    public int MessageId { get; set; }

    public int ProjectId { get; set; }

    public string AgentName { get; set; } = string.Empty;

    public string MessageType { get; set; } = string.Empty;

    public string Content { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; } = DateTime.Now;
}