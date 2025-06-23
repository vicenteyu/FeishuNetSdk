namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 更新合同 响应体
/// <para>接口ID：7072977430599892994</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/contract/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fcontract%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchCorehrV1ContractsByContractIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "contract": {
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
                "enum_name": "fixed_term",
                "display": [
                    {
                        "lang": "zh-CN",
                        "value": "固定期限类型合同"
                    }
                ]
            },
            "contract_end_date": "2006-01-02",
            "contract_number": "6919737965274990093",
            "signing_type": {
                "enum_name": "changed",
                "display": [
                    {
                        "lang": "zh-CN",
                        "value": "变更"
                    }
                ]
            },
            "contract_status": {
                "enum_name": "phone_type",
                "display": [
                    {
                        "lang": "zh-CN",
                        "value": "刘梓新"
                    }
                ]
            },
            "renewal_status": {
                "enum_name": "phone_type",
                "display": [
                    {
                        "lang": "zh-CN",
                        "value": "刘梓新"
                    }
                ]
            },
            "signing_times": 1
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.PatchCorehrV1ContractsByContractIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}