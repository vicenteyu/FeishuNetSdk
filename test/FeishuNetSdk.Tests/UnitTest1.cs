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

            var context = new TestRequestContext(new DefaultApiActionDescriptor(typeof(IFeishuTenantApi).GetMethod("GetEventV1OutboundIpAsync")!,
                typeof(IFeishuTenantApi)), string.Empty);

            Assert.IsNotNull(context);
        }
    }
}