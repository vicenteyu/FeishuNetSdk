// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_HireReferralAccountAssetsUpdateV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 内推账户余额变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire.Events;

/// <summary>
/// 测试 内推账户余额变更 事件体
/// <para>接口ID：7252281835550916610</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/referral_account/events/assets_update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2freferral_account%2fevents%2fassets_update</para>
/// </summary>
[TestClass]
public class Test_HireReferralAccountAssetsUpdateV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "hire.referral_account.assets_update_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "account_id": "7147998241542539527",
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
        "modify_time": "1685431415036"
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Hire.Events.HireReferralAccountAssetsUpdateV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}