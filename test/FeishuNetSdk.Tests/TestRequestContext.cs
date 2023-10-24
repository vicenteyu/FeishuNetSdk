using Microsoft.Extensions.DependencyInjection;
using WebApiClientCore;
using WebApiClientCore.Implementations;

namespace FeishuNetSdk.Tests
{
    public class TestRequestContext : ApiRequestContext
    {
        /// <summary>
        /// 请求Api的上下文
        /// </summary>
        /// <param name="httpApi">httpApi代理类实例</param>
        /// <param name="httpApiConfig">关联的HttpApiConfig</param>
        /// <param name="apiActionDescriptor">关联的ApiActionDescriptor</param>
        /// <exception cref="ArgumentNullException"></exception>
        public TestRequestContext(ApiActionDescriptor apiActionDescriptor, params object[] args)
            : base(GetHttpContext(), apiActionDescriptor, args, new DefaultDataCollection())
        {
            this.HttpContext.ResponseMessage = new HttpResponseMessage(System.Net.HttpStatusCode.OK);
        }

        private static HttpContext GetHttpContext()
        {
            var services = new ServiceCollection();

            var requestServices = services.BuildServiceProvider();
            var options = new HttpApiOptions() { HttpHost = new Uri("https://open.feishu.cn/") };

            var httpClientContext = new HttpClientContext(new HttpClient(), requestServices, options, string.Empty);
            return new HttpContext(httpClientContext, new HttpApiRequestMessageImpl());
        }
    }
}
