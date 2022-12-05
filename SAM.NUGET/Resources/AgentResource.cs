using SAM.NUGET.Domain.Dtos;
using System.Collections.Generic;

namespace SAM.NUGET.Resources
{
    public class AgentResource
    {
        public AgentDogTagDto DogTag { get; set; }
        public List<OrcHierarchyNodeDto> OrcHierarchy { get; set; } = new List<OrcHierarchyNodeDto>();
    }
}
