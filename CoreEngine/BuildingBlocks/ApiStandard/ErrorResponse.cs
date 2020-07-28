using Newtonsoft.Json;

namespace CoreEngine.BuildingBlocks.ApiStandard
{
    /// <summary>
    /// Defined error response model
    /// </summary>
    public class ErrorResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("inner_message")]
        public string InnerMessage { get; set; }

        public ErrorResponse()
        {
        }

        public ErrorResponse(string _message, string _innerMessage)
        {
            Message = _message;
            InnerMessage = _innerMessage;
        }
    }
}