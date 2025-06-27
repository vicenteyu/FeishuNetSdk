// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_CorehrJobDataEmployedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 员工完成入职 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople.Events;

/// <summary>
/// 测试 员工完成入职 事件体
/// <para>接口ID：7084239806838013955</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/pre_hire/employed</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fjob_data%2fevents%2femployed</para>
/// </summary>
[TestClass]
public class Test_CorehrJobDataEmployedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "corehr.job_data.employed_v1",
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
        }
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.FeishuPeople.Events.CorehrJobDataEmployedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}