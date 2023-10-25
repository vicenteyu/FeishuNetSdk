# FeishuNetSdk

飞书开放平台网址：[https://open.feishu.cn/](https://open.feishu.cn/)

接口清单详见：[TenantAccessToken适用接口清单-969个](https://github.com/vicenteyu/FeishuNetSdk/blob/main/TenantAccessList.md)

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

### 文件上传示例
参数 `FormDataFile` 支持 `filePath`、`FileInfo`、`byte[]`、`Stream`。

**需要注意部分接口注释上有关于文件格式限制的说明**
```csharp
[HttpGet("t3")]
public async Task<IResult> GetT3Async()
{
    var filePath = @"D:\Users\Downloads\e9bd937f1d7a4c4f992724f5de44bb14.jpg";
    var result = await _feishuApi.PostImV1ImagesAsync(
        new FeishuNetSdk.Im.PostImV1ImagesBodyDto
        {
            ImageType = "message"
        },
        new FormDataFile(filePath));

    return Results.Json(result);
}
```
### 文件下载示例
```csharp
[HttpGet("t4")]
public async Task<IResult> GetT4Async()
{
    var filePath = @"D:\Users\Downloads\e9bd937f----1.jpg";
    var result = await _feishuApi.GetImV1ImagesByImageKeyAsync("img_xxxx-fbdc-4c36-b17c-ac8aa1aee7dg");
    await result.SaveAsAsync(filePath);
    return Results.Json(result);
}
```

**个别接口支持部分下载，可以按需设置参数`Range`，字符串格式为`bytes=0-100`表示下载第0字节到第100字节的数据，默认不填或者`null`表示下载整个文件。**
```csharp
[HttpGet("t5")]
public async Task<IResult> GetT5Async()
{
    var filePath = @"D:\Users\Downloads\e9bd937f----2.jpg";
    var result = await _feishuApi.GetDriveV1MediasByFileTokenDownloadAsync(
        "OQBpbF8AEoZ0gqxpCMwcRPWFn8c",
        "bytes=0-100");
    await result.SaveAsAsync(filePath);
    return Results.Json(result);
}
```

### 云文档操作
**几乎都需要先有用户授权，操作如下：**
1. 将应用机器人加入或创建一个新群组。
1. 将该群组设置为文档协作者。
1. 继续调用接口方法。


## 以下是仅在特殊情况下使用的特殊方法。
### 接口重载/覆盖
1. 新建API，继承于 `IFeishuTenantApi`。
1. 使用重载/覆盖方法

**如果要覆盖方法，比如是在保持参数完全一致的情况下，修改http地址，需要在方法前加 `new` （参数不一致是重载，重载不用加`new` ），然后将新地址更换到属性上。更换http方法、返回参数及其他属性也是同理。**

#### 新建API
```csharp
public interface INewApi : IFeishuTenantApi
{
    [HttpGet("/open-apis/event/v1/outbound_ip1")]
    new System.Threading.Tasks.Task<HttpResponseMessage> GetEventV1OutboundIpAsync();
}
```

#### 新增依赖注册
```csharp
builder.Services.AddHttpApi<INewApi>();
```

#### 修改方法调用
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

飞书接口在返回结果异常时，同时会返回状态异常，状态异常通常无法实质判断异常原因，具体原因会在返回结果中提示。所以接口默认忽略状态异常，开启方法如下：

1. 新建API，继承于 `IFeishuTenantApi`。
1. 添加接口属性 `IgnoreStatusExceptionFilter` 并将属性 `Enable` 设置为 `false` ，意为停用忽略，即启用异常提示。
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
默认：开启

1. 新建API，继承于 `IFeishuTenantApi`。
1. 添加接口属性 `LoggingFilter` 并设置属性 `Enable` 为 `false` ，即可停用日志。
1. 参照上述使用新接口进行方法调用。
1. `LoggingFilter` 和 `IgnoreStatusExceptionFilter` 可以同时存在。
```csharp
[LoggingFilter(Enable = false), IgnoreStatusExceptionFilter(Enable = false)]
public interface INewApi : IFeishuTenantApi
{ }
```

**需要注意： `IFeishuApi` 和 `IFeishuTenantApi` 各有独立的 `LoggingFilter` 与 `IgnoreStatusExceptionFilter` 属性，若想全部关闭，需要分别继承接口并将属性 `Enable` 设置为 `false` 。**