# FeishuNetSdk

[![Build status](https://github.com/vicenteyu/FeishuNetSdk/workflows/.NET/badge.svg)](https://github.com/vicenteyu/FeishuNetSdk/actions)

飞书开放平台网址：[https://open.feishu.cn/](https://open.feishu.cn/)

接口清单详见：[TenantAccessToken适用接口清单-969个](https://github.com/vicenteyu/FeishuNetSdk/blob/main/TenantAccessList.md)

## 用法：

### 1. 安装Nuget包
[![FeishuNetSdk](https://buildstats.info/nuget/FeishuNetSdk "FeishuNetSdk")](https://www.nuget.org/packages/FeishuNetSdk/ "FeishuNetSdk")

### 2. 依赖注册（直接输入`应用凭证`的方式，二选一）
```csharp
builder.Services.AddHttpApi<IFeishuApi>();
builder.Services.AddHttpApi<IFeishuTenantApi>();
builder.Services.AddTokenProvider<IFeishuTenantApi>(async service =>
{
    //获取凭证接口
    var feishuApi = service.GetRequiredService<IFeishuApi>();
	//获取tenant_access_token
    var response = await feishuApi.PostAuthV3TenantAccessTokenInternalAsync(
            new FeishuNetSdk.Auth.Spec
            	.PostAuthV3TenantAccessTokenInternalBodyDto
	            {
	            	//此处修改为自建的应用凭证Id和密钥
	                AppId = "cli_a5bf8739dab8d0c",
	                AppSecret = "vn7MjifCNm04dUlWBg6yWbijHvEpel6G"
	            });
	//返回一个能自动缓存和过期重取的Token实例
    return new TokenResult
    {
        Access_token = response.TenantAccessToken,
        Expires_in = response.Expire
    };
});
```
### 2. 依赖注册（配置文件的方式，二选一）
1. 创建`FeishuOption`类：
```csharp
public record FeishuOption
{
    public string app_id { get; set; } = string.Empty;
    public string app_secret { get; set; } = string.Empty;
}
```
1. 在`appsettings.json`文件中添加配置：
```csharp
"Feishu": {
    "app_id": "cli_a5bf8739dab8d0c",
    "app_secret": "vn7MjifCNm04dUlWBg6yWbijHvEpel6G",
}
```
1. 添加绑定配置
```csharp
builder.Services.Configure<FeishuOption>(builder.Configuration.GetSection("Feishu"));
```
1. 接口注册
```csharp
builder.Services.AddHttpApi<IFeishuApi>();
builder.Services.AddHttpApi<IFeishuTenantApi>();
builder.Services.AddTokenProvider<IFeishuTenantApi>(async service =>
{
    //获取配置
    var option = service.GetRequiredService<IOptionsMonitor<FeishuOption>>();
    //获取凭证接口
    var feishuApi = service.GetRequiredService<IFeishuApi>();
	//获取tenant_access_token
    var response = await feishuApi.PostAuthV3TenantAccessTokenInternalAsync(
            new FeishuNetSdk.Auth.Spec
                .PostAuthV3TenantAccessTokenInternalBodyDto
	            {
	                AppId = option.CurrentValue.app_id,
	                AppSecret = option.CurrentValue.app_secret
	            });
	//返回一个能自动缓存和过期重取的Token实例
    return new TokenResult
    {
        Access_token = response.TenantAccessToken,
        Expires_in = response.Expire
    };
});
```

### 3. 依赖注入
```csharp
public class TestController : ControllerBase
{
    private readonly IFeishuTenantApi _feishuApi;
    public TestController(IFeishuTenantApi feishuApi)
    {
        _feishuApi = feishuApi;
    }
}
```

### 4. 方法调用
```csharp
[HttpGet("t2")]
public async Task<IResult> GetT2Async()
{
    var result2 = await _feishuApi.GetImV1ChatsAsync();
    return Results.Json(result2);
}
```

## 示例：

### 文件上传示例
参数 `FormDataFile` 支持 `filePath`、`FileInfo`、`byte[]`、`Stream`。

**需要注意部分接口注释上有关于文件格式限制的说明**
```csharp
[HttpGet("t3")]
public async Task<IResult> GetT3Async()
{
	//定义文件存储路径
    var filePath = @"D:\Users\Downloads\e9bd937f1d7a4c4f992724f5de44bb14.jpg";
    //调用接口
    var result = await _feishuApi.PostImV1ImagesAsync(
        new FeishuNetSdk.Im.PostImV1ImagesBodyDto
        {
            ImageType = "message"
        },
        new FormDataFile(filePath));

    //当返回码不成功时，返回错误消息
    if (!result.IsSuccess)
        return Results.Problem(result.Msg);
    return Results.Json(result);
}
```

### 文件下载示例
下载操作默认返回`HttpResponseMessage`，由于没有`返回码（code）`可以判断操作是否成功，所以建议配合 `EnsureSuccessStatusCode()` 方法使用。

```csharp
[HttpGet("t4")]
public async Task<IResult> GetT4Async()
{
	//定义文件存储路径
    var filePath = @"D:\Users\Downloads\e9bd937f----1.jpg";
    //调用接口
    var result = (await _feishuApi.GetImV1ImagesByImageKeyAsync(
    	"img_xxxx-fbdc-4c36-b17c-ac8aa1aee7dg"))
    	//响应状态码异常时，抛出异常，需要自行捕获处理
    	.EnsureSuccessStatusCode();

    //保存文件到指定路径
    await result.SaveAsAsync(filePath);
    return Results.Json(result);
}
```

**个别接口支持部分下载，可以按需设置参数`Range`，字符串格式为`bytes=0-100`表示下载第`0`字节到第`100`字节的数据，默认`不填`或者`null`表示下载整个文件。示例如下：**

```csharp
[HttpGet("t5")]
public async Task<IResult> GetT5Async()
{
	//定义文件存储路径
    var filePath = @"D:\Users\Downloads\e9bd937f----2.jpg";
    //调用接口
    var result = (await _feishuApi.GetDriveV1MediasByFileTokenDownloadAsync(
        "OQBpbF8AEoZ0gqxpCMwcRPWFn8c",
        "bytes=0-100"))
    	//响应状态码异常时，抛出异常，需要自行捕获处理
        .EnsureSuccessStatusCode();

    //保存到指定路径，可能只是文件的一部分，并非完整。
    await result.SaveAsAsync(filePath);
    return Results.Json(result);
}
```

## 注意事项

### 云文档操作

**文档操作前提需要有编辑权限，步骤如下：**

1. 为`自建应用`添加`机器人`能力。
1. 将`应用机器人`加入或创建一个新`群组`。
1. 进入目标文档，将该`群组`设置为`文档协作者`。
1. 调用接口方法。



------------
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

#### 修改依赖注入
```csharp
public class TestController : ControllerBase
{
	//此处更改为新的API：INewApi
    private readonly INewApi _feishuApi;
    public TestController(INewApi feishuApi)
    {
        _feishuApi = feishuApi;
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


### 启用`缓存`
默认：关闭

缓存属性`Cache`，在接口上使用表示对接口内所有方法启用，建议仅针对具体方法使用，在单个方法上增加属性即可。数值单位是`毫秒`。

```csharp
public interface INewApi : IFeishuTenantApi
{
    [Cache(10 * 1000)]
    [HttpGet("/open-apis/event/v1/outbound_ip1")]
    new System.Threading.Tasks.Task<HttpResponseMessage> GetEventV1OutboundIpAsync();
}
```