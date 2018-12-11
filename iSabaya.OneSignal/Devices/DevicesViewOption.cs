using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSabaya.OneSignal.Devices
{
    public class DevicesViewOptions
    {
        /// <summary><br/>
        /// Your OneSignal application ID, which can be found on our dashboard at onesignal.com under App Settings > Keys &amp; IDs. <br/>
        /// It is a UUID and looks similar to 8250eaf6-1a58-489e-b136-7c74a864b434.<br/>
        /// </summary>
        [JsonProperty("app_id")]
        public Guid AppId { get; set; }

        /// <summary>
        /// Result offset.Default is 0. Results are sorted by id;
        /// </summary>
        [JsonProperty("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// How many devices to return. Max is 300. Default is 300
        /// </summary>
        [JsonProperty("limit")]
        public int? Limit { get; set; }
    }
}
