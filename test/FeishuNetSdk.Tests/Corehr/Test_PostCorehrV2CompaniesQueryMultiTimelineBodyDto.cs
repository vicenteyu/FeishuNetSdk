// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-01
//
// Last Modified By : yxr
// Last Modified On : 2026-03-01
// ************************************************************************
// <copyright file="Test_PostCorehrV2CompaniesQueryMultiTimelineBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询指定时间范围公司版本 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询指定时间范围公司版本 请求体
/// <para>接口ID：7473071080241545220</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/company/query_multi_timeline</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcompany%2fquery_multi_timeline</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2CompaniesQueryMultiTimelineBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "company_ids": [
        "7094136522860922111"
    ],
    "start_date": "2024-01-01",
    "end_date": "2024-12-31",
    "fields": [
        "company_name"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2CompaniesQueryMultiTimelineBodyDto>(json);
        Assert.IsNotNull(result);
    }
}