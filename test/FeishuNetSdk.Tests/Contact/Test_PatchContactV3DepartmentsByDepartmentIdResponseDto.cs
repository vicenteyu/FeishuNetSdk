// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchContactV3DepartmentsByDepartmentIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 修改部门部分信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 修改部门部分信息 响应体
/// <para>接口ID：6943913881476923419</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/department/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fdepartment%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchContactV3DepartmentsByDepartmentIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code":0,
    "msg":"success",
    "data":{
        "department":{
            "name":"DemoName",
            "i18n_name":{
                "zh_cn":"Demo名称",
                "ja_jp":"デモ名",
                "en_us":"Demo Name"
            },
            "parent_department_id":"D067",
            "department_id":"D096",
            "open_department_id":"od-4e6ac4d14bcd5071a37a39de902c7141",
            "leader_user_id":"ou_7dab8a3d3cdcc9da365777c7ad535d62",
            "chat_id":"oc_5ad11d72b830411d72b836c20",
            "order":"100",
            "unit_ids":[
                "custom_unit_id"
            ],
            "member_count":100,
            "status":{
                "is_deleted":false
            },
            "leaders":[
                {
                    "leaderID":"ou_357368f98775f04bea02afc6b1d33478",
                    "leaderType":1
                }
            ],
            "department_hrbps":[
                "ou_7dab8a3d3cdcc9da365777c7ad535d62",
                "ou_7dab8a3d3cdcc9da365777c7ad535d63"
            ]
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Contact.PatchContactV3DepartmentsByDepartmentIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}