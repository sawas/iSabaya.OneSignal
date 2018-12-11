using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSabaya.OneSignal.Devices
{
    public class DeviceViewOptions
    {
        /// <summary><br/>
        /// Your OneSignal application ID, which can be found on our dashboard at onesignal.com under App Settings > Keys &amp; IDs. <br/>
        /// It is a UUID and looks similar to 8250eaf6-1a58-489e-b136-7c74a864b434.<br/>
        /// </summary>
        [JsonProperty("app_id")]
        public Guid AppId { get; set; }

        /// <summary><br/>
        /// Player's OneSignal ID
        /// </summary>
        [JsonProperty("id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Email - Only required if you have enabled Identity Verification and device_type is email (11).
        /// </summary>
        [JsonProperty("email_auth_hash")]
        public string EmailAuthHash { get; set; }
    }
}
