using Dto=Mena.Poc.Application.DtoModels;
using Mena.Poc.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using AutoMapper;

namespace Mena.Poc.Application.Service
{
    //public class UserService: IUserService
    //{
    //    private readonly IUserRepository _userRepository;
    //    private readonly IMapper _mapper;
    //    public UserService(IUserRepository userRepository)
    //    {
    //        _userRepository = userRepository;
    //    }
    //    public async Task<IEnumerable<Dto.User>> GetAllUsers() 
    //    {
    //        string SqlQuery = "";
    //        var result= await _userRepository.GetAllAsync(SqlQuery);
    //        List<Dto.User> user=_mapper.Map<List<Dto.User>>(result);
    //        return user;
    //    }
    //}
}
