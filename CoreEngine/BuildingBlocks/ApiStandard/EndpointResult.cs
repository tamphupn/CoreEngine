using Newtonsoft.Json;
using System;
using System.Net;

namespace CoreEngine.BuildingBlocks.ApiStandard
{
    /// <summary>
    /// Defined model response metadata
    /// </summary>
    public partial class EndpointMetaData
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }
    }

    /// <summary>
    /// Defined model response
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public partial class EndpointResult<T>
    {
        public EndpointResult()
        {
        }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("metadata")]
        public EndpointMetaData Metadata { get; set; }

        [JsonProperty("data")]
        public T Data { get; set; }

        protected EndpointResult(HttpStatusCode _statusCode, T _data)
        {
            Code = Convert.ToString((int)_statusCode);
            Message = _statusCode.ToString();
            Data = _data;
            Metadata = new EndpointMetaData
            {
                Created = DateTime.UtcNow.ToString("o"),
                Modified = DateTime.UtcNow.ToString("o"),
            };
        }

        protected EndpointResult(T _data)
        {
            Code = "200";
            Message = "OK";
            Data = _data;
            Metadata = new EndpointMetaData
            {
                Created = DateTime.UtcNow.ToString("o"),
                Modified = DateTime.UtcNow.ToString("o"),
            };
        }
    }
}