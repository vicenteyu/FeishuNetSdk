// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV1OffboardingsSubmitBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 操作员工离职 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 操作员工离职 请求体
/// <para>接口ID：7097044451155214340</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/offboarding/submit</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2foffboarding%2fsubmit</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV1OffboardingsSubmitBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "offboarding_mode": 1,
    "employment_id": "6982509313466189342",
    "offboarding_date": "2022-05-18",
    "offboarding_reason_unique_identifier": "reason_for_offboarding_option8",
    "offboarding_reason_explanation": "离职原因说明",
    "initiator_id": "6982509313466189341",
    "add_block_list": false,
    "block_reason": "红线",
    "block_reason_explanation": "xx 年 xx 月 xx 日因 xx 原因红线",
    "custom_fields": [
        {
            "field_name": "name",
            "value": "\"Sandy\""
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.FeishuPeople.PostCorehrV1OffboardingsSubmitBodyDto>(json);
        Assert.IsNotNull(result);
    }
}