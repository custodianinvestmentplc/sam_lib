using System;

namespace SAM.NUGET.Domain.Dtos
{
    public class CpcProductDto
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
