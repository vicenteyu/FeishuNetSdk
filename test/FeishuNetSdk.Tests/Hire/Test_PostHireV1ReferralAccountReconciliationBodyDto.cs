// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHireV1ReferralAccountReconciliationBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 内推账户提现数据对账 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 内推账户提现数据对账 请求体
/// <para>接口ID：7252281835550900226</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/referral_account/reconciliation</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2freferral_account%2freconciliation</para>
/// </summary>
[TestClass]
public class Test_PostHireV1ReferralAccountReconciliationBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "start_trans_time": "1685416831621",
    "end_trans_time": "1685416831622",
    "trade_details": [
        {
            "account_id": "6930815272790114324",
            "total_recharge_reward_info": {
                "point_bonus": 100
            }
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1ReferralAccountReconciliationBodyDto>(json);
        Assert.IsNotNull(result);
    }
}