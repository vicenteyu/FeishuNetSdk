// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostPerformanceV2AdditionalInformationsQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量查询补充信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Performance;

/// <summary>
/// 测试 批量查询补充信息 请求体
/// <para>接口ID：7371009404255617028</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/review_config/semester_activity/additional_information/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fadditional_information%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostPerformanceV2AdditionalInformationsQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "semester_id": "7348736302176534547",
    "item_ids": [
        "7350195758357807123"
    ],
    "external_ids": [
        "6789523104723558912"
    ],
    "reviewee_user_ids": [
        "ou_3245842393d09e9428ad4655da6e30b3"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Performance.PostPerformanceV2AdditionalInformationsQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}