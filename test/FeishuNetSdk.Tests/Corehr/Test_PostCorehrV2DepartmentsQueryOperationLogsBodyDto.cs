namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 批量查询部门操作日志 请求体
/// <para>接口ID：7439765965024165889</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/department/query_operation_logs</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fdepartment%2fquery_operation_logs</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2DepartmentsQueryOperationLogsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "department_ids": [
        "7094136522860922222"
    ],
    "start_date": "2023-01-01",
    "end_date": "2024-01-01"
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2DepartmentsQueryOperationLogsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}