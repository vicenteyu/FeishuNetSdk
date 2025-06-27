// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_CorehrJobDataChangedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 员工完成异动 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople.Events;

/// <summary>
/// 测试 员工完成异动 事件体
/// <para>接口ID：7085168201680814083</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/job_change/changed</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fjob_data%2fevents%2fchanged</para>
/// </summary>
[TestClass]
public class Test_CorehrJobDataChangedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "corehr.job_data.changed_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "job_data_id": "7072306364927985196",
        "employment_id": "7072306364927985196",
        "target_user_id": {
            "union_id": "on_8ed6aa67826108097d9ee143816345",
            "user_id": "e33ggbyz",
            "open_id": "ou_84aad35d084aa403a838cf73ee18467"
        },
        "job_change_id": "7072306364927985196"
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.FeishuPeople.Events.CorehrJobDataChangedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}