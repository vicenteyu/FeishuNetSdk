# FeishuNetSdk

飞书开放平台网址：[https://open.feishu.cn/](https://open.feishu.cn/)

## 自建应用用法

### [安装Nuget包](https://www.nuget.org/packages/FeishuNetSdk/)

### 依赖注册
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

### 方法调用
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

### 接口重载/覆盖
1. 新建API，继承于IFeishuTenantApi。
1. 使用重载/覆盖方法

**如果要覆盖方法，比如是在保持参数完全一致的情况下，修改http地址，需要在方法前加 `new` （参数不一致是重载，重载不用加`new` ），然后将新地址更换到属性上。更换http方法、返回参数及其他属性也是同理。**
```csharp
public interface INewApi : IFeishuTenantApi
{
    [OAuthToken, HttpGet("/open-apis/event/v1/outbound_ip1")]
    new System.Threading.Tasks.Task<HttpResponseMessage> GetEventV1OutboundIpAsync();
}
```

### **新增**依赖注册
```csharp
builder.Services.AddHttpApi<INewApi>();
```

### **修改**方法调用
```csharp
[Route("api/[controller]")]
[ApiController]
public class TestController : ControllerBase
{
    private readonly INewApi _feishuApi; //此处更改为新的API：INewApi
    public TestController(INewApi feishuApi)
    {
        _feishuApi = feishuApi;
    }

    [HttpGet("t2")]
    public async Task<IResult> GetT2Async()
    {
        var result2 = await _feishuApi.GetEventV1OutboundIpAsync();
        return Results.Json(result2);
    }
}
```

### 启用`状态异常错误`
默认：关闭
飞书接口在返回结果异常时，同时会返回状态异常。状态异常通常无法实质判断原因，具体原因会在返回结果中提示。所以接口默认忽略状态异常，开启方法如下：
1. 新建API，继承于IFeishuTenantApi。
1. 使用属性 `IgnoreStatusExceptionFilter` 并设置属性 `Enable` 为 `false` ，意为停用忽略，即启用异常提示。
1. 参照上述使用新接口进行方法调用。
```csharp
[IgnoreStatusExceptionFilter(Enable = false)]
public interface INewApi : IFeishuTenantApi
{ }
```
开启状态异常之后的捕获方法：
```csharp
try
{
    var result2 = await _feishuApi.GetEventV1OutboundIpAsync();
    return Results.Json(result2);
}
catch (HttpRequestException ex) when (ex.InnerException is ApiResponseStatusException statusException)
{
    // 响应状态码异常
    return Results.Problem(statusException.Message);
}
```

### 关闭`接口日志`
默认：开启。
1. 新建API，继承于IFeishuTenantApi。
1. 使用属性 `LoggingFilter` 并设置属性 `Enable` 为 `false` ，即可停用日志。
1. 参照上述使用新接口进行方法调用。
```csharp
[LoggingFilter(Enable = false), IgnoreStatusExceptionFilter(Enable = false)]
public interface INewApi : IFeishuTenantApi
{ }
```

** `IFeishuApi` 和 `IFeishuTenantApi` 均有独立的 `LoggingFilter` 与 `IgnoreStatusExceptionFilter` 属性，如果都要关闭，需分别继承并设置 `Enable` 为 `false` **