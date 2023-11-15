using Microsoft.Extensions.DependencyInjection;
using WebApiClientCore;
using WebApiClientCore.Implementations;

namespace FeishuNetSdk.Tests
{
    [TestClass]
    public class UnitTest1
    {
        protected IServiceProvider provider;
        public UnitTest1()
        {
            var services = new ServiceCollection();
            provider = services.BuildServiceProvider();
        }

        [TestMethod]
        public void TestMethod1()
        {
            var m1 = HttpApi.FindApiMethods(typeof(IFeishuTenantApi));

            Assert.IsTrue(m1.Length > 0);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var api = typeof(IFeishuTenantApi);
            var method = api.GetMethod("GetEventV1OutboundIpAsync");
            Assert.IsNotNull(method);

            var action = new DefaultApiActionDescriptor(method, api);
            var context = new TestRequestContext(action);

            Assert.IsNotNull(context);
        }
    }
}