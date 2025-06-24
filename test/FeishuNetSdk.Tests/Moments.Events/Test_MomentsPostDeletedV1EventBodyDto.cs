// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_MomentsPostDeletedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 删除帖子 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Moments.Events;

/// <summary>
/// 测试 删除帖子 事件体
/// <para>接口ID：7270433540692656131</para>
/// <para>文档地址：https://open.feishu.cn/document/moments-v1/post/events/deleted</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fmoments-v1%2fpost%2fevents%2fdeleted</para>
/// </summary>
[TestClass]
public class Test_MomentsPostDeletedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "moments.post.deleted_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "id": "248381241"
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Moments.Events.MomentsPostDeletedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}