// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchCorehrV2DepartmentsByDepartmentIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新部门 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 更新部门 请求体
/// <para>接口ID：7362022982037307395</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/department/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fdepartment%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchCorehrV2DepartmentsByDepartmentIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "id": "4719456877659520852",
    "sub_type": {
        "enum_name": "department"
    },
    "manager": "6893013238632416776",
    "is_confidential": true,
    "hiberarchy_common": {
        "parent_id": "4719168654814483759",
        "name": [
            {
                "lang": "zh-CN",
                "value": "中文示例"
            }
        ],
        "active": true,
        "code": "12456",
        "description": [
            {
                "lang": "zh-CN",
                "value": "中文示例"
            }
        ]
    },
    "effective_time": "2020-05-01 00:00:00",
    "custom_fields": [
        {
            "field_name": "name",
            "value": "Sandy"
        }
    ],
    "cost_center_id": "7142384817131652652",
    "staffing_model": {
        "enum_name": "job"
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PatchCorehrV2DepartmentsByDepartmentIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}