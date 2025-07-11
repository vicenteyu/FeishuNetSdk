// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostDirectoryV1EmployeesSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 搜索员工 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Directory;

/// <summary>
/// 测试 搜索员工信息 请求体
/// <para>接口ID：7359428154233618436</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/employee/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2femployee%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostDirectoryV1EmployeesSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "query": "zhang",
    "page_request": {
        "page_size": 10,
        "page_token": "asdjiowers"
    },
    "required_fields": [
        "base_info.name.name"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Directory.PostDirectoryV1EmployeesSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}