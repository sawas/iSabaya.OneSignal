using Newtonsoft.Json;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSabaya.OneSignal.Devices
{
    public class DevicesViewResult
    {
        [DeserializeAs(Name = "total_count")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Result offset.Default is 0. Results are sorted by id;
        /// </summary>
        [DeserializeAs(Name = "offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// How many devices to return. Max is 300. Default is 300
        /// </summary>
        [DeserializeAs(Name = "limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// List of Devices in OpenSignalAPP
        /// </summary>
        [DeserializeAs(Name = "players")]
        [JsonExtensionData]
        public List<DeviceViewResult> Devices { get; set; }
    }
}
