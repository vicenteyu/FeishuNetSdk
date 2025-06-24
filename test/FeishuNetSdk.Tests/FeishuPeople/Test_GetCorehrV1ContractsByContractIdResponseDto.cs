// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetCorehrV1ContractsByContractIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询单个合同 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 查询单个合同 响应体
/// <para>接口ID：7017694651621883908</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/contract/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fcontract%2fget</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV1ContractsByContractIdResponseDto : TestBase
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
                "enum_name": "internship_agreement",
                "display": [
                    {
                        "lang": "zh-CN",
                        "value": "实习协议"
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
                "enum_name": "open_ended",
                "display": [
                    {
                        "lang": "zh-CN",
                        "value": "无固定期限"
                    }
                ]
            },
            "contract_end_date": "2006-01-02",
            "contract_number": "6919737965274990093",
            "signing_type": {
                "enum_name": "renewed",
                "display": [
                    {
                        "lang": "zh-CN",
                        "value": "续签"
                    }
                ]
            },
            "contract_status": {
                "enum_name": "contract_closed",
                "display": [
                    {
                        "lang": "zh-CN",
                        "value": "已终止"
                    }
                ]
            },
            "renewal_status": {
                "enum_name": "not_started",
                "display": [
                    {
                        "lang": "zh-CN",
                        "value": "未发起"
                    }
                ]
            },
            "signing_times": 1
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.GetCorehrV1ContractsByContractIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}