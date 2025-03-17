using Microsoft.EntityFrameworkCore;
using TaskManager.Models.Entitys;

namespace TaskManager.Infrastruct.Context
{
    public class TaskManagerContext : DbContext
    {
        public TaskManagerContext(DbContextOptions<TaskManagerContext> options) : base(options) 
        {

        }

        public DbSet<TaskEntity> Tasks { get; set; }
        public DbSet<UserEntity> Users { get; set; }
    }
}
