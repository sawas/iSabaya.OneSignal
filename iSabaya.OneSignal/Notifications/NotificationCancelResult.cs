using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSabaya.OneSignal.Notifications
{
    /// <summary>
    /// Result of notification cancel operation.
    /// </summary>
    public class NotificationCancelResult
    {
        /// <summary>
        /// Returns whether the message was canceled or not
        /// {'success': "true"}
        /// </summary>
        [DeserializeAs(Name = "success")]
        public string Success { get; set; }
    }
}
