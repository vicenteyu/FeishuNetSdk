// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2PreHiresBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 直接创建待入职 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 直接创建待入职 请求体
/// <para>接口ID：7160511371865014276</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/pre_hire/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpre_hire%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2PreHiresBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "basic_info": {
        "name": {
            "full_name": "李一一",
            "first_name": "一",
            "middle_name": "一",
            "name_primary": "李",
            "local_first_name": "一",
            "local_middle_name": "一",
            "local_primary": "李"
        },
        "phone_number": "138xxxx1234",
        "international_area_code": "86_china",
        "email": "xxxx@bytedance.com",
        "date_of_birth": "2011-99-99",
        "personal_id_number": "311xxxx23127",
        "date_entered_workforce": "2100-09-09",
        "gender_id": "male",
        "nationality_id": "6862995xxxx34914824",
        "home_address": "home addr",
        "worker_id": "6862995757234914824"
    },
    "offer_info": {
        "offer_id": "7032210902531327521",
        "offer_hr_id": "7032210902531327521",
        "department_id": "7147562782945478177",
        "direct_leader_id": "7032210902531327521",
        "job_id": "6977976735715378724",
        "job_family_id": "6977972856625939999",
        "job_level_id": "6977971894960145950",
        "job_title": "java",
        "probation_start_date": "2022-07-29",
        "probation_end_date": "2023-04-07",
        "contract_start_date": "2022-10-08",
        "contract_end_date": "2025-10-07",
        "onboarding_date": "2022-10-08",
        "onboarding_location_id": "6977976687350924832",
        "office_location_id": "6977976687350924832",
        "recruitment_type_id": "experienced_professionals",
        "probation_period": "6",
        "employee_type_id": "6977973225846343171",
        "employment_type_id": "6977973225846343171",
        "work_email": "xxxx@bytedance.com",
        "duration_type_id": "6977973225846343171",
        "signing_type_id": "6738317738688661772",
        "entry_mode": "1",
        "social_security_city_id": "xxx",
        "contract_type": "6738317738688661772",
        "company": "6738317738688661772",
        "custom_fields": [
            {
                "field_name": "name",
                "value": "Sandy"
            }
        ]
    },
    "education_info": [
        {
            "school_name": "长安大学",
            "education": "phd",
            "start_time": "2017-04-01",
            "end_time": "2018-04-01",
            "field_of_study": "医学影像技术"
        }
    ],
    "work_experience": [
        {
            "company_name": "猎豹",
            "start_time": "2015-02-01",
            "end_time": "2017-02-01",
            "job_title": "产品经理",
            "description": "app"
        }
    ],
    "ats_application_id": "7140946969586010376",
    "out_biz_id": "7140946969586010376"
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2PreHiresBodyDto>(json);
        Assert.IsNotNull(result);
    }
}