using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSabaya.OneSignal.Notifications
{
    /// <summary>
    /// Result of notification create operation.
    /// </summary>
    public class NotificationCreateResult
    {
        /// <summary>
        /// Returns the number of recepients who received the message.
        /// </summary>
        [DeserializeAs(Name = "recipients")]
        public int Recipients { get; set; }

        /// <summary>
        /// Returns the id of the result.
        /// </summary>
        [DeserializeAs(Name = "id")]
        public string Id { get; set; }
    }
}
