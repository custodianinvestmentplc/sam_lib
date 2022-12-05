using SAM.NUGET.Domain.Dtos;
using SAM.NUGET.Domain.Managers;
using SAM.NUGET.Services;
using System.Collections.Generic;

namespace SAM.NUGET.Domain
{
    public class UserServiceFacade : IUserServices
    {
        private readonly string _connectionString;
        private readonly UserServiceManager _userManager;

        public UserServiceFacade(string constring)
        {
            _connectionString = constring;
            _userManager = new UserServiceManager(constring);
        }

        public List<UserApplicationRegisterDto> GetUserApplicationModules(string userEmail)
        {
            return _userManager.GetApplicationAssignedToUser(userEmail);
        }

        public UserRegisterDto GetUserByEmail(string email)
        {
            return _userManager.GetUserByEmail(email);
        }
    }
}
