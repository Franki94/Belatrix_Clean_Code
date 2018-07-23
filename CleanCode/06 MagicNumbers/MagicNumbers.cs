
namespace CleanCode.MagicNumbers
{
    public class MagicNumbers
    {
        public void ApproveDocument(StatusDocumentApprove status)
        {
            if (status == StatusDocumentApprove.Active)
            {
                // ...
            }
            else if (status == StatusDocumentApprove.Process)
            {
                // ...
            }
        }

        public void RejectDoument(string status)
        {
            switch (status)
            {
                case StatusDocumentReject.Waiting:
                    // ...
                    break;
                case StatusDocumentReject.Rejected:
                    // ...
                    break;
            }
        }
    }
    public static class StatusDocumentReject
    {
        public const string Waiting = "1";
        public const string Rejected = "2";
    }

    public enum StatusDocumentApprove
    {
        Active = 1,
        Process = 2,
    }        
}



