namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 查询地点列表 响应体
/// <para>接口ID：7385067676815949828</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/recruitment-related-configuration/location/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2flocation%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostHireV1LocationsQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
                "country": {
                    "country_code": "CN_1",
                    "country_name_info": {
                        "zh_name": "成都",
                        "en_name": "Chinese Mainland",
                        "py_name": "zhongguodalu"
                    }
                },
                "state": {
                    "state_code": "ST_1",
                    "country_code": "CN_1",
                    "state_name_info": {
                        "zh_name": "成都",
                        "en_name": "Liaoning",
                        "py_name": "liaoning"
                    }
                },
                "city": {
                    "city_code": "CT_1",
                    "state_code": "ST_1",
                    "country_code": "CN_1",
                    "city_name_info": {
                        "zh_name": "成都",
                        "en_name": "ChengDu",
                        "py_name": "chengdu"
                    }
                },
                "district": {
                    "district_code": "DS_70",
                    "city_code": "CT_1",
                    "state_code": "ST_1",
                    "country_code": "CN_1",
                    "district_name_info": {
                        "zh_name": "成都",
                        "en_name": "ChengDu",
                        "py_name": "chengdu"
                    }
                }
            }
        ],
        "has_more": true,
        "page_token": "eyJvZmZzZXQiOjEwLCJ0aW1lc3RhbXAiOjE2Mjc1NTUyMjM2NzIsImlkIjpudWxsfQ=="
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.PostHireV1LocationsQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}