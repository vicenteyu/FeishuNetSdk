namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 批量查询部门操作日志 响应体
/// <para>接口ID：7439765965024165889</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/department/query_operation_logs</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fdepartment%2fquery_operation_logs</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2DepartmentsQueryOperationLogsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "op_logs": [
            {
                "object_id": "7094136522860922111",
                "changes": [
                    {
                        "field": "description",
                        "before": "old_description",
                        "after": "new_description"
                    }
                ],
                "operator": "工号001",
                "operation_type": 10,
                "operation_time": "2023-11-15 19:25:45",
                "effective_time": "2023-10-28",
                "operation_reason": "因人员调整,变更部门负责人为某某",
                "change_reasons": [
                    "新建部门"
                ]
            }
        ],
        "next_page_token": "2",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2DepartmentsQueryOperationLogsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}