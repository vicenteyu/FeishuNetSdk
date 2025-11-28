// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-11-28
//
// Last Modified By : yxr
// Last Modified On : 2025-11-28
// ************************************************************************
// <copyright file="Test_CorehrSignatureFileStatusUpdatedV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 电子签文件状态发生变更事件 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr.Events;

/// <summary>
/// 测试 电子签文件状态发生变更事件 事件体
/// <para>接口ID：7395391068203073564</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/siganture/signature_file/events/status_updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fsignature_file%2fevents%2fstatus_updated</para>
/// </summary>
[TestClass]
public class Test_CorehrSignatureFileStatusUpdatedV2EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "corehr.signature_file.status_updated_v2",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "signature_file_id": "123124341",
        "before_status": "pending_review",
        "after_status": "reviewing",
        "biz_process_id": "1c339287-7c6a-43b3-b924-d56118185dcc"
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Corehr.Events.CorehrSignatureFileStatusUpdatedV2EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}