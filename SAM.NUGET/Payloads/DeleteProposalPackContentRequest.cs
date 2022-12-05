using System.Data;

namespace SAM.NUGET.Payloads
{
    public class DeleteProposalPackContentRequest
    {
        public string ProposalPackReferenceNbr { get; set; }
        public decimal ProposalPackContentRowId { get; set; }
    }
}