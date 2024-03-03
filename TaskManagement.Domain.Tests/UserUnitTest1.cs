using FluentAssertions;
using TaskManagement.Domain.Entities;

namespace TaskManagement.Domain.Tests
{
    public class UserUnitTest1
    {
        [Fact(DisplayName ="Create User With Valid State")]
        public void CreatUser_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new User(Guid.NewGuid(), "NameUser", "Email", null, null );
            action.Should().NotThrow<TaskManagement.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Missing UserName Value")]
        public void CreatUser_MissingNameValue_DomainExceptionInvalidNameUser()
        {
            Action action = () => new User(Guid.NewGuid(), "", "Email", null, null);
            action.Should().Throw<TaskManagement.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name.Name is required");
        }

        [Fact(DisplayName = "Create With Null UserName Value")]
        public void CreatUser_WithNullNameValue_DomainExceptionInvalidNameUser()
        {
            Action action = () => new User(Guid.NewGuid(), null, "Email", null, null);
            action.Should().Throw<TaskManagement.Domain.Validation.DomainExceptionValidation>();
                
        }
    }
}