using TaskManagement.Application.DTOs;

namespace TaskManagement.Application.Interfaces
{
    public interface IUserService
    {
        Task Post(UserDTO userDto);
        Task<IEnumerable<UserDTO>> GetAll();
    }
}
