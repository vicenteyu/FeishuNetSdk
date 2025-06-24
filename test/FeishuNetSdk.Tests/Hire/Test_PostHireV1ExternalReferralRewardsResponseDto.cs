// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHireV1ExternalReferralRewardsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 导入外部内推奖励 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 导入外部内推奖励 响应体
/// <para>接口ID：7325271522314584065</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/get-candidates/import-external-system-information/import-external-referral-reward-info/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexternal_referral_reward%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostHireV1ExternalReferralRewardsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "id": "6930815272790114324"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.PostHireV1ExternalReferralRewardsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}