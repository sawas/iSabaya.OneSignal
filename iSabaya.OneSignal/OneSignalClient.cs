using iSabaya.OneSignal.Devices;
using iSabaya.OneSignal.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace iSabaya.OneSignal
{
    // <summary>
    /// OneSignal client 
    /// </summary>
    public class OneSignalClient : IOneSignalClient
    {
        /// <summary>
        /// Device resources.
        /// </summary>
        public IDevicesRequest Devices { get; private set; }

        /// <summary>
        /// Notification resources.
        /// </summary>
        public INotificationsRequest Notifications { get; private set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="apiKey">Your OneSignal API key</param>
        /// <param name="apiUri">API uri (default is "https://onesignal.com/api/v1")</param>
        public OneSignalClient(string apiKey,
            string apiUri = "https://onesignal.com/api/v1",
            ProxyOptions ProxyOptions = null)
        {
            this.Devices = new DevicesRequest(apiKey, apiUri, ProxyOptions);
            this.Notifications = new NotificationsRequest(apiKey, apiUri, ProxyOptions);
        }
    }

}
