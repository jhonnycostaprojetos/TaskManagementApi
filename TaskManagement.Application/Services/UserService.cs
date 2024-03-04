using AutoMapper;
using TaskManagement.Application.DTOs;
using TaskManagement.Application.Interfaces;
using TaskManagement.Domain.Entities;
using TaskManagement.Domain.Interfaces;

namespace TaskManagement.Application.Services
{
    public class UserService : IUserService
    {
        private IRepository<User> _userRepository;
        private readonly IMapper _mapper;


        public UserService(IMapper mapper, IRepository<User> userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }
        public async Task Post(UserDTO userDto)
        {
            var userEntity = _mapper.Map<User>(userDto);
            await _userRepository.InsertAsync(userEntity);
        }

        public async Task<IEnumerable<UserDTO>> GetAll()
        {
            var listEntity = await _userRepository.SelectAsync();
            return _mapper.Map<IEnumerable<UserDTO>>(listEntity);
        }
    }

}
