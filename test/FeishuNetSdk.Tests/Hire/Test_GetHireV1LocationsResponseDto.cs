namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取地址列表 响应体
/// <para>接口ID：6990661791098683395</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/location/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2flocation%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHireV1LocationsResponseDto : TestBase
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
                "id": "1213213123123",
                "name": {
                    "zh_cn": "中国四川省成都市成华区熊猫大道 1375 号",
                    "en_us": "No. 1375, Panda Avenue, Chenghua District, Chengdu, Sichuan, China"
                },
                "district": {
                    "code": "MDCA00009061",
                    "name": {
                        "zh_cn": "高新区",
                        "en_us": "Gaoxin"
                    }
                },
                "city": {
                    "code": "CT_22",
                    "name": {
                        "zh_cn": "成都",
                        "en_us": "Chengdu"
                    }
                },
                "state": {
                    "code": "ST_15",
                    "name": {
                        "zh_cn": "四川",
                        "en_us": "Sichuan"
                    }
                },
                "country": {
                    "code": "CN_1",
                    "name": {
                        "zh_cn": "中国大陆",
                        "en_us": "Chinese Mainland"
                    }
                },
                "active_status": 1
            }
        ],
        "has_more": true,
        "page_token": "eyJvZmZzZXQiOjEwLCJ0aW1lc3RhbXAiOjE2Mjc1NTUyMjM2NzIsImlkIjpudWxsfQ=="
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1LocationsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}