namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 查询人工任务可退回的位置 响应体
/// <para>接口ID：7446337145820381188</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/flow/user-task/rollback_points</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fuser_task%2frollback_points</para>
/// </summary>
[TestClass]
public class Test_PostApaasV1UserTasksByTaskIdRollbackPointsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "tasks": [
            {
                "id": "1234",
                "activity_label": [
                    {
                        "language_code": "2052",
                        "text": "人工任务名称"
                    }
                ],
                "is_start": false
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.AppEngine.PostApaasV1UserTasksByTaskIdRollbackPointsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}