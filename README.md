# FeishuNetSdk

内置自动缓存和过期重取Token机制。

[![.NET](https://github.com/vicenteyu/FeishuNetSdk/actions/workflows/dotnet.yml/badge.svg?branch=main&event=push)](https://github.com/vicenteyu/FeishuNetSdk/actions/workflows/dotnet.yml) [![FeishuNetSdk](https://buildstats.info/nuget/FeishuNetSdk "FeishuNetSdk")](https://www.nuget.org/packages/FeishuNetSdk/ "FeishuNetSdk")

飞书开放平台网址：[https://open.feishu.cn/](https://open.feishu.cn/)

接口清单详见：

[TenantAccessToken 适用接口清单](https://github.com/vicenteyu/FeishuNetSdk/blob/main/TenantAccessList.md)

[UserAccessToken 适用接口清单](https://github.com/vicenteyu/FeishuNetSdk/blob/main/UserAccessList.md)


## 用法：

### 1、安装Nuget包
```csharp
PM> Install-Package FeishuNetSdk
```

### 2、服务注册
**输入`应用凭证`的方式**
```csharp
builder.Services.AddFeishuNetSdk(options =>
{
    options.AppId = "cli_test";
    options.AppSecret = "secret_test";
    //options.EnableLogging = true; //启用日志 （true = 启用， false = 关闭， 默认 = 启用）
    //options.IgnoreStatusException = true; //忽略状态异常错误（true = 忽略， false = 启用， 默认 = 忽略）
});
```
**使用`配置文件`的方式**
```csharp
builder.Services.AddFeishuNetSdk(builder.Configuration.GetSection("FeishuNetSdk"));
```
在`appsettings.json`根节点上增加配置：
```csharp
"FeishuNetSdk": {
    "AppId": "cli_test",
    "AppSecret": "secret_test",
    "EnableLogging": true, //启用日志 （true = 启用， false = 关闭， 默认 = 启用）
    "IgnoreStatusException": true //忽略状态异常错误（true = 忽略， false = 启用， 默认 = 忽略）
}
```

### 3、注入和调用
```csharp
public class TestController : ControllerBase
{
    private readonly IFeishuTenantApi _tenantApi;  // <== TenantAccessToken 适用API
    private readonly IFeishuUserApi _userApi;      // <== UserAccessToken 适用API
    
    public TestController(IFeishuTenantApi tenantApi, IFeishuUserApi userApi)
    {
        _tenantApi = tenantApi;
        _userApi = userApi;
    }
    
    [HttpGet("t2")]
    public async Task<IResult> GetT2Async()
    {
        var result = await _tenantApi.GetImV1ChatsAsync();
        return Results.Json(result);
    }
}
```

### 4、UserAccessToken 接口使用方法

1.跳转登录页面，获取`登录预授权码`:`code`。
1.使用`IFeishuAppApi`，根据`code`获取`user_access_token`。
1.使用`IFeishuUserApi`，调用接口。`user_access_token`默认为第一参数。

```csharp

```


## 示例：

### 文件上传示例
参数类型 `FormDataFile` 支持 `filePath`、`FileInfo`、`byte[]`、`Stream`。

**需要注意部分接口注释上有关于文件格式限制的说明。**
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
    //当返回码异常时，返回错误消息
    if (!result.IsSuccess)
        return Results.Problem(result.Msg);
    return Results.Json(result);
}
```

### 文件下载示例
下载操作默认返回`HttpResponseMessage`，由于没有`返回码（code）`可以判断操作是否成功，所以建议配合 `EnsureSuccessStatusCode()` 方法使用，当响应状态码异常时，会抛出异常，需要自行捕获处理。

```csharp
[HttpGet("t4")]
public async Task<IResult> GetT4Async()
{
    //定义文件存储路径
    var filePath = @"D:\Users\Downloads\e9bd937f----1.jpg";
    //调用接口
    var result = (await _feishuApi.GetImV1ImagesByImageKeyAsync(
        image_key: "img_xxxx-fbdc-4c36-b17c-ac8aa1aee7dg"))
        //当响应状态码异常时，会抛出异常，需要自行捕获处理
        .EnsureSuccessStatusCode();

    //保存文件到指定路径
    await result.SaveAsAsync(filePath);
    return Results.Json(result);
}
```

**个别接口支持部分下载，可以按需设置参数`range`，字符串格式为`bytes=0-100`表示下载第`0`字节到第`100`字节的数据，默认`不填`或者`null`表示下载整个文件。示例如下：**

```csharp
[HttpGet("t5")]
public async Task<IResult> GetT5Async()
{
    //定义文件存储路径
    var filePath = @"D:\Users\Downloads\e9bd937f----2.jpg";
    //调用接口
    var result = (await _feishuApi.GetDriveV1MediasByFileTokenDownloadAsync(
        file_token: "OQBpbF8AEoZ0gqxpCMwcRPWFn8c",
        range: "bytes=0-100"))
        //当响应状态码异常时，会抛出异常，需要自行捕获处理
        .EnsureSuccessStatusCode();

    //保存到指定路径，可能只是文件的一部分，并非完整。
    await result.SaveAsAsync(filePath);
    return Results.Json(result);
}
```

**HTTP状态码为 200 时，表示成功，返回文件二进制流。**

**HTTP状态码为 206 时，表示下载部分内容成功，返回指定 Range 的部分文件的二进制流。**

## 注意事项：

### 当`获取凭证`异常时，内部异常类型为`TokenException`。
```csharp
try
{
    var result = await _feishuApi.GetEventV1OutboundIpAsync();
    return Results.Json(result);
}
catch (HttpRequestException ex) when (ex.InnerException is TokenException tokenException)
{
    return Results.Problem(tokenException.Message);
}
```

### 云文档操作

**文档操作前提需要有编辑权限，步骤如下：**

1. 为`自建应用`添加`机器人`能力。
1. 将`应用机器人`加入或创建一个新`群组`。
1. 进入目标文档，将该`群组`设置为`文档协作者`。
1. 调用接口方法。


------------
## 以下是仅在特殊情况下使用。


### 关闭`接口日志`
true = 启用， false = 关闭， 默认 = 启用

使用配置文件方式可以实时切换。


### 启用`状态异常错误`
true = 忽略， false = 启用， 默认 = 忽略

飞书接口在返回结果异常时，同时会返回状态异常，状态异常通常无法实质判断异常原因，具体原因会在返回结果中提示。所以接口默认忽略状态异常。开启状态异常之后需要进行捕获，内部异常为`ApiResponseStatusException`。

使用配置文件方式可以实时切换。

```csharp
try
{
    var result = await _feishuApi.GetEventV1OutboundIpAsync();
    return Results.Json(result);
}
catch (HttpRequestException ex) when (ex.InnerException is ApiResponseStatusException statusException)
{
    // 响应状态码异常
    return Results.Problem(statusException.Message);
}
```


### 接口重载/覆盖

**如果要覆盖方法，比如是在保持参数完全一致的情况下，修改http地址，需要在方法前加 `new` （参数不一致是重载，重载不用加`new` ），然后将新地址更换到属性上。更换http方法、返回参数及其他属性也是同理。**

#### 1、新建API，继承于 `IFeishuTenantApi`
```csharp
public interface INewApi : IFeishuTenantApi
{
    [HttpGet("/open-apis/event/v1/outbound_ip1")]
    new System.Threading.Tasks.Task<HttpResponseMessage> GetEventV1OutboundIpAsync();
}
```

#### 2、注册API
```csharp
builder.Services.AddHttpApi<INewApi>();
```

#### 3、修改注入
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


### 启用`缓存`
默认：不缓存

缓存属性`Cache`，在接口上使用表示对接口内所有方法启用，建议仅针对具体方法使用，在单个方法上增加属性即可。数值单位是`毫秒`。

```csharp
public interface INewApi : IFeishuTenantApi
{
    [Cache(10 * 1000)]
    [HttpGet("/open-apis/event/v1/outbound_ip1")]
    new System.Threading.Tasks.Task<HttpResponseMessage> GetEventV1OutboundIpAsync();
}
```