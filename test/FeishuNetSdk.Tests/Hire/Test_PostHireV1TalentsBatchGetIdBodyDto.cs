// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHireV1TalentsBatchGetIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量获取人才ID 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 批量获取人才ID 请求体
/// <para>接口ID：7125370772851458076</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent/batch_get_id</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent%2fbatch_get_id</para>
/// </summary>
[TestClass]
public class Test_PostHireV1TalentsBatchGetIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "mobile_code": "86",
    "mobile_number_list": [
        "182900291190"
    ],
    "email_list": [
        "foo@bytedance.com"
    ],
    "identification_type": 1,
    "identification_number_list": [
        "510403xxxxxxxx"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1TalentsBatchGetIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}