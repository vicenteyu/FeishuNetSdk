// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHireV1ReferralAccountEnableResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 启用内推账户 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 启用内推账户 响应体
/// <para>接口ID：7418831232862584833</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/referral_account/enable</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2freferral_account%2fenable</para>
/// </summary>
[TestClass]
public class Test_PostHireV1ReferralAccountEnableResponseDto : TestBase
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
            "status": 1
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.PostHireV1ReferralAccountEnableResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}