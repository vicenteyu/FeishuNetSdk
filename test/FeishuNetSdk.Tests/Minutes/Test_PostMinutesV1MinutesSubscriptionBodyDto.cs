// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-30
//
// Last Modified By : yxr
// Last Modified On : 2026-05-29
// ************************************************************************
// <copyright file="Test_PostMinutesV1MinutesSubscriptionBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 订阅妙记变更事件 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Minutes;

/// <summary>
/// 测试 订阅妙记变更事件 请求体
/// <para>接口ID：7644841241634016203</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/minutes-v1/minute/subscription</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fminutes-v1%2fminute%2fsubscription</para>
/// </summary>
[TestClass]
public class Test_PostMinutesV1MinutesSubscriptionBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "event_type": "minutes.minute.generated_v1"
}
""";
        var result = Deserialize<FeishuNetSdk.Minutes.PostMinutesV1MinutesSubscriptionBodyDto>(json);
        Assert.IsNotNull(result);
    }
}