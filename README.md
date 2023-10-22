# FeishuNetSdk
## 自建应用用法
### 配置
```csharp
builder.Services.AddHttpApi<IFeishuApi>();
builder.Services.AddHttpApi<IFeishuTenantApi>();
builder.Services.AddTokenProvider<IFeishuTenantApi>(async service =>
{
    var token = await service.GetService<IFeishuApi>()!
        .PostAuthV3TenantAccessTokenInternalAsync(
            new FeishuNetSdk.Auth.Spec.PostAuthV3TenantAccessTokenInternalBodyDto
            {
                AppId = "cli_a5bf8739dab8d00c",
                AppSecret = "vn7MjifCNm04dUlWBg6yWbijHvEpel6G"
            });
    return new TokenResult { Access_token = token.TenantAccessToken, Expires_in = token.Expire };
});
```

### 调用
```csharp
[Route("api/[controller]")]
[ApiController]
public class TestController : ControllerBase
{
    private readonly IFeishuTenantApi _feishuApi;

    public TestController(IFeishuTenantApi feishuApi)
    {
        _feishuApi = feishuApi;
    }

    [HttpGet("t2")]
    public async Task<IResult> GetT2Async()
    {
        var result2 = await _feishuApi.GetImV1ChatsAsync();
        return Results.Json(result2);
    }
}
```