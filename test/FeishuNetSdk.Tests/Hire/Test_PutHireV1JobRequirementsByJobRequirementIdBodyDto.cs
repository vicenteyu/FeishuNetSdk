namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 更新招聘需求 请求体
/// <para>接口ID：6989078472837169155</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job_requirement/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob_requirement%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutHireV1JobRequirementsByJobRequirementIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "name": "HR部门春季招聘需求",
    "display_progress": 1,
    "head_count": 11,
    "recruitment_type_id": "101",
    "employee_type_id": "6807409776231254285",
    "max_level_id": "6807409776231254286",
    "min_level_id": "6807409776231254287",
    "sequence_id": "6911957338526091536",
    "category": 1,
    "department_id": "od-4e6ac4d14bcd5071a37a39de902c7141",
    "recruiter_id_list": [
        "od-4e6ac4d14bcd5071a37a39de902c7141"
    ],
    "jr_hiring_manager_id_list": [
        "ou_0c9b1b7b9b94146b9df142c349e3c4bf"
    ],
    "direct_leader_id_list": [
        "od-4e6ac4d14bcd5071a37a39de902c7141"
    ],
    "start_time": "1625729379000",
    "deadline": "1625729379000",
    "priority": 1,
    "required_degree": 1,
    "max_salary": "10",
    "min_salary": "5",
    "address_id": "7265901641899311105",
    "description": "部门人力紧缺，需要招聘资深工程师10名",
    "customized_data_list": [
        {
            "object_id": "1213213123123",
            "value": "简单文本"
        }
    ],
    "process_type": 1,
    "job_type_id": "6930815272790114324",
    "job_id_list": [
        "6930815272790114324"
    ],
    "employment_job_id": "6807407987381831949",
    "position_id": "7094136522860922111",
    "update_option": {
        "need_update_related_job": false
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PutHireV1JobRequirementsByJobRequirementIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}