using SAM.NUGET.Domain.Dtos;
using System.Collections.Generic;

namespace SAM.NUGET.Services
{
    public interface IGroupSynergyServices
    {
        List<GroupCustomerSearchResultDto> SearchGroupCustomerDatabase(string searchTerm);
        List<GroupCustomerSearchDetailsDto> GetCustomerSearchDetailsDtos(int fuzzyKey);
        List<GroupCustomerItemDto> FetchAllCustomers();
    }
}
