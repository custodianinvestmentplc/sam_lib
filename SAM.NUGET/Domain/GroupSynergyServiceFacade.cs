using SAM.NUGET.Domain.Dtos;
using SAM.NUGET.Domain.Managers;
using SAM.NUGET.Services;
using System.Collections.Generic;

namespace SAM.NUGET.Domain
{
    public class GroupSynergyServiceFacade : IGroupSynergyServices
    {
        private readonly GroupServiceManager _groupManager;
        public GroupSynergyServiceFacade(string connectionstring)
        {
            _groupManager = new GroupServiceManager(connectionstring);
        }

        public List<GroupCustomerSearchDetailsDto> GetCustomerSearchDetailsDtos(int fuzzyKey)
        {
            return _groupManager.GetCustomerByFuzzyKey(fuzzyKey);
        }

        public List<GroupCustomerSearchResultDto> SearchGroupCustomerDatabase(string searchTerm)
        {
            return _groupManager.SearchCustomerDatabase(searchTerm);
        }

        public List<GroupCustomerItemDto> FetchAllCustomers()
        {
            return _groupManager.FetchAllCustomers();
        }
    }
}
