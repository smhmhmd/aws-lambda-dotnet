using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Amazon.Lambda.ApplicationLoadBalancerEvents
{    
    /// <summary>
    /// For response object for Lambda functions handling request from Application Load Balancer.
    /// https://docs.aws.amazon.com/elasticloadbalancing/latest/application/lambda-functions.html
    /// </summary>
    [DataContract]
    public class ApplicationLoadBalancerResponse
    {
        /// <summary>
        /// The HTTP status code for the request
        /// </summary>
        [DataMember(Name = "statusCode")]
        public int StatusCode { get; set; }
        
        /// <summary>
        /// The HTTP status description for the request
        /// </summary>
        [DataMember(Name = "statusDescription")]
        public string StatusDescription { get; set; }        

        /// <summary>
        /// The Http headers return in the response
        /// </summary>
        [DataMember(Name = "headers")]
        public IDictionary<string, IList<string>> Headers { get; set; }

        /// <summary>
        /// The response body
        /// </summary>
        [DataMember(Name = "body")]
        public string Body { get; set; }

        /// <summary>
        /// Flag indicating whether the body should be treated as a base64-encoded string
        /// </summary>
        [DataMember(Name = "isBase64Encoded")]
        public bool IsBase64Encoded { get; set; }        
    }
}