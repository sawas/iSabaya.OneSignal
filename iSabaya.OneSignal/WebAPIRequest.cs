using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace iSabaya.OneSignal
{
    /// <summary>
    /// Abstract class which helps easier implementation of new client resources.
    /// </summary>
    public abstract class WebAPIRequest
    {
        /// <summary>
        /// Rest client reference.
        /// </summary>
        protected RestClient RestClient { get; set; }

        /// <summary>
        /// Your OneSignal Api key.
        /// </summary>
        protected string ApiKey { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="apiKey">Your OneSignal API key</param>
        /// <param name="apiUri">API uri (https://onesignal.com/api/v1/notifications)</param>
        protected WebAPIRequest(string apiKey, string apiUri, ProxyOptions proxyOptions = null)
        {
            ApiKey = apiKey;
            RestClient = new RestClient(apiUri);

            if (null != proxyOptions)
            {
                WebProxy proxy = new WebProxy(proxyOptions.Url, true)
                {
                    Credentials = new NetworkCredential(proxyOptions.UserName, proxyOptions.Password)
                };
                RestClient.Proxy = proxy;
            }
        }
    }

    /// <summary>
    /// Web Api Client Proxy Options 
    /// </summary>
    public class ProxyOptions
    {
        /// <summary>
        /// Your Proxy Url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Your Proxy User
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Your Proxy Password
        /// </summary>
        public string Password { get; set; }
    }
}
