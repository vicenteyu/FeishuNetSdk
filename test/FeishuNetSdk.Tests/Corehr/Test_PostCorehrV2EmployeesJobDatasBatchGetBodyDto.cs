namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 批量查询员工任职信息 请求体
/// <para>接口ID：7262387840977223681</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/employee/job_data/batch_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2femployees-job_data%2fbatch_get</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2EmployeesJobDatasBatchGetBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "employment_ids": [
        "7140964208476371111"
    ],
    "get_all_version": false,
    "effective_date_start": "2020-01-01",
    "effective_date_end": "2020-01-01",
    "data_date": "2020-01-01",
    "primary_job_data": true,
    "assignment_start_reasons": [
        "onboarding"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2EmployeesJobDatasBatchGetBodyDto>(json);
        Assert.IsNotNull(result);
    }
}