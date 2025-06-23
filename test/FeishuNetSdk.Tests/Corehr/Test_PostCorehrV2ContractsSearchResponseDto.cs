namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 搜索合同 响应体
/// <para>接口ID：7248868628551303172</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/contract/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcontract%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2ContractsSearchResponseDto : TestBase
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
                "id": "7147527056140813828",
                "effective_time": "2023-01-01 00:00:00",
                "contract_end_date": "2024-01-01",
                "expiration_time": "2023-11-01 00:00:00",
                "employment_id": "6893014062142064135",
                "contract_type": {
                    "enum_name": "labor_contract",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "劳动合同"
                        }
                    ]
                },
                "first_party_company_id": "7091599096804394540",
                "person_id": "7088589447189022252",
                "duration_type": {
                    "enum_name": "fix_term",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "固定期限"
                        }
                    ]
                },
                "contract_number": "0000011",
                "signing_type": {
                    "enum_name": "new",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "新签"
                        }
                    ]
                },
                "contract_status": {
                    "enum_name": "contract_open",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "合同生效中"
                        }
                    ]
                },
                "renewal_status": {
                    "enum_name": "rejected",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "已拒绝"
                        }
                    ]
                },
                "signing_times": 1
            }
        ],
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2ContractsSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}