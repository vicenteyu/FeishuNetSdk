namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 更新合同 请求体
/// <para>接口ID：7072977430599892994</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/contract/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fcontract%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchCorehrV1ContractsByContractIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "effective_time": "2050-01-01 00:00:00",
    "expiration_time": "9999-12-31 23:59:59",
    "employment_id": "空",
    "contract_type": {
        "enum_name": "labor_contract"
    },
    "first_party_company_id": "6892686614112241165",
    "person_id": "空",
    "custom_fields": [
        {
            "field_name": "name",
            "value": "Sandy"
        }
    ],
    "duration_type": {
        "enum_name": "open_ended"
    },
    "contract_end_date": "2006-01-02",
    "contract_number": "6919737965274990093",
    "signing_type": {
        "enum_name": "new"
    }
}
""";
        var result = Deserialize<FeishuNetSdk.FeishuPeople.PatchCorehrV1ContractsByContractIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}