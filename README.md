# FeishuNetSdk

内置自动缓存和过期重取Token机制。

[![.NET](https://github.com/vicenteyu/FeishuNetSdk/actions/workflows/dotnet.yml/badge.svg?branch=main&event=push)](https://github.com/vicenteyu/FeishuNetSdk/actions/workflows/dotnet.yml)
🔹[![FeishuNetSdk](https://img.shields.io/nuget/v/FeishuNetSdk?label=FeishuNetSdk "FeishuNetSdk")](https://www.nuget.org/packages/FeishuNetSdk/ "FeishuNetSdk")
🔹[![FeishuNetSdk.Endpoint](https://img.shields.io/nuget/v/FeishuNetSdk.Endpoint?label=FeishuNetSdk.Endpoint "FeishuNetSdk.Endpoint")](https://www.nuget.org/packages/FeishuNetSdk.Endpoint/ "FeishuNetSdk.Endpoint")
🔹[![FeishuNetSdk.WebSocket](https://img.shields.io/nuget/v/FeishuNetSdk.WebSocket?label=FeishuNetSdk.WebSocket "FeishuNetSdk.WebSocket")](https://www.nuget.org/packages/FeishuNetSdk.WebSocket/ "FeishuNetSdk.WebSocket")

飞书开放平台网址：[https://open.feishu.cn/](https://open.feishu.cn/)

接口清单详见：

[TenantAccessToken 适用接口清单](https://github.com/vicenteyu/FeishuNetSdk/blob/main/TenantAccessList.md)

[UserAccessToken 适用接口清单](https://github.com/vicenteyu/FeishuNetSdk/blob/main/UserAccessList.md)

[事件回调类型清单](https://github.com/vicenteyu/FeishuNetSdk/blob/main/EventCallbackList.md)

<img src="https://github.com/vicenteyu/FeishuNetSdk/blob/main/business.png" alt="商业合作、定制开发" height="350px">

## 用法：

### 1、安装Nuget包
```csharp
PM> Install-Package FeishuNetSdk
PM> Install-Package FeishuNetSdk.Endpoint //事件回调请求地址扩展包
PM> Install-Package FeishuNetSdk.WebSocket //长连接扩展包
```

### 2、服务注册

**（1）输入`应用凭证`的方式**

```csharp
builder.Services
    .AddFeishuNetSdk(options =>
    {
        options.AppId = "cli_test";
        options.AppSecret = "secret_test";
        options.EncryptKey: "75vyV*************Clrwpkjy"; //解密密钥
        options.VerificationToken: "WVr*************MSJw"; //验证密钥
        //options.EnableLogging = true; //启用日志 （true = 启用， false = 关闭， 默认 = 启用）
        //options.IgnoreStatusException = true; //忽略状态异常错误（true = 忽略， false = 启用， 默认 = 忽略）
    })
    .AddFeishuWebSocket(); //添加飞书长连接服务
```

**（2）使用`配置文件`的方式**

```csharp
builder.Services
    .AddFeishuNetSdk(builder.Configuration.GetSection("FeishuNetSdk"))
    .AddFeishuWebSocket(); //添加飞书长连接服务
```

在`appsettings.json`根节点上增加配置：

```csharp
"FeishuNetSdk": {
    "AppId": "cli_test",
    "AppSecret": "secret_test",
    "EncryptKey": "75vyV*************Clrwpkjy", //解密密钥
    "VerificationToken": "WVr*************MSJw", //验证密钥
    "EnableLogging": true, //启用日志 （true = 启用， false = 关闭， 默认 = 启用）
    "IgnoreStatusException": true //忽略状态异常错误（true = 忽略， false = 启用， 默认 = 忽略）
}
```

**（3）启用`事件与回调`终结点**

```csharp
//启用飞书事件回调地址服务
app.UseFeishuEndpoint("/a/b/c/d"); //示例：https://www.abc.com/a/b/c/d
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

1. 跳转授权页面，获取`登录预授权码`:`code`。
1. 使用`IFeishuAppApi`，根据`code`获取`user_access_token`。
1. 使用`IFeishuUserApi`，调用接口。`user_access_token`默认为第一参数。
1. 详见完整示例：samples/WebApplication1

## 部分示例：

### 事件与回调（v3.0.0 新增）

**（1）事件订阅示例**

项目内任意位置创建派生类：

1. IEventHandler<,>：事件方法接口，两个参数类型依次为：
1. EventV2Dto<>：完整消息体，V2表示`2.0`版本数据格式
1. xxxxEventBodyDto：事件体，从`EventBodyDto`继承

事件体类型参照：[事件回调类型清单](https://github.com/vicenteyu/FeishuNetSdk/blob/main/EventCallbackList.md)

**注意：需要3秒内响应。**

**规则上允许，但不建议：同一事件有多个派生类，可以同时执行，但任何一个超时或失败都会导致返回失败结果。**

**相同的事件消息可能会推送多次，原因例如日志上没有显示超时，但服务端判断已经超时。可以使用`完整消息体`上的`EventId`属性进行重复判断。**

```csharp
public class EventHandler1(ILogger<EventHandler> logger) : IEventHandler<EventV2Dto<ImMessageReceiveV1EventBodyDto>, ImMessageReceiveV1EventBodyDto>
{
    public async Task ExecuteAsync(EventV2Dto<ImMessageReceiveV1EventBodyDto> input)
    {
        await Task.Delay(600);
        logger.LogInformation("ExecuteAsync1: {info}", System.Text.Json.JsonSerializer.Serialize(input));
    }
}
```

**（2）回调订阅示例**

项目内任意位置创建派生类：

1. ICallbackHandler<,,>：回调方法接口，三个参数类型依次为：
1. CallbackV2Dto<>：完整消息体，V2表示`2.0`版本数据格式
1. xxxxEventBodyDto：事件体，从`EventBodyDto`继承
1. xxxxResponseDto：响应体，从`CallbackResponseDto`继承

事件体类型参照：[事件回调类型清单](https://github.com/vicenteyu/FeishuNetSdk/blob/main/EventCallbackList.md)

**注意：需要3秒内响应。**

**规则不允许同一回调有多个派生类。**

**一条消息仅推送一次。**

```csharp
public class MyCallbackHandler(ILogger<MyCallbackHandler> logger) : ICallbackHandler<CallbackV2Dto<CardActionTriggerEventBodyDto>, CardActionTriggerEventBodyDto, CardActionTriggerResponseDto>
{
    public async Task<CardActionTriggerResponseDto> ExecuteAsync(CallbackV2Dto<CardActionTriggerEventBodyDto> input)
    {
        await Task.CompletedTask;
        logger.LogWarning("{json}", JsonSerializer.Serialize(input));

        return new CardActionTriggerResponseDto().SetCard(new ElementsCardV2Dto()
        {
            Header = new() { Title = new("Button-updated"), Template = "blue" },
            Config = new() { EnableForward = true },
            Body = new()
            {
                Elements = [new DivElement().SetText(new PlainTextElement(Content: $"xxoo{DateTime.Now:yyyy-MM-dd HH:mm:ss}"))]
            }
        });
    }
}
```


### 扩展方法（v2.2.9 新增）

主要针对复杂参数的扩展，例如元素组合卡片等，可以提高易用性。

1. 实例化请求体
1. 调用扩展方法
1. 调用接口

**（1）创建审批实例 请求体 设置控件: SetFormControls**

```csharp
var dto1 = new FeishuNetSdk.Approval.PostApprovalV4InstancesBodyDto();
dto1.SetFormControls(new object[] { //更多对象位于 Approval.Dtos 空间下，ID默认使用Guid，也可以自定义。
        new InputFormControl("value1"){ Id = "fixed id" }, // <== 自定义Id
        new DateFormControl(new DateTime(2019,1,1)),
        new AmountFormControl(10.03m, "USD"),
        new DateIntervalFormControl(new(new DateTime(2024,1,1), new DateTime(2024,1,2), 3)),
        new ContactFormControl( ["value2","value3"], ["id1","id2"]),
    });
await tenantApi.PostApprovalV4InstancesAsync(dto1);
```

**（2）发送消息 请求体 设置消息类型及内容: SetContent**

```csharp
var dto2 = new FeishuNetSdk.Im.PostImV1MessagesBodyDto() { ReceiveId = "ou_3c5beeexxxxxx6ce936414bb0d13d386" }; // <== 接收人Id
dto2.SetContent(new PostContent //富文本消息对象，另外还有文本、消息卡片、群名片、个人名片、图片、视频、音频、文件、表情包，位于 Im.Dtos 空间下。
{
    Post = new()
    {
        ZhCn = new PostContent.PostLanguage() { Title = "title" }
            .AddContent([new TextElement(Text: "测试消息"), new AtElement(UserId: "ou_111222333")])
            .AddContent([new HrElement()])
            .AddContent([new LinkElement("链接地址", "https://123")])
    }
});
await tenantApi.PostImV1MessagesAsync("open_id", dto2);
```

**类似方法：**

1. 回复消息 请求体 PostImV1MessagesByMessageIdReplyBodyDto
1. 编辑消息 请求体 PutImV1MessagesByMessageIdBodyDto


**（3）批量发送消息 请求体 设置消息类型及内容: SetCardOrContent**

```csharp
var dto3 = new FeishuNetSdk.Im.Spec.PostMessageV4BatchSendBodyDto() { OpenIds = ["ou_18eac85dyyyyyyy9317ad4f02e8bbbb"] }; // <== 接收人Id
dto3.SetCardOrContent(new TemplateCardDto //支持的类型详见 参数说明。
{
    Data = new()
    {
        TemplateId = "ctp_xx0123456789",  // <== 模板Id
        TemplateVariable = new()          // <== 模板变量
        {
            { "aa", "Aa" },
            { "bb", "Bb" },
            { "cc", "Cc" }
        }
    }
});
await tenantApi.PostMessageV4BatchSendAsync(dto3);
```

**类似方法：**

1. 延时更新消息卡片 请求体 PostInteractiveV1CardUpdateBodyDto
1. 更新应用发送的消息卡片 请求体 PatchImV1MessagesByMessageIdBodyDto


**（4）查看指定审批定义 响应体 获取序列化的控件信息: GetFormControls**

```csharp
var approval = await tenantApi.GetApprovalV4ApprovalsByApprovalCodeAsync("07CE295D-8FB9-****-886C-E8086E0F9F92");
if (approval.IsSuccess)
    Console.WriteLine(approval.Data.GetFormControls());
```

**（5）元素组合卡片（支持图表、表格、表单容器等复杂卡片，详见 Im.Dtos 命名空间）**

```csharp
//初始化图表数据
var d1 = new ChartElement.Data(Values: [new () { { "time", "2:00" }, { "value", 8 } },new () { { "time", "4:00" }, { "value", 9 } }, new () { { "time", "6:00" }, { "value", 11 } }, new () { { "time", "8:00" }, { "value", 14 } }, new () { { "time", "10:00" }, { "value", 16 } }, new () { { "time", "12:00" }, { "value", 17 } }, new () { { "time", "14:00" }, { "value", 17 } }, new () { { "time", "16:00" }, { "value", 16 } }, new () { { "time", "18:00" }, { "value", 15 } }, ]);

//初始化图表
var element = new ChartElement()// <== 定义图表
{
    AspectRatio = "16:9",
    
    ChartSpec = new ChartElement.LineSpec() // <== 定义拆线图，另外还有 面积图、柱状图、条形图、环图、饼图、组合图、漏斗图、散点图、雷达图、条形进度图、环形进度图、词云。
    {
        Title = new("折线图"),
        XField = ["time"],
        YField = "value",
        Data = [d1]
    }
};

//初始化 请求体
var dto5 = new FeishuNetSdk.Im.PostImV1MessagesBodyDto() { ReceiveId = "ou_e588d*************9264e4c03fd928f" }
.SetContent(new ElementsCardDto() // <== ElementsCardDto 是元素组合卡片，TemplateCardDto 是模板卡片。
{
    Header = new() { Title = new() { Content = "测试图表" } }, // <== 卡片标题
    Elements = [element] // <== 卡片元素组合：[ element1, element2 …… ]，如果是表单容器组件，还支持链式调用组件：elements.AddElement(element1).AddElement(element2)……。
});

//发送请求
await tenantApi.PostImV1MessagesAsync("open_id", dto5);

```

**（6）多维表格 查询记录 响应体 将查询结果转换为字符串值（3.3.7+）: SerializeFieldsToStringValue**
```csharp
var _app_token = "T2aFbYYOoxxxxxxxxxxxxxxxAbjn4g";
var _table_id = "tbldE95HxxxxxxxxxxEVLCQ";
//获取字段数据结构
var fields = await tenantApi.GetBitableV1AppsByAppTokenTablesByTableIdFieldsAsync(_app_token, _table_id, page_size: 100);
//查询记录
var response = await tenantApi.PostBitableV1AppsByAppTokenTablesByTableIdRecordsSearchAsync(_app_token, _table_id, new()
{
    AutomaticFields = true,
    ViewId = "vewxxxxxxxxxxxx1u",
});
//对查询结果进行转换
var serialize = response.Data?.Items?.Select(i => i.SerializeFieldsToStringValue(fields.Data?.Items, new BitableRecordSerializer()));

```

**自定义序列化规则**
```csharp
public class CustomBitableRecordSerializer(string s = "^") : BitableRecordSerializer(s)
{
    public override string AttachmentRecordToString(AttachmentRecord[]? record)
    {
        return JoinCollection(record?.Select(x => $"{x.Name}-{x.FileToken}"));
    }

    public override string TextRecordToString(TextRecord[]? record)
    {
        return JoinCollection(record?.Select(x => x.Type switch { "mention" => $"提及{x.Text}", "url" => $"链接{x.Link}", _ => x.Text }));
    }
}
```

**说明：**

1. 建议获取字段数据结构的接口请求参数`page_size`设置为`100`（最大），避免字段不全。若超出`100`，则需要进行分页查询。
1. 可以指定`BitableRecordSerializer`参数为数组值分隔符，默认`;`。
1. 文本记录类型字段取值于`text`属性
1. 人员类型字段取值于`name`属性
1. 链接类型字段取值于`link`属性
1. 附件类型字段取值于`file_token`属性
1. 地理位置类型字段取值于`name`属性
1. 群组类型字段取值于`name`属性
1. 公式或查找引用类型也会根据对应类型按照上述属性取值
1. 其余字段默认拼接为`string`类型，其中 日期类型 为 Unix 时间戳，单位是毫秒，如有需要可自行转换为日期格式。
1. 自定义序列化规则：继承 `BitableRecordSerializer` 分别重写 `xxxRecordToString` 方法。
1. 查询记录暂不支持`流程`和`按钮`字段数据。



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