// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV1ContractsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 新建合同 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 新建合同 响应体
/// <para>接口ID：7017707615190876163</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/contract/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fcontract%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV1ContractsResponseDto : TestBase
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
            }
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.PostCorehrV1ContractsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}