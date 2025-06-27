// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostPerformanceV2IndicatorsQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取评估项列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Performance;

/// <summary>
/// 测试 获取评估项列表 响应体
/// <para>接口ID：7351374599659798532</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/review_config/review_template/query-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2findicator%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostPerformanceV2IndicatorsQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "indicators": [
            {
                "id": "7343513161666707459",
                "name": {
                    "zh_cn": "完成度",
                    "en_us": "Completeness"
                },
                "type": "plus",
                "options": [
                    {
                        "id": "7343513161666707459",
                        "name": {
                            "zh_cn": "等级 1",
                            "en_us": "Rank 1"
                        },
                        "lable": "qwerty"
                    }
                ]
            }
        ],
        "has_more": true,
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0="
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Performance.PostPerformanceV2IndicatorsQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}