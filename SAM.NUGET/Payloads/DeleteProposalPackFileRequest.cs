using System.Data;

namespace SAM.NUGET.Payloads
{
    public class DeleteProposalPackFileRequest
    {
        public string ProposalPackReferenceNbr { get; set; }
        public string proposalPackDocName { get; set; }
        public string proposalPackDocType { get; set; }
    }
}