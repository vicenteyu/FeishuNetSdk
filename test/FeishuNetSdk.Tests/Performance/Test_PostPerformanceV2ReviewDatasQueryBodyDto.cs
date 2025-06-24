// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostPerformanceV2ReviewDatasQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取绩效详情数据 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Performance;

/// <summary>
/// 测试 获取绩效详情数据 请求体
/// <para>接口ID：7351374599659847684</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/review_data/query-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2freview_data%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostPerformanceV2ReviewDatasQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "semester_ids": [
        "6992035450862224940"
    ],
    "reviewee_user_ids": [
        "ou_3245842393d09e9428ad4655da6e30b3"
    ],
    "stage_types": [
        "leader_review"
    ],
    "review_stage_roles": [
        "reviewee"
    ],
    "stage_ids": [
        "7343513161666707459"
    ],
    "need_leader_review_data_source": true,
    "updated_later_than": "1630425599999",
    "stage_progresses": [
        1
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Performance.PostPerformanceV2ReviewDatasQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}