using SAM.NUGET.Domain.Managers;
using SAM.NUGET.Resources;
using SAM.NUGET.Services;
using System.Collections.Generic;

namespace SAM.NUGET.Domain
{
    public class ReportServiceFacade : IReportService
    {
        private readonly ReportServiceManager _reportManager;

        public ReportServiceFacade(string connstring)
        {
            _reportManager = new ReportServiceManager(connstring);
        }

        public List<ReportItemResource> GetReportByModuleId(int moduleId, string userEmail)
        {
            return _reportManager.GetReportByModuleId(moduleId, userEmail);
        }

        public List<ReportModuleResource> GetUserReportModules(string userName)
        {
            return _reportManager.GetUserReportModules(userName);
        }
    }
}
