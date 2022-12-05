using System;

namespace SAM.NUGET.Domain.Dtos
{
    public class CpcFileDto
    {
        public string FileCode { get; set; }
        public string FileName { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
