using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSabaya.OneSignal.Devices
{
    /// <summary>
    /// Implementation of BaseResource, used to help client add or edit device.
    /// </summary>
    public class DevicesRequest : WebAPIRequest, IDevicesRequest
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="apiKey">Your OneSignal API key</param>
        /// <param name="apiUri">API uri (https://onesignal.com/api/v1/notifications)</param>
        public DevicesRequest(string apiKey, string apiUri, ProxyOptions proxyOptions)
            : base(apiKey, apiUri, proxyOptions)
        {

        }

        /// <summary>
        /// Adds new device into OneSignal App.
        /// </summary>
        /// <param name="options">Here you can specify options used to add new device.</param>
        /// <returns>Result of device add operation.</returns>
        //public DeviceAddResult Add(DeviceAddOptions options)
        //{
        //    var restRequest = new RestRequest("players", Method.POST);

        //    restRequest.AddHeader("Authorization", string.Format("Basic {0}", base.ApiKey));

        //    restRequest.RequestFormat = DataFormat.Json;
        //    restRequest.JsonSerializer = new NewtonsoftJsonSerializer();
        //    restRequest.AddBody(options);

        //    var restResponse = base.RestClient.Execute<DeviceAddResult>(restRequest);

        //    if (restResponse.ErrorException != null)
        //    {
        //        throw restResponse.ErrorException;
        //    }

        //    return restResponse.Data;
        //}

        /// <summary>
        /// Edits existing device defined in OneSignal App.
        /// </summary>
        /// <param name="id">Id of the device</param>
        /// <param name="options">Options used to modify attributes of the device.</param>
        /// <exception cref="Exception"></exception>
        //public void Edit(string id, DeviceEditOptions options)
        //{
        //    RestRequest restRequest = new RestRequest("players/{id}", Method.PUT);

        //    restRequest.AddHeader("Authorization", string.Format("Basic {0}", base.ApiKey));

        //    restRequest.AddUrlSegment("id", id);

        //    restRequest.RequestFormat = DataFormat.Json;
        //    restRequest.JsonSerializer = new NewtonsoftJsonSerializer();
        //    restRequest.AddBody(options);

        //    IRestResponse restResponse = base.RestClient.Execute(restRequest);

        //    if (restResponse.ErrorException != null)
        //    {
        //        throw restResponse.ErrorException;
        //    }
        //}

        /// <summary>
        /// View existing device defined in OneSignal App.
        /// </summary>
        /// <param name="id">Id of the device</param>
        /// <param name="options">Options used to modify attributes of the device.</param>
        /// <exception cref="Exception"></exception>
        public DeviceViewResult View(DeviceViewOptions options)
        {
            var baseRequestPath = "players/{0}?app_id={1}";

            RestRequest restRequest = new RestRequest(string.Format(baseRequestPath, options.Id, options.AppId), Method.GET);

            restRequest.AddHeader("Authorization", string.Format("Basic {0}", base.ApiKey));

            restRequest.RequestFormat = DataFormat.Json;
            restRequest.JsonSerializer = new NewtonsoftJsonSerializer();

            var restResponse = base.RestClient.Execute<DeviceViewResult>(restRequest);

            if (restResponse.ErrorException != null)
            {
                throw restResponse.ErrorException;
            }

            return restResponse.Data;
        }

        /// <summary>
        /// View all existing device defined in OneSignal App.
        /// </summary>
        /// <param name="id">Id of the device</param>
        /// <param name="options">Options used to modify attributes of the device.</param>
        /// <exception cref="Exception"></exception>
        public DevicesViewResult ViewAll(DevicesViewOptions options)
        {
            var baseRequestPath = "players?app_id={0}&limit={1}&offset={2}";

            RestRequest restRequest = new RestRequest(string.Format(baseRequestPath, options.AppId, options.Limit, options.Offset), Method.GET);

            restRequest.AddHeader("Authorization", string.Format("Basic {0}", base.ApiKey));

            restRequest.RequestFormat = DataFormat.Json;
            restRequest.JsonSerializer = new NewtonsoftJsonSerializer();

            var restResponse = base.RestClient.Execute<DevicesViewResult>(restRequest);

            if (restResponse.ErrorException != null)
            {
                throw restResponse.ErrorException;
            }

            return restResponse.Data;
        }
    }
}
