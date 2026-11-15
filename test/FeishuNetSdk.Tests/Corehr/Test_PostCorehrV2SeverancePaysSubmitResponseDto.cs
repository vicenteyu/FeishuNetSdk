// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-11-15
//
// Last Modified By : yxr
// Last Modified On : 2026-11-15
// ************************************************************************
// <copyright file="Test_PostCorehrV2SeverancePaysSubmitResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 发起被动解除补偿金流程 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 发起被动解除补偿金流程 响应体
/// <para>接口ID：7667872540325743578</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/severance_pay/submit</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fseverance_pay%2fsubmit</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2SeverancePaysSubmitResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "severance_pay_id": "7660423757252773420",
        "employment_id": "7659617611689510444",
        "status": {
            "enum_name": "phone_type",
            "display": [
                {
                    "lang": "zh-CN",
                    "value": "中文示例"
                }
            ]
        },
        "process_id": "7660486572667979308",
        "created_time": "1783994400000"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2SeverancePaysSubmitResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}