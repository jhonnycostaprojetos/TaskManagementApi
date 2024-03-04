namespace TaskManagement.Application.DTOs.User
{
    public class UserDtoCreateResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
