// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV1JobDatasBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建任职信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 创建任职信息 请求体
/// <para>接口ID：7017694651622047748</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/employee/job_data/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fjob_data%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV1JobDatasBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "job_level_id": "6890452208593372679",
    "job_grade_id": "6890452208593372679",
    "employee_type_id": "6890452208593372679",
    "working_hours_type_id": "6890452208593372679",
    "work_location_id": "6890452208593372679",
    "department_id": "6890452208593372679",
    "job_id": "6890452208593372679",
    "probation_start_date": "2018-03-16",
    "probation_end_date": "2019-05-24",
    "primary_job_data": true,
    "employment_id": "6893014062142064135",
    "effective_time": "2020-05-01 00:00:00",
    "expiration_time": "2020-05-02 00:00:00",
    "job_family_id": "1245678",
    "assignment_start_reason": {
        "enum_name": "onboarding"
    },
    "probation_expected_end_date": "2006-01-02",
    "direct_manager_id": "6890452208593372679",
    "dotted_line_manager_id_list": [
        "6890452208593372681"
    ],
    "second_direct_manager_id": "6890452208593372679",
    "cost_center_rate": [
        {
            "cost_center_id": "6950635856373745165",
            "rate": 100
        }
    ],
    "work_shift": {
        "enum_name": "example"
    },
    "compensation_type": {
        "enum_name": "example"
    },
    "service_company": "6890452208593372680",
    "position_id": "6890452208593372679",
    "pathway_id": "6890452208593372671"
}
""";
        var result = Deserialize<FeishuNetSdk.FeishuPeople.PostCorehrV1JobDatasBodyDto>(json);
        Assert.IsNotNull(result);
    }
}