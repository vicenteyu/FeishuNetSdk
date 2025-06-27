// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_CorehrJobUpdatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新职务 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople.Events;

/// <summary>
/// 测试 更新职务 事件体
/// <para>接口ID：7273083612789227523</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job-management/job/events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fjob%2fevents%2fupdated</para>
/// </summary>
[TestClass]
public class Test_CorehrJobUpdatedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "corehr.job.updated_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "job_id": "201571108"
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.FeishuPeople.Events.CorehrJobUpdatedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}