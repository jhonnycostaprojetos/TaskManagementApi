using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Domain.Enums;

namespace TaskManagement.Domain.Entities
{
    public class LogTaskProject : BaseEntity
    {
        public int TaskProjectId { get; private set; }
        public string? Title { get; private set; }
        public string? Description { get; private set; }
        public DateTime? DueDate { get; set; }
        public int? Status { get; private set; }
        public string TaskComment { get; private set; }
        public int UserId { get; private set; }


        public LogTaskProject()
        {

        }

        public LogTaskProject(int taskprojectId, string comment, int userID)
        {
            TaskProjectId = taskprojectId;
            TaskComment = comment;
            UserId = userID;
        }

        public LogTaskProject(int taskprojectId, string title, string description, DateTime dueDate, int status)
        {
            TaskProjectId = taskprojectId;
            Title = title;
            Description = description;
            DueDate = dueDate;
            Status = status;

        }
    }
}
