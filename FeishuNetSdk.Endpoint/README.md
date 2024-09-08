# FeishuNetSdk.Endpoint

FeishuNetSdk 开发包的事件回调终结点扩展。

[![.NET](https://github.com/vicenteyu/FeishuNetSdk/actions/workflows/dotnet.yml/badge.svg?branch=main&event=push)](https://github.com/vicenteyu/FeishuNetSdk/actions/workflows/dotnet.yml) [![FeishuNetSdk](https://buildstats.info/nuget/FeishuNetSdk "FeishuNetSdk")](https://www.nuget.org/packages/FeishuNetSdk/ "FeishuNetSdk")

飞书开放平台网址：[https://open.feishu.cn/](https://open.feishu.cn/)

接口清单详见：

[TenantAccessToken 适用接口清单](https://github.com/vicenteyu/FeishuNetSdk/blob/main/TenantAccessList.md)

[UserAccessToken 适用接口清单](https://github.com/vicenteyu/FeishuNetSdk/blob/main/UserAccessList.md)

## 注意事项：

### 在开始配置之前，你需要确保已了解以下注意事项：

- 配置终结点并运行程序
- 将终点地址配置到 飞开发者后台 事件与回调的请求地址中。

## 用法：

### 1、安装Nuget包
```csharp
PM> Install-Package FeishuNetSdk.Endpoint
```

### 2、服务注册

**（1）输入`应用凭证`的方式**
```csharp
builder.Services
    .AddFeishuNetSdk(
        AppId: "cli_a*********013",
        AppSecret: "H2wl******************UBfyVn",
        EncryptKey: "75vyV******************wpkjy",
        VerificationToken: "WVrlO******************2EsMSJw");
```

**（2）配置终结点**
```csharp
//启用飞书事件回调地址服务
app.UseFeishuEndpoint("/a/b/c/d");
```