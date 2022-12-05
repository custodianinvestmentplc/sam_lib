using System;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Mime;
using System.Xml.Linq;

namespace SAM.NUGET.Models
{
    public class SupportingDocPayload
    {
        public string ReferenceNbr { get; set; }
        public string UserEmail { get; set; }
        public string ContentTypeCode { get; set; }
        public string DocType { get; set; }
        public IFormFileCollection Data { get; set; }
    }
}