namespace FeishuNetSdk.Tests.Approval.Spec;

/// <summary>
/// 测试 更新审批 Bot 消息 响应体
/// <para>接口ID：6907569743419752450</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/message/update-bot-messages</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuAjNyYjLwYjM24CM2IjN</para>
/// </summary>
[TestClass]
public class Test_PostApprovalV1MessageUpdateResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code":0,
    "msg":"success",
    "data":{
        "message_id": "xxxx"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Approval.Spec.PostApprovalV1MessageUpdateResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}