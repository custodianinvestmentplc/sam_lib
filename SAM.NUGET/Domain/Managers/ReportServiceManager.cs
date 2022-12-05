using SAM.NUGET.Domain.Dtos;
using SAM.NUGET.Domain.Managers.Helpers;
using SAM.NUGET.Resources;
using System.Collections.Generic;

namespace SAM.NUGET.Domain.Managers
{
    public class ReportServiceManager
    {
        private readonly string _connectionString;

        public ReportServiceManager(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<ReportModuleResource> GetUserReportModules(string useremail)
        {
            var data = new List<ReportModuleResource>();

            using var db = DatabaseHelper.OpenDatabase(_connectionString);
            var lst = ReportHelper.GetReportModuleByUserEmail(db, useremail);

            if (lst != null && lst.Count > 0)
            {
                foreach (var item in lst)
                {
                    data.Add(new ReportModuleResource
                    {
                        DisplayName = item.DisplayName,
                        Id = item.Id,
                        IdName = item.IdName,
                        UrlSegmentName = item.UrlSegmentName
                    });
                }
            }

            return data;
        }

        public List<ReportItemResource> GetReportByModuleId(int moduleId, string userEmail)
        {
            var data = new List<ReportItemResource>();

            using var db = DatabaseHelper.OpenDatabase(_connectionString);
            var lst = ReportHelper.GetReportItemByModuleId(db, moduleId, userEmail);

            if (lst != null && lst.Count > 0)
            {
                foreach (var item in lst)
                {
                    data.Add(new ReportItemResource
                    {
                        DisplayName = item.DisplayName,
                        Id = item.Id,
                        ClientRouteAttribute = item.ClientRouteAttribute,
                        ModuleId = item.ModuleId
                    });
                }
            }

            return data;
        }
    }
}
