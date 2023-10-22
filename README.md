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