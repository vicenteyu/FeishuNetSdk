namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 搜索员工信息 请求体
/// <para>接口ID：7211423970042167300</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/employee/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2femployee%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2EmployeesSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "fields": [
        "person_info.phone_number"
    ],
    "employment_id_list": [
        "7140964208476371111"
    ],
    "employee_number_list": [
        "100001"
    ],
    "work_email": "13312345678@qq.com",
    "phone_number": "16760342300",
    "key_word": "张三",
    "employment_status": "hired",
    "employee_type_id": "6971090097697521314",
    "department_id_list": [
        "7140964208476371111"
    ],
    "direct_manager_id_list": [
        "7027024823985117820"
    ],
    "dotted_line_manager_id_list": [
        "7027024823985117820"
    ],
    "regular_employee_start_date_start": "2020-01-01",
    "regular_employee_start_date_end": "2020-01-01",
    "effective_time_start": "2020-01-01",
    "effective_time_end": "2020-01-01",
    "work_location_id_list_include_sub": [
        "7140964208476371111"
    ],
    "preferred_english_full_name_list": [
        "Sandy"
    ],
    "preferred_local_full_name_list": [
        "小明"
    ],
    "national_id_number_list": [
        "110100xxxxxxxxxxxx"
    ],
    "phone_number_list": [
        "16760342300"
    ],
    "email_address_list": [
        "xxx@xxx.com"
    ],
    "department_id_list_include_sub": [
        "7140964208476371111"
    ],
    "additional_national_id_number_list": [
        "7140964208476371111"
    ],
    "citizenship_status_list": [
        "公民（中国大陆）"
    ],
    "cost_center_id_list": [
        "7140964208476371111"
    ],
    "service_company_list": [
        "7140964208476371111"
    ],
    "service_company_list_include_sub": [
        "7140964208476371111"
    ],
    "job_family_id_list": [
        "7140964208476371111"
    ],
    "job_family_id_list_include_sub": [
        "7140964208476371111"
    ],
    "job_level_id_list": [
        "7140964208476371111"
    ],
    "job_grade_id_list": [
        "7140964208476371111"
    ],
    "job_id_list": [
        "7140964208476371111"
    ],
    "position_id_list": [
        "7140964208476371111"
    ],
    "position_id_list_include_sub": [
        "7140964208476371111"
    ],
    "working_hours_type_id_list": [
        "7140964208476371111"
    ],
    "nationality_id_list": [
        "7140964208476371111"
    ],
    "pay_group_id_list": [
        "7140964208476371111"
    ],
    "assignment_pay_group_id_list": [
        "7140964208476371111"
    ],
    "contract_type_list": [
        "7140964208476371111"
    ],
    "archive_cpst_plan_id_list": [
        "7140964208476371111"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2EmployeesSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}