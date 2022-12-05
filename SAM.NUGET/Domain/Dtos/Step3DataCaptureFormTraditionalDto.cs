﻿using System;

namespace SAM.NUGET.Domain.Dtos
{
    public class Step3DataCaptureFormTraditionalDto
    {
		public string MeansOfIdentification { get; set; }
		public string MeansOfidentificationOthers { get; set; }
		public string IdentifiationNbr { get; set; }
		public string IdCountryOfIssue { get; set; }
		public string IdCountryOfIssueOthers { get; set; }
		public string IdIssuingAuthrity { get; set; }
		public DateTime IdIssueDate { get; set; }
		public DateTime IdExpiryDate { get; set; }
		public string ResidentPermitNbr { get; set; }
		public string ReferenceNbr { get; set; }
		public string ContentTypeCode { get; set; }
	}
}