using SAM.NUGET.Resources;
using System.Collections.Generic;

namespace SAM.NUGET.Services
{
    public interface IReportService
    {
        List<ReportModuleResource> GetUserReportModules(string userName);
        List<ReportItemResource> GetReportByModuleId(int moduleId, string userEmail);
    }
}
