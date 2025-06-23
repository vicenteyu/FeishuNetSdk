namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 新建职位 请求体
/// <para>接口ID：7012986483075481601</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job/combined_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob%2fcombined_create</para>
/// </summary>
[TestClass]
public class Test_PostHireV1JobsCombinedCreateBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": "R18",
    "experience": 1,
    "expiry_time": 1622484739,
    "customized_data_list": [
        {
            "object_id": "7281257045172308287",
            "value": "职位特殊要求"
        }
    ],
    "min_level_id": "7281257045172308287",
    "min_salary": 1000,
    "title": "后端研发",
    "job_managers": {
        "id": "7281257045172308287",
        "recruiter_id": "ou_efk39117c300506837def50545420c6a",
        "hiring_manager_id_list": [
            "on_94a1ee5551019f18cd73d9f111898cf2"
        ],
        "assistant_id_list": [
            "on_94a1ee5551019f18cd73d9f111898cf2"
        ]
    },
    "job_process_id": "6960663240925956554",
    "process_type": 1,
    "subject_id": "6960663240925956555",
    "job_function_id": "6960663240925956555",
    "department_id": "od-b2fafdce6fc5800b574ba5b0e2798b36",
    "head_count": 100,
    "is_never_expired": false,
    "max_salary": 2000,
    "requirement": "熟悉后端研发",
    "description": "后端研发岗位描述",
    "highlight_list": [
        "6732430418202593547"
    ],
    "job_type_id": "6960663240925956551",
    "max_level_id": "6960663240925956548",
    "recruitment_type_id": "102",
    "required_degree": 20,
    "job_category_id": "6960663240925956550",
    "address_id_list": [
        "7243965681799839748"
    ],
    "job_attribute": 1,
    "expiry_timestamp": "1622484739955",
    "interview_registration_schema_id": "6930815272790114324",
    "onboard_registration_schema_id": "6930815272790114325",
    "target_major_id_list": [
        "MDMJ00000067"
    ],
    "portal_website_apply_form_schema_id": "7397638158859323692"
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1JobsCombinedCreateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}