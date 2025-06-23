namespace FeishuNetSdk.Tests.Performance;

/// <summary>
/// 测试 获取标签填写题配置 响应体
/// <para>接口ID：7351374599659814916</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/review_config/review_template/query-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fquestion%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostPerformanceV2QuestionsQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "tag_based_questions": [
            {
                "question_id": "7343513161666707459",
                "name": {
                    "zh_cn": "体验",
                    "en_us": "Interactive experience"
                },
                "tag_items": [
                    {
                        "id": "7343513161666707459",
                        "name": {
                            "zh_cn": "体验",
                            "en_us": "Interactive experience"
                        }
                    }
                ]
            }
        ],
        "has_more": true,
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0="
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Performance.PostPerformanceV2QuestionsQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}