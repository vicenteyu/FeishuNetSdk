namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 搜索猎头供应商列表 响应体
/// <para>接口ID：7413697955198074884</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/get-candidates/agency/batch_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fagency%2fbatch_query</para>
/// </summary>
[TestClass]
public class Test_PostHireV1AgenciesBatchQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "SUCCESS",
    "data": {
        "has_more": true,
        "page_token": "eyJvZmZzZXQiOjEsInRpbWVzdGFtcCI6MTY0MDc2NTYzMjA4OCwiaWQiOm51bGx9",
        "items": [
            {
                "id": "7398493486516799788",
                "name": "北极无敌猎头",
                "label_list": [
                    {
                        "id": "6887469228283299336",
                        "name": {
                            "zh_cn": "东方树叶",
                            "en_us": "oriental Leaves"
                        }
                    }
                ],
                "admin_list": [
                    {
                        "user_id": "7398493486516799788",
                        "name": {
                            "zh_cn": "张三",
                            "en_us": "ZhangSan"
                        },
                        "email": "283xxxx2171813@qq.com"
                    }
                ],
                "agency_protect_time": {
                    "day": 180,
                    "use_default": true
                },
                "cooperation_create_time": "1639992265035",
                "cooperation_start_time": "1639992265035",
                "cooperation_end_time": "1639992265035",
                "cooperation_status": 1,
                "invite_email": "28933718393.qq.com",
                "supplier_area": 1,
                "talent_protect_time": {
                    "day": 180,
                    "use_default": true,
                    "forever": true
                }
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.PostHireV1AgenciesBatchQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}