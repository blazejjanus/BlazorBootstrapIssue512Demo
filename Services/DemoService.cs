using BlazorBootstrapIssue512Demo.Services.Interfaces;

namespace BlazorBootstrapIssue512Demo.Services {
    public class DemoService:IDemoService {
        public APIResponse GetFailure() {
            return new APIResponse {
                StatusCode = System.Net.HttpStatusCode.InternalServerError,
                StatusMessage = "Example of an error",
            };
        }

        public APIResponse GetSuccess() {
            return new APIResponse {
                StatusCode = System.Net.HttpStatusCode.OK,
                Content = "This is a content of the service response"
            };
        }
    }
}
