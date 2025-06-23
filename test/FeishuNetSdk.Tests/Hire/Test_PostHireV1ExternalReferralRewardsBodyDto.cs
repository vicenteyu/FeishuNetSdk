namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 导入外部内推奖励 请求体
/// <para>接口ID：7325271522314584065</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/get-candidates/import-external-system-information/import-external-referral-reward-info/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexternal_referral_reward%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostHireV1ExternalReferralRewardsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "referral_user_id": "on_94a1ee5551019f18cd73d9f111898cf2",
    "create_user_id": "on_94a1ee5551019f18cd73d9f111898cf2",
    "confirm_user_id": "on_94a1ee5551019f18cd73d9f111898cf2",
    "pay_user_id": "on_94a1ee5551019f18cd73d9f111898cf2",
    "external_id": "6930815272790114324",
    "application_id": "6930815272790114325",
    "talent_id": "6930815272790114326",
    "job_id": "6930815272790114327",
    "reason": "入职｜开源",
    "rule_type": 1,
    "bonus": {
        "bonus_type": 1,
        "point_bonus": 100,
        "cash": {
            "currency_type": "CNY",
            "amount": 100
        }
    },
    "stage": 1,
    "create_time": "1704720275000",
    "confirm_time": "1704720275000",
    "pay_time": "1704720275001",
    "onboard_time": "1704720275002",
    "conversion_time": "1704720275003",
    "comment": "已发放"
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1ExternalReferralRewardsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}