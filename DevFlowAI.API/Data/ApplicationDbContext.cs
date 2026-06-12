using Microsoft.EntityFrameworkCore;
using DevFlowAI.API.Models;

namespace DevFlowAI.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }

        public DbSet<AgentMessage> AgentMessages { get; set; }

        public DbSet<AgentTask> AgentTasks { get; set; }

        public DbSet<AgentExecution> AgentExecutions { get; set; }
    }
}