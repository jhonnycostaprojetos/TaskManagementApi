﻿using TaskManagement.Domain.Enums;
using TaskManagement.Domain.Validation;

namespace TaskManagement.Domain.Entities
{
    public sealed class User : BaseEntity
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public UserProfile Profile { get; private set; }
        public IEnumerable<Project> Projects { get; private set; }

        public User() { }
        public User(int id)
        {
            Id = id;
        }

        public User(int id, UserProfile idProfile, string name, string? email, DateTime? createdAt, DateTime? updateAt)
        {
            ValidateDomain(name);
            Id = id;
            Profile = idProfile;
            Name = name;
            Email = email;
            CreateAt = createdAt;
            UpdateAt = updateAt;
        }

        private void ValidateDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name.Name is required");

            Name = name;
        }
    }
}
