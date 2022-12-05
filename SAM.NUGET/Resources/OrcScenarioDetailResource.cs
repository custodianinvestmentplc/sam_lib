using SAM.NUGET.Domain.Dtos;
using System.Collections.Generic;

namespace SAM.NUGET.Resources
{
    public class OrcScenarioDetailResource
    {
        public string OrcScenarioId { get; set; }
        public List<OrcScenarioProductDto> OrcScenarioProducts { get; set; } = new List<OrcScenarioProductDto>();
        public List<OrcScenarioRateItemDto> OrcScenarioRateItems { get; set; } = new List<OrcScenarioRateItemDto>();
    }
}
