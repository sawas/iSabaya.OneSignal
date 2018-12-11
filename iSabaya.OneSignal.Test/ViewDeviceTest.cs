using System;
using iSabaya.OneSignal.Devices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace iSabaya.OneSignal.Test
{
    [TestClass]
    public class ViewDeviceTest
    {
        [TestMethod]
        public void ViewSomeDeviceTest()
        {
            var client = new OneSignalClient("NGEwMGZmMjItY2NkNy0xMWUzLTk5ZDUtMDAwYzI5NDBlNjJj");

            var options = new DeviceViewOptions();
            options.AppId = new Guid("92911750-242d-4260-9e00-9d9034f139ce");
            options.Id = new Guid("2ea3339c-3113-4780-a2ce-524ea7d67651");

            var data = client.Devices.View(options);
            
        }

        [TestMethod]
        public void ViewAllDeviceTest()
        {
            var client = new OneSignalClient("NGEwMGZmMjItY2NkNy0xMWUzLTk5ZDUtMDAwYzI5NDBlNjJj");

            var options = new DevicesViewOptions();
            options.AppId = new Guid("92911750-242d-4260-9e00-9d9034f139ce");

            var data = client.Devices.ViewAll(options);

        }
    }
}
