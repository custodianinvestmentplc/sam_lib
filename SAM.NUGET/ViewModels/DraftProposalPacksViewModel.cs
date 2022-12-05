using System;
using System.Collections.Generic;
using SAM.NUGET.Domain.Dtos;
using SAM.NUGET.Models;

namespace SAM.NUGET.ViewModels
{
    public class DraftProposalPacksViewModel
    {
        public List<CpcProposalPack> CpcProposalPackModel { get; set; } = new List<CpcProposalPack>();
        public string UserEmail { get; set; }
        public string ErrorDescription { get; set; } = null;
        public string ExceptionType { get; set; } = null;
    }
}

