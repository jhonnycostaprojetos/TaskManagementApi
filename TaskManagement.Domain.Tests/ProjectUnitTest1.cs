using FluentAssertions;
using TaskManagement.Domain.Entities;

namespace TaskManagement.Domain.Tests
{
    public class ProjectUnitTest1
    {
        [Fact(DisplayName = "Create Project With Valid State")]
        public void CreatProject_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Project(1, "NameProject", 0, null, null);
            action.Should().NotThrow<TaskManagement.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact]
        public void CreatProject_NegativeIdValue_DomainExceptionInvalidId()
        {
            Action action = () => new Project(-1, "NameProject", 0, null, null);
            action.Should()
                .Throw<TaskManagement.Domain.Validation.DomainExceptionValidation>()
                 .WithMessage("Invalid Id value.");
        }

        [Fact]
        public void CreatProject_ShortNameValue_DomainExceptionShortName()
        {
            Action action = () => new Project(1, "Na", 0, null, null);
            action.Should()
                .Throw<TaskManagement.Domain.Validation.DomainExceptionValidation>()
                   .WithMessage("Invalid name, too short, minimum 3 characters");
        }
    }
}
