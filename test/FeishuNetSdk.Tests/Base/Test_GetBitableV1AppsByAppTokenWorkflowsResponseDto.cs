namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 列出自动化流程 响应体
/// <para>接口ID：7447033368182571009</para>
/// <para>文档地址：https://open.feishu.cn/document/docs/bitable-v1/app-workflow/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-workflow%2flist</para>
/// </summary>
[TestClass]
public class Test_GetBitableV1AppsByAppTokenWorkflowsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "workflows": [
            {
                "workflow_id": "72934597xxxx9998484",
                "status": "Enable",
                "title": "流程 1"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Base.GetBitableV1AppsByAppTokenWorkflowsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}