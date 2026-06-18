// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-19
//
// Last Modified By : yxr
// Last Modified On : 2026-06-19
// ************************************************************************
// <copyright file="Test_GetEventV1ConnectionResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取长连接在线数量 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Event;

/// <summary>
/// 测试 获取长连接在线数量 响应体
/// <para>接口ID：7652298771384404951</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uYDNxYjL2QTM24iN0EjN/event-v1/connection/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuYDNxYjL2QTM24iN0EjN%2fevent-v1%2fconnection%2fget</para>
/// </summary>
[TestClass]
public class Test_GetEventV1ConnectionResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "online_instance_cnt": 10
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Event.GetEventV1ConnectionResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}