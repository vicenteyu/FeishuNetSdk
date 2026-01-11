// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-01-11
//
// Last Modified By : yxr
// Last Modified On : 2026-01-11
// ************************************************************************
// <copyright file="Test_ApaasWorkspaceRecordChangeV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 数据记录变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.AppEngine.Events;

/// <summary>
/// 测试 数据记录变更 事件体
/// <para>接口ID：7592139877891705816</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/apaas-v1/workspace/events/record_change</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fworkspace%2fevents%2frecord_change</para>
/// </summary>
[TestClass]
public class Test_ApaasWorkspaceRecordChangeV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "apaas.workspace.record_change_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "workspace": "workspace_aadjdr45t4ias",
        "app": "app_4j45921xyju6s",
        "table": "t1",
        "type": "UPDATE",
        "operator": "(1801755886986304)",
        "before": "{\"_created_at\":\"2025-10-30 22:32:56.90873+08\",\"_created_by\":\"(1801755886986304)\",\"_id\":\"6ca55db2-503f-4490-ae6b-76834f9e6d15\",\"_updated_at\":\"2025-10-30 22:32:56.90873+08\",\"_updated_by\":\"(1801755886986304)\",\"custom_col_1\":123,\"custom_col_2\":0,\"custom_col_3\":\"xxx\",\"custom_col_5\":\"yyy\"}",
        "after": "{\"_updated_at\":\"2025-10-14 18:18:26.509353+08\",\"_updated_by\":\"(1801755886986304)\",\"custom_col_1\":456}"
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.AppEngine.Events.ApaasWorkspaceRecordChangeV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}