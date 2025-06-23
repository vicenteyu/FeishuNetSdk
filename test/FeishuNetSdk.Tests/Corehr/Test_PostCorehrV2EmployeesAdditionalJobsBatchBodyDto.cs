namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 批量查询兼职信息 请求体
/// <para>接口ID：7387981900317589506</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/employee/job_data/employees-additional_job/batch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2femployees-additional_job%2fbatch</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2EmployeesAdditionalJobsBatchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "employment_ids": [
        "7140964208476371111"
    ],
    "additional_job_ids": [
        "7140964208476371111"
    ],
    "start_date": {
        "start": "2024-01-01",
        "end": "2024-01-01"
    },
    "end_date": {
        "start": "2024-01-01",
        "end": "2024-01-01"
    },
    "data_date": "2024-01-02",
    "is_effective": true
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2EmployeesAdditionalJobsBatchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}