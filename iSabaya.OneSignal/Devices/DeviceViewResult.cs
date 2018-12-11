using iSabaya.OneSignal.Notifications;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSabaya.OneSignal.Devices
{
    public class DeviceViewResult
    {
        /// <summary>
        /// Push notification identifier from Google or Apple. For Apple push identifiers, you must strip all non alphanumeric characters. 
        /// Example: ce777617da7f548fe7a9ab6febb56
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Number of times the user has played the game, defaults to 1
        /// </summary>
        [JsonProperty("session_count")]
        public int? SessionCount { get; set; }

        /// <summary>
        /// Language code. Typically lower case two letters, except for Chinese where it must be one of "zh-Hans" or "zh-Hant". Example: en
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; set; }

        /// <summary>
        /// Number of seconds away from UTC. Example: -28800
        /// </summary>
        [JsonProperty("timezone")]
        public int? Timezone { get; set; }

        /// <summary>
        /// Version of the app.
        /// </summary>
        [JsonProperty("game_version")]
        public string GameVersion { get; set; }

        /// <summary>
        /// Device operating system version. Example: 7.0.4
        /// </summary>
        [JsonProperty("device_os")]
        public string DeviceOs { get; set; }

        /// <summary>
        /// 0 = iOS
        /// 1 = Android
        /// 2 = Amazon
        /// 3 = WindowsPhone(MPNS)
        /// 4 = ChromeApp
        /// 5 = ChromeWebsite
        /// 6 = WindowsPhone(WNS)
        /// 7 = Safari
        /// 8 = Firefox
        /// 9 = Mac OS X
        /// </summary>
        [JsonProperty("device_type")]
        public DeviceTypeEnum? DeviceType { get; set; }

        /// <summary>
        /// Device make and model. Example: iPhone5,1
        /// </summary>
        [JsonProperty("device_model")]
        public string DeviceModel { get; set; }

        /// <summary>
        /// Android = The Advertising Id
        /// iOS = The identifierForVendor
        /// WP8.0 = The DeviceUniqueId
        /// WP8.1 = The AdvertisingId
        /// </summary>
        [JsonProperty("ad_id")]
        public string AdId { get; set; }

        [JsonProperty("tags")]
        [JsonExtensionData]
        public Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Unixtime when the player was last active
        /// </summary>
        [JsonProperty("last_active")]
        [JsonConverter(typeof(UnixDateTimeJsonConverter))]
        public int? LastActive { get; set; }

        [JsonProperty("amount_spent")]
        public double? AmountSpent { get; set; }

        [JsonProperty("created_at")]
        [JsonConverter(typeof(UnixDateTimeJsonConverter))]
        public int? CreatedAt { get; set; }

        [JsonProperty("invalid_identifier")]
        public bool? InvalidIdentifier { get; set; }

        [JsonProperty("badge_count")]
        public int? BadgeCount { get; set; }

        [JsonProperty("external_user_id")]
        public string ExternalUserId { get; set; }
    }
}
