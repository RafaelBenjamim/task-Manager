using TaskManager.Enums;

namespace TaskManager.Models.Entitys
{
    public class TaskEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime completedDate { get; set; }
        public ETaskStatus Status { get; set; } = 0;
        public int UserId { get; set; }
        public UserEntity User { get; set; }

    }
}
