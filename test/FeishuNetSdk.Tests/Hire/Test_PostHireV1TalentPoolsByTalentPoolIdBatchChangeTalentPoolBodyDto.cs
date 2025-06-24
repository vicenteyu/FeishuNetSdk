// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHireV1TalentPoolsByTalentPoolIdBatchChangeTalentPoolBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量加入/移除人才库中人才 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 批量加入/移除人才库中人才 请求体
/// <para>接口ID：7397677441913028636</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/candidate-management/talent_pool/batch_change_talent_pool</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent_pool%2fbatch_change_talent_pool</para>
/// </summary>
[TestClass]
public class Test_PostHireV1TalentPoolsByTalentPoolIdBatchChangeTalentPoolBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "talent_id_list": [
        "6930815272790114324"
    ],
    "option_type": 1
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1TalentPoolsByTalentPoolIdBatchChangeTalentPoolBodyDto>(json);
        Assert.IsNotNull(result);
    }
}