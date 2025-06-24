// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_ContactDepartmentUpdatedV3EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 部门信息变化 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Contact.Events;

/// <summary>
/// 测试 部门信息变化 事件体
/// <para>接口ID：6954228303264104475</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/department/events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fdepartment%2fevents%2fupdated</para>
/// </summary>
[TestClass]
public class Test_ContactDepartmentUpdatedV3EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "contact.department.updated_v3",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "object": {
            "name": "测试部门",
            "parent_department_id": "od_j10jjkfsd89782",
            "department_id": "jyd7sa8yf2",
            "open_department_id": "od_j10j52hjksd9g0isdfg43",
            "leader_user_id": "ou_3j1kh45jk18fgh23hf",
            "chat_id": "oc_uiy325uy23bnv48gdf",
            "order": 100,
            "status": {
                "is_deleted": false
            },
            "leaders": [
                {
                    "leaderType": 1,
                    "leaderID": "ou_7dab8a3d3cdcc9da365777c7ad535d62"
                }
            ],
            "department_hrbps": [
                {
                    "union_id": "on_cad4860e7af114fb4ff6c5d496d1dd76",
                    "user_id": "98bc325a",
                    "open_id": "ou_c99c5f35d542efc7ee492afe11af19ef"
                }
            ]
        },
        "old_object": {
            "name": "测试部门",
            "parent_department_id": "od_j10jjkfsd89782",
            "department_id": "jyd7sa8yf2",
            "open_department_id": "od_j10j52hjksd9g0isdfg43",
            "leader_user_id": "ou_3j1kh45jk18fgh23hf",
            "chat_id": "oc_uiy325uy23bnv48gdf",
            "order": 100,
            "status": {
                "is_deleted": false
            },
            "leaders": [
                {
                    "leaderType": 1,
                    "leaderID": "ou_7dab8a3d3cdcc9da365777c7ad535d62"
                }
            ],
            "department_hrbps": [
                {
                    "union_id": "on_cad4860e7af114fb4ff6c5d496d1dd76",
                    "user_id": "98bc325a",
                    "open_id": "ou_c99c5f35d542efc7ee492afe11af19ef"
                }
            ]
        }
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Contact.Events.ContactDepartmentUpdatedV3EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}