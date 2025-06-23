namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 发起流程 响应体
/// <para>接口ID：7442599557486624772</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/flow/application-flow/execute</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-flow%2fexecute</para>
/// </summary>
[TestClass]
public class Test_PostApaasV1ApplicationsByNamespaceFlowsByFlowIdExecuteResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "code": "",
        "error_msg": "",
        "execution_id": "1816970091484211",
        "out_params": "[{\"api_name\":\"_flowExecutionID\",\"value\":1816970091484211}]",
        "status": "end"
    },
    "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.AppEngine.PostApaasV1ApplicationsByNamespaceFlowsByFlowIdExecuteResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}