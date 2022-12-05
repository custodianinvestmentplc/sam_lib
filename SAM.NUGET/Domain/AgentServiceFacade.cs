using SAM.NUGET.Domain.Dtos;
using SAM.NUGET.Domain.Managers;
using SAM.NUGET.Resources;
using SAM.NUGET.Services;
using System.Collections.Generic;

namespace SAM.NUGET.Domain
{
    public class AgentServiceFacade : IAgentServices
    {
        private readonly AgentServiceManager _agentServices;

        public AgentServiceFacade(string constring)
        {
            _agentServices = new AgentServiceManager(constring);
        }

        public List<SalesTeamMemberDto> GetAllAgents() => _agentServices.GetAllAgents();
        public AgentResource GetAgent(string agentcode) => _agentServices.GetAgent(agentcode);
        public List<OrcScenarioDto> GetOrcScenarios() => _agentServices.GetAllOrcScenarios();
        public OrcScenarioDetailResource GetOrcScenarioDetails(string scenarioId) => _agentServices.GetOrcScenarioDetails(scenarioId);

        public List<SalesTeamMemberDto> FindAgentByName(string searchKey, string Ref)
        {
            return _agentServices.FindAgentByName(searchKey, Ref);
        }
    }
}
