using SAM.NUGET.Domain.Dtos;
using SAM.NUGET.Resources;
using System.Collections.Generic;

namespace SAM.NUGET.Services
{
    public interface IAgentServices
    {
        List<SalesTeamMemberDto> GetAllAgents();
        AgentResource GetAgent(string agentcode);
        List<OrcScenarioDto> GetOrcScenarios();
        OrcScenarioDetailResource GetOrcScenarioDetails(string scenarioId);
        List<SalesTeamMemberDto> FindAgentByName(string searchKey, string Ref);
    }
}
