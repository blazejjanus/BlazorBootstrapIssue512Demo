using System.Net;

namespace BlazorBootstrapIssue512Demo {
    /// <summary>
    /// Class for encapsulating services responses. Note this is only a simplified example.
    /// </summary>
    public class APIResponse {
        public string? Content { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public string? StatusMessage { get; set; }
        public bool Success => (int)StatusCode >= 200 && (int)StatusCode < 300;
        
        public string GetStatusString() {
            string result = StatusCode.ToString();
            if(!string.IsNullOrEmpty(StatusMessage)) {
                result += ": " + StatusMessage;
            }
            return result;
        }
    }
}
