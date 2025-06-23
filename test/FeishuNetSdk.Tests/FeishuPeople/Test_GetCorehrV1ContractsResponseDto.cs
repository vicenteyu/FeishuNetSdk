namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 批量查询合同 响应体
/// <para>接口ID：7017707615191121923</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/contract/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fcontract%2flist</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV1ContractsResponseDto : TestBase
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
                "id": "6919737965274990093",
                "effective_time": "2050-01-01 00:00:00",
                "expiration_time": "9999-12-31 23:59:59",
                "employment_id": "6893013238632416776",
                "contract_type": {
                    "enum_name": "labor_contract",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "劳动合同"
                        }
                    ]
                },
                "first_party_company_id": "6892686614112241165",
                "person_id": "151515151",
                "custom_fields": [
                    {
                        "field_name": "name",
                        "value": "Sandy"
                    }
                ],
                "duration_type": {
                    "enum_name": "fix_term",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "固定期限类型"
                        }
                    ]
                },
                "contract_end_date": "2006-01-02",
                "contract_number": "6919737965274990093",
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
                    "enum_name": "to_be_effective",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "待生效"
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
        "has_more": true,
        "page_token": "1234452132"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.GetCorehrV1ContractsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}