// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-01
//
// Last Modified By : yxr
// Last Modified On : 2025-08-01
// ************************************************************************
// <copyright file="Test_CorehrPathwayUpdatedV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 通道更新 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr.Events;

/// <summary>
/// 测试 通道更新 事件体
/// <para>接口ID：7508634905587007491</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pathway/events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpathway%2fevents%2fupdated</para>
/// </summary>
[TestClass]
public class Test_CorehrPathwayUpdatedV2EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "corehr.pathway.updated_v2",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "pathway_id": "7043711774159341101",
        "field_changes": [
            "code"
        ]
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Corehr.Events.CorehrPathwayUpdatedV2EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}