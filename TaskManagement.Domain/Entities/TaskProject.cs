using TaskManagement.Domain.Enums;
using TaskManagement.Domain.Validation;

namespace TaskManagement.Domain.Entities
{
    public sealed class TaskProject : BaseEntity
    {
        public int ProjectId { get; private set; }        
        public Project Project { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime DueDate { get; private set; }
        public StatusTask Status { get; private set; }
        public TaskPriority Priority { get; private set; }
        public IEnumerable<Comment> Comments { get; private set; }

        public TaskProject()
        {

        }

        public TaskProject(string description)
        {
            Description = description;
        }

        public TaskProject(int id, int projectId, string title, string description, DateTime dueDate, DateTime? createdAt, DateTime? updateAt)
        {
            ValidateDomain(title);
            Id = id;
            ProjectId = projectId;
            Title = title;
            Description = description;
            DueDate = dueDate;
            CreateAt = createdAt;
            UpdateAt = updateAt;

        }

        private void ValidateDomain(string title)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(title), "Invalid name.Name is required");

            Title = title;
        }
    }
}
