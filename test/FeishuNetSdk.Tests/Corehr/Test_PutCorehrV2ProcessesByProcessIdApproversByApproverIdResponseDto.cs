namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 通过/拒绝审批任务 响应体
/// <para>接口ID：7340625370520797187</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/process-form_variable_data/approver-task/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprocess-approver%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutCorehrV2ProcessesByProcessIdApproversByApproverIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "code": 0,
        "msg": "错误原因"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PutCorehrV2ProcessesByProcessIdApproversByApproverIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}