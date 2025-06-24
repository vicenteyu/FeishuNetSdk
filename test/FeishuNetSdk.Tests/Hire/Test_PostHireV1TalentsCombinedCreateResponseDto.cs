// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHireV1TalentsCombinedCreateResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建人才 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 创建人才 响应体
/// <para>接口ID：7034053377010991105</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent/combined_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent%2fcombined_create</para>
/// </summary>
[TestClass]
public class Test_PostHireV1TalentsCombinedCreateResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "ok",
    "data": {
        "talent_id": "7021471300428613932",
        "creator_id": "ou_84aad35d084aa403a838cf73ee18467",
        "creator_account_type": 1
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.PostHireV1TalentsCombinedCreateResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}