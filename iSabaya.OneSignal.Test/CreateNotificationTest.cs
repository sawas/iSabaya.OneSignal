using System;
using System.Collections.Generic;
using iSabaya.OneSignal.Notifications;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace iSabaya.OneSignal.Test
{
    [TestClass]
    public class CreateNotificationTest
    {
        [TestMethod]
        public void CreateSimpleNotificationTest()
        {
            var client = new OneSignalClient("NGEwMGZmMjItY2NkNy0xMWUzLTk5ZDUtMDAwYzI5NDBlNjJj");

            var options = new NotificationCreateOptions();

            options.AppId = new Guid("92911750-242d-4260-9e00-9d9034f139ce");
            options.IncludedSegments = new List<string> { "All" };
            //options.IncludePlayerIds = new List<string>
            //{
            //    "81a9b7d9-6ee0-47f8-9045-318df82b1ba1"
            //};
            options.Headings.Add(LanguageCodes.English, "✴️ เริ่มแล้ว Promotion ฉลองเปิดระบบ (beta test) ‼️");
            options.Contents.Add(LanguageCodes.English, "ด่วน ❗ เพียง 12 ทีมแรกเท่านั้น ► ชวนเพื่อนๆ รวมเป็นทีมเดียวกันตั้งแต่ 5 คนขึ้นไป รับทันทีทีมละ 5,000 Points");
            options.Url = "http://the10threalm.com/";
            client.Notifications.Create(options);
        }
    }
}
