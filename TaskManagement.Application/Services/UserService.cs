using AutoMapper;
using TaskManagement.Application.DTOs.User;
using TaskManagement.Application.Interfaces;
using TaskManagement.Domain.Entities;
using TaskManagement.Domain.Interfaces;

namespace TaskManagement.Application.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        private readonly IMapper _mapper;


        public UserService(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }
        public async Task<UserDtoCreateResponse> Post(UserDTOCreate userDto)
        {
            var userEntity = _mapper.Map<User>(userDto);
            var result = await _userRepository.InsertAsync(userEntity);

            return _mapper.Map<UserDtoCreateResponse>(result);
        }

        public async Task<IEnumerable<UserDTO>> GetAll()
        {
            var listEntity = await _userRepository.GetAll();
            return _mapper.Map<IEnumerable<UserDTO>>(listEntity);
        }

        public async Task<UserDtoCreateResponse> Get(int id)
        {
            var entity = await _userRepository.Get(id);
            return _mapper.Map<UserDtoCreateResponse>(entity);
        }
    }

}
