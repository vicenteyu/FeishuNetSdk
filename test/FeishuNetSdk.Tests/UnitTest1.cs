using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using WebApiClientCore;
using WebApiClientCore.Attributes;
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

            Assert.IsTrue(m1.Length == 947);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var apiAction = new DefaultApiActionDescriptor(typeof(IFeishuTenantApi).GetMethod("GetEventV1OutboundIpAsync")!,
                typeof(IFeishuTenantApi));

            var context = new TestRequestContext(apiAction, string.Empty);

            Assert.IsNotNull(context);
        }
    }
}