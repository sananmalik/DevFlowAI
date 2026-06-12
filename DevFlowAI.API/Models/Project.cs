using System.ComponentModel.DataAnnotations;
namespace DevFlowAI.API.Models;

public class Project
{
    [Key]
    public int ProjectId { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string Status { get; set; } = "Pending";

    public DateTime CreatedAt { get; set; } = DateTime.Now;
}