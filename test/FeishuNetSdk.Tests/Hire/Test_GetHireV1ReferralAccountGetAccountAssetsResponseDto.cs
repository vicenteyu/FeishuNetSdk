namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 查询内推账户 响应体
/// <para>接口ID：7418831232862601217</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/referral_account/get_account_assets</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2freferral_account%2fget_account_assets</para>
/// </summary>
[TestClass]
public class Test_GetHireV1ReferralAccountGetAccountAssetsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "SUCCESS",
    "data": {
        "account": {
            "account_id": "6942778198054125570",
            "assets": {
                "confirmed_bonus": {
                    "point_bonus": 100,
                    "cash_bonus": [
                        {
                            "currency_type": "CNY",
                            "amount": 100
                        }
                    ]
                }
            },
            "status": 1,
            "referrer": {
                "id": "7413952589321914668",
                "name": {
                    "zh_cn": "张三",
                    "en_us": "zhangSan"
                },
                "email": "27188272xxxx1.com",
                "mobile": "1879087xxx8"
            }
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1ReferralAccountGetAccountAssetsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}