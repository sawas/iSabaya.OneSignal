using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSabaya.OneSignal.Notifications
{
    /// <summary>
    /// Class used to describe web button.
    /// </summary>
    public class WebButtonField
    {
        /// <summary>
        /// Web button ID. This is required field.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Web button text.
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// Web button icon.
        /// </summary>
        [JsonProperty("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// Web button url.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
