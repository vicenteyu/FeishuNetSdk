// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-01
//
// Last Modified By : yxr
// Last Modified On : 2025-08-01
// ************************************************************************
// <copyright file="Test_PostCorehrV2JobsQueryMultiTimelineBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询指定时间范围职务版本 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询指定时间范围职务版本 请求体
/// <para>接口ID：7473071080241577988</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job-management/job/query_multi_timeline</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob%2fquery_multi_timeline</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2JobsQueryMultiTimelineBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "job_ids": [
        "7094136522860922111"
    ],
    "start_date": "2024-01-01",
    "end_date": "2024-12-31",
    "fields": [
        "job_name"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2JobsQueryMultiTimelineBodyDto>(json);
        Assert.IsNotNull(result);
    }
}