// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_CorehrDepartmentUpdatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新部门 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople.Events;

/// <summary>
/// 测试 更新部门 事件体
/// <para>接口ID：7125370197952053252</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/department/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fdepartment%2fevents%2fupdated</para>
/// </summary>
[TestClass]
public class Test_CorehrDepartmentUpdatedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "corehr.department.updated_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "department_id": "6969828847121885087",
        "field_changes": [
            "subtype"
        ]
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.FeishuPeople.Events.CorehrDepartmentUpdatedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}