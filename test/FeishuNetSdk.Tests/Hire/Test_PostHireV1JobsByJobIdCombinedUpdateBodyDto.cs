// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHireV1JobsByJobIdCombinedUpdateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新职位 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 更新职位 请求体
/// <para>接口ID：7012986483075497985</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job/combined_update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob%2fcombined_update</para>
/// </summary>
[TestClass]
public class Test_PostHireV1JobsByJobIdCombinedUpdateBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "id": "6960663240925956576",
    "experience": 1,
    "expiry_time": 1622484739,
    "customized_data_list": [
        {
            "object_id": "6960663240925956549",
            "value": "自定义内容"
        }
    ],
    "min_level_id": "6960663240925956547",
    "min_salary": 1000,
    "title": "后端研发",
    "job_managers": {
        "id": "1618209327096",
        "recruiter_id": "ou_efk39117c300506837def50545420c6a",
        "hiring_manager_id_list": [
            "on_94a1ee5551019f18cd73d9f111898cf2"
        ],
        "assistant_id_list": [
            "on_94a1ee5551019f18cd73d9f111898cf2"
        ]
    },
    "job_process_id": "6960663240925956554",
    "subject_id": "6960663240925956555",
    "job_function_id": "6960663240925956555",
    "department_id": "od-b2fafdce6fc5800b574ba5b0e2798b36",
    "head_count": 100,
    "is_never_expired": false,
    "max_salary": 2000,
    "requirement": "熟悉后端研发",
    "description": "后端研发岗位描述",
    "highlight_list": [
        "6887476508052523278"
    ],
    "job_type_id": "6960663240925956551",
    "max_level_id": "6960663240925956548",
    "required_degree": 20,
    "job_category_id": "6960663240925956550",
    "address_id_list": [
        "6960663240925956553"
    ],
    "job_attribute": 6960663240925956554,
    "expiry_timestamp": "1622484739955",
    "target_major_id_list": [
        "MDMJ00000067"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1JobsByJobIdCombinedUpdateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}