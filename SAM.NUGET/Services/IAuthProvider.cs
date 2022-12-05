using SAM.NUGET.Models;

namespace SAM.NUGET.Services
{
    public interface IAuthProvider
    {
        string AcquireAdToken(string authcode);
        AzureAdUserInfo GetLoggedInUser(string accessToken);
    }
}
