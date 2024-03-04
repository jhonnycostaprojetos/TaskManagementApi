using TaskManagement.Application.DTOs.User;

namespace TaskManagement.Application.Interfaces
{
    public interface IUserService
    {
        Task<UserDtoCreateResponse> Post(UserDTOCreate userDto);
        Task<IEnumerable<UserDTO>> GetAll();
        Task<UserDtoCreateResponse> Get(int id);
    }
}
