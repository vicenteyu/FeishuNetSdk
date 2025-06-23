namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 更新账号自定义字段 请求体
/// <para>接口ID：7195815979079434241</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_account_custom_field/batch_update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_account_custom_field%2fbatch_update</para>
/// </summary>
[TestClass]
public class Test_PatchHireV1EcoAccountCustomFieldsBatchUpdateBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "scope": 1,
    "custom_field_list": [
        {
            "key": "account_token",
            "name": {
                "zh_cn": "账号token",
                "en_us": "Account token"
            },
            "is_required": true,
            "description": {
                "zh_cn": "账号的唯一标识，可联系客服获取",
                "en_us": "The unique identifier of the account can be obtained by contacting the customer service"
            }
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PatchHireV1EcoAccountCustomFieldsBatchUpdateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}