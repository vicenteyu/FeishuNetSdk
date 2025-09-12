// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-09-10
//
// Last Modified By : yxr
// Last Modified On : 2025-09-10
// ************************************************************************
// <copyright file="Test_CompensationArchiveChangedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 薪资档案变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.CompensationManagement.Events;

/// <summary>
/// 测试 薪资档案变更 事件体
/// <para>接口ID：7455211774629396508</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/archive/events/changed</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2farchive%2fevents%2fchanged</para>
/// </summary>
[TestClass]
public class Test_CompensationArchiveChangedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "compensation.archive.changed_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "operate_type": "add",
        "employment_id": "7185121880616011308",
        "effective_date": "2024-10-23",
        "before_tid": "7026250586485114406",
        "after_tid": "7026250586485123406"
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.CompensationManagement.Events.CompensationArchiveChangedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}