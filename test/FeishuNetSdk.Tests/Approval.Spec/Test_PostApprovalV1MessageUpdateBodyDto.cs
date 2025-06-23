namespace FeishuNetSdk.Tests.Approval.Spec;

/// <summary>
/// 测试 更新审批 Bot 消息 请求体
/// <para>接口ID：6907569743419752450</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/message/update-bot-messages</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuAjNyYjLwYjM24CM2IjN</para>
/// </summary>
[TestClass]
public class Test_PostApprovalV1MessageUpdateBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "message_id":"xxxx",
    "status":"CUSTOM",
    "status_name":"@i18n@1",
    "detail_action_name":"@i18n@2",
    "i18n_resources":[
        {
          "locale": "zh-CN",
          "texts" : {
              "@i18n@1": "已废弃",
              "@i18n@2": "已废弃按钮" 
            },
          "is_default": true
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Approval.Spec.PostApprovalV1MessageUpdateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}