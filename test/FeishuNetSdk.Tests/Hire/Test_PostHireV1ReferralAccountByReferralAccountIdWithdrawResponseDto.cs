namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 全额提取内推账户余额 响应体
/// <para>接口ID：7252281835550883842</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/referral_account/withdraw</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2freferral_account%2fwithdraw</para>
/// </summary>
[TestClass]
public class Test_PostHireV1ReferralAccountByReferralAccountIdWithdrawResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "SUCCESS",
    "data": {
        "external_order_id": "6942778198054125570",
        "trans_time": "1683634459543",
        "withdrawal_details": {
            "point_bonus": 100,
            "cash_bonus": [
                {
                    "currency_type": "CNY",
                    "amount": 100
                }
            ]
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.PostHireV1ReferralAccountByReferralAccountIdWithdrawResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}