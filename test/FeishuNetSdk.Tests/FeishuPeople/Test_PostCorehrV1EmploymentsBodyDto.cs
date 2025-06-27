// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV1EmploymentsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建雇佣信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 创建雇佣信息 请求体
/// <para>接口ID：7072577767343718401</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/employee/employment/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2femployment%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV1EmploymentsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "seniority_date": "2020-01-01",
    "employee_number": "1000000",
    "effective_time": "2020-01-01 00:00:00",
    "expiration_time": "2020-01-01 00:00:00",
    "employment_type": {
        "enum_name": "employee"
    },
    "person_id": "6919733936050406926",
    "primary_employment": true,
    "employment_status": {
        "enum_name": "hired"
    },
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
    "ats_application_id": "6838119494196871234",
    "rehire": {
        "enum_name": "yes"
    },
    "rehire_employment_id": "7051837122449425964"
}
""";
        var result = Deserialize<FeishuNetSdk.FeishuPeople.PostCorehrV1EmploymentsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}