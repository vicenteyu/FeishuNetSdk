// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-07-05
//
// Last Modified By : yxr
// Last Modified On : 2026-07-05
// ************************************************************************
// <copyright file="Test_PostApaasV1TenantAppMetricsQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取应用运营数据 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 获取应用运营数据 请求体
/// <para>接口ID：7600074707548146916</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/apaas-v1/tenant_app_metrics/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2ftenant_app_metrics%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostApaasV1TenantAppMetricsQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "namespaces": [
        "package_a__c"
    ],
    "date": "2006-01-02"
}
""";
        var result = Deserialize<FeishuNetSdk.AppEngine.PostApaasV1TenantAppMetricsQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}