# FeishuNetSdk.WebSocket

FeishuNetSdk 开发包的长连接扩展。

[![.NET](https://github.com/vicenteyu/FeishuNetSdk/actions/workflows/dotnet.yml/badge.svg?branch=main&event=push)](https://github.com/vicenteyu/FeishuNetSdk/actions/workflows/dotnet.yml)
🔹[![FeishuNetSdk](https://img.shields.io/nuget/v/FeishuNetSdk?label=FeishuNetSdk "FeishuNetSdk")](https://www.nuget.org/packages/FeishuNetSdk/ "FeishuNetSdk")
🔹[![FeishuNetSdk.Endpoint](https://img.shields.io/nuget/v/FeishuNetSdk.Endpoint?label=FeishuNetSdk.Endpoint "FeishuNetSdk.Endpoint")](https://www.nuget.org/packages/FeishuNetSdk.Endpoint/ "FeishuNetSdk.Endpoint")
🔹[![FeishuNetSdk.WebSocket](https://img.shields.io/nuget/v/FeishuNetSdk.WebSocket?label=FeishuNetSdk.WebSocket "FeishuNetSdk.WebSocket")](https://www.nuget.org/packages/FeishuNetSdk.WebSocket/ "FeishuNetSdk.WebSocket")

飞书开放平台网址：[https://open.feishu.cn/](https://open.feishu.cn/)

接口清单详见：

[TenantAccessToken 适用接口清单](https://github.com/vicenteyu/FeishuNetSdk/blob/main/TenantAccessList.md)

[UserAccessToken 适用接口清单](https://github.com/vicenteyu/FeishuNetSdk/blob/main/UserAccessList.md)

## 注意事项：

### 在开始配置之前，你需要确保已了解以下注意事项：

- 目前长连接模式仅支持企业自建应用。
- 与 将事件发送至开发者服务器 方式的要求相同，长连接模式下接收到消息后，也需要在 3 秒内处理完成，否则会触发超时重推机制。
- 每个应用最多建立 50 个连接（在配置长连接时，每初始化一个 client 就是一个连接）。
- 长连接模式的消息推送为 集群模式，不支持广播，即如果同一应用部署了多个客户端（client），那么只有其中随机一个客户端会收到消息。
- **启用长连接并启动项目，进入开发者后台，将事件配置中的订阅方式变更为：使用长连接接收事件，重新发布版本之后才能生效。**

## 用法：

### 1、安装Nuget包
```csharp
PM> Install-Package FeishuNetSdk.WebSocket
```

### 2、服务注册

**（1）输入`应用凭证`的方式**
```csharp
builder.Services
    .AddFeishuNetSdk(
        AppId: "cli_a*********013",
        AppSecret: "H2wl******************UBfyVn",
        EncryptKey: "75vyV******************wpkjy",
        VerificationToken: "WVrlO******************2EsMSJw")
    //添加飞书长连接服务
    .AddFeishuWebSocket();

```