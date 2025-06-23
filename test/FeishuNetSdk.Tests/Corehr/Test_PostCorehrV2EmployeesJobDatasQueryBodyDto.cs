namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 获取任职信息列表 请求体
/// <para>接口ID：7262387840977207297</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/employee/job_data/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2femployees-job_data%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2EmployeesJobDatasQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "get_all_version": false,
    "data_date": "2020-01-01",
    "effective_date_start": "2020-01-01",
    "effective_date_end": "2020-01-01",
    "department_id": "6891251722631890445",
    "employment_ids": [
        "7140964208476371111"
    ],
    "primary_job_data": true,
    "assignment_start_reasons": [
        "onboarding"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2EmployeesJobDatasQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}