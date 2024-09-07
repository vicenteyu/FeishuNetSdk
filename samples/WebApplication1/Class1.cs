using FeishuNetSdk;
using FeishuNetSdk.Im.Dtos;

namespace WebApplication1
{
    public class Class1(IFeishuTenantApi tenantApi) : BackgroundService
    {
        protected async override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await tenantApi.PostImV1MessagesAsync("open_id", new FeishuNetSdk.Im.PostImV1MessagesBodyDto()
            {
                ReceiveId = "ou_b280b935d1db8201e410f309712b7cc1"
            }.SetContent(new ElementsCardV2Dto()
            {
                Header = new ElementsCardV2Dto.HeaderSuffix() { Title = new("Button-1") },
                Body = new ElementsCardV2Dto.BodySuffix()
                {
                    Elements = [new FormButtonElement(Name: Guid.NewGuid().ToString(), Text: new($"xxx1{DateTime.Now}"), Behaviors: [new CallbackBehaviors(new { key = "CallbackBehaviors" })])]
                }
            }));
        }
    }
}
