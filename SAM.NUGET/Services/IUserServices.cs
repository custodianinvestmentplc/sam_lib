using SAM.NUGET.Domain.Dtos;
using System.Collections.Generic;

namespace SAM.NUGET.Services
{
    public interface IUserServices
    {
        List<UserApplicationRegisterDto> GetUserApplicationModules(string userEmail);
        UserRegisterDto GetUserByEmail(string email);
    }
}
