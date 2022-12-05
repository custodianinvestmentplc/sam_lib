using System;
using System.Collections.Generic;
using SAM.NUGET.Domain.Dtos;
using SAM.NUGET.Models;

namespace SAM.NUGET.ViewModels
{
    public class IndexViewModel
    {
        public string ErrorTitle { get; set; } = null;
        public string ErrorDescription { get; set; } = null;
        public string ExceptionType { get; set; } = null;
        public string UserName { get; set; } = null;
        public string Module { get; set; } = null;
    }
}

