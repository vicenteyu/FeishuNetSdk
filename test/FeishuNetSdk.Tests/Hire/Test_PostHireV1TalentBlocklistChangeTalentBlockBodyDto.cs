// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHireV1TalentBlocklistChangeTalentBlockBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 加入/移除屏蔽名单 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 加入/移除屏蔽名单 请求体
/// <para>接口ID：7413697955198091268</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/candidate-management/talent/change_talent_block</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent_blocklist%2fchange_talent_block</para>
/// </summary>
[TestClass]
public class Test_PostHireV1TalentBlocklistChangeTalentBlockBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "talent_id": "6930815272790114325",
    "option": 1,
    "reason": "人才作弊"
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1TalentBlocklistChangeTalentBlockBodyDto>(json);
        Assert.IsNotNull(result);
    }
}