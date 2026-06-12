using System.ComponentModel.DataAnnotations;
namespace DevFlowAI.API.Models
{
    public class AgentExecution
    {
        [Key]
        public int ExecutionId { get; set; }  // Primary Key

        public int ProjectId { get; set; }

        public string AgentName { get; set; } = string.Empty;

        public string Result { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}