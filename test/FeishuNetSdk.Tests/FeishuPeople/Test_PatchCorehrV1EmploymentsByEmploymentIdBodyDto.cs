namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 更新雇佣信息 请求体
/// <para>接口ID：7072588598729981980</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/employee/employment/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2femployment%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchCorehrV1EmploymentsByEmploymentIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "seniority_date": "2020-01-01",
    "employee_number": "1000000",
    "employment_type": {
        "enum_name": "employee"
    },
    "person_id": "6919733936050406926",
    "primary_employment": true,
    "custom_fields": [
        {
            "field_name": "name",
            "value": "\"Sandy\""
        }
    ],
    "work_email_list": [
        {
            "email": "12456@test.com",
            "is_primary": true,
            "is_public": true,
            "email_usage": {
                "enum_name": "work"
            },
            "custom_fields": [
                {
                    "field_name": "name",
                    "value": "\"Sandy\""
                }
            ]
        }
    ],
    "reason_for_offboarding": {
        "enum_name": "voluntary"
    },
    "ats_application_id": "6838119494196871234"
}
""";
        var result = Deserialize<FeishuNetSdk.FeishuPeople.PatchCorehrV1EmploymentsByEmploymentIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}