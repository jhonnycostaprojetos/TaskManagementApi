using TaskManagement.Domain.Validation;

namespace TaskManagement.Domain.Entities
{
    public class Project : BaseEntity
    {
        public string ProjectName { get; private set; }

        public int? UserId { get; private set; }
        public virtual User User { get; private set; }

        public TaskProject TaskProject { get; private set; }

        public Project()
        {

        }
        public Project(int projectId, string projectName, int? userId, DateTime? createdAt, DateTime? updateAt)
        {
            DomainExceptionValidation.When(projectId < 0, "Invalid Id value.");
            ValidateDomain(projectName);
            Id = projectId;
            ProjectName = projectName;
            UserId = userId;
            CreateAt = createdAt;
            UpdateAt = updateAt;

        }

        private void ValidateDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name.Name is required");

            DomainExceptionValidation.When(name.Length < 3, "Invalid name, too short, minimum 3 characters");

            ProjectName = name;
        }
    }
}
