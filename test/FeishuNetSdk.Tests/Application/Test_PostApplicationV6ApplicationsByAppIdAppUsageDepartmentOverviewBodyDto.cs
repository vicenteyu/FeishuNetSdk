// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostApplicationV6ApplicationsByAppIdAppUsageDepartmentOverviewBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取多部门应用使用概览 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Application;

/// <summary>
/// 测试 获取多部门应用使用概览 请求体
/// <para>接口ID：7036626399368937500</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/app-usage/department_overview</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-app_usage%2fdepartment_overview</para>
/// </summary>
[TestClass]
public class Test_PostApplicationV6ApplicationsByAppIdAppUsageDepartmentOverviewBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "date": "2021-10-11",
    "cycle_type": 1,
    "department_id": "dfd2f9g16dd75ggd",
    "recursion": 2,
    "page_size": 10,
    "page_token": "new-f556d0f964cf4baab7092b5b0093317c"
}
""";
        var result = Deserialize<FeishuNetSdk.Application.PostApplicationV6ApplicationsByAppIdAppUsageDepartmentOverviewBodyDto>(json);
        Assert.IsNotNull(result);
    }
}