using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSabaya.OneSignal.Notifications
{
    /// <summary>
    /// API Documentation: https://documentation.onesignal.com/docs/notifications-cancel-notification
    /// </summary>
    public class NotificationCancelOptions
    {
        /// <summary>
        /// id  String  Required Notification id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// app_id  String  Required App id
        /// </summary>
        [JsonProperty("app_id")]
        public string AppId { get; set; }
    }
}
