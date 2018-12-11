using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSabaya.OneSignal.Notifications
{
    /// <summary>
    /// Class used to describe android background layout of the notification message displayed in device.
    /// </summary>
    public class AndroidBackgroundLayoutField
    {
        /// <summary>
        /// Background image.
        /// </summary>
        [JsonProperty("image")]
        public string Image { get; set; }

        /// <summary>
        /// Background heading color.
        /// </summary>
        [JsonProperty("headings_color")]
        public string HeadingsColor { get; set; }

        /// <summary>
        /// Background content color.
        /// </summary>
        [JsonProperty("contents_color")]
        public string ContentsColor { get; set; }
    }
}
