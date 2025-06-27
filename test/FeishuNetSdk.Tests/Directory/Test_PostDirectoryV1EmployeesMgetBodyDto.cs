// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostDirectoryV1EmployeesMgetBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量获取员工信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Directory;

/// <summary>
/// 测试 批量获取员工信息 请求体
/// <para>接口ID：7359428154233520132</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/employee/mget</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2femployee%2fmget</para>
/// </summary>
[TestClass]
public class Test_PostDirectoryV1EmployeesMgetBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "employee_ids": [
        "eefg22jdi"
    ],
    "required_fields": [
        "base_info.mobile"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Directory.PostDirectoryV1EmployeesMgetBodyDto>(json);
        Assert.IsNotNull(result);
    }
}