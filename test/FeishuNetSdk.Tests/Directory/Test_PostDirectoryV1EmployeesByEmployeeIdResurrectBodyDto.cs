// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostDirectoryV1EmployeesByEmployeeIdResurrectBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 恢复离职员工 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Directory;

/// <summary>
/// 测试 恢复离职员工 请求体
/// <para>接口ID：7359428234122821636</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/employee/resurrect</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2femployee%2fresurrect</para>
/// </summary>
[TestClass]
public class Test_PostDirectoryV1EmployeesByEmployeeIdResurrectBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "employee_order_in_departments": [
        {
            "department_id": "easdiedqds",
            "order_weight_in_deparment": "100",
            "order_weight_among_deparments": "20",
            "is_main_department": true
        }
    ],
    "options": {
        "subscription_ids": [
            "435456345245"
        ]
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Directory.PostDirectoryV1EmployeesByEmployeeIdResurrectBodyDto>(json);
        Assert.IsNotNull(result);
    }
}