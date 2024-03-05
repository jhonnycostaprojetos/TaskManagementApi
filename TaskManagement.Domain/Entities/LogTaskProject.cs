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
        public int TaskProjectId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime? DueDate { get;  set; }
        public int? Status { get; set; }


        public LogTaskProject()
        {

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
