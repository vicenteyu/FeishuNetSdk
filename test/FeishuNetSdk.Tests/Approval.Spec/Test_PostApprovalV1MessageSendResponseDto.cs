// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostApprovalV1MessageSendResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 发送审批 Bot 消息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Approval.Spec;

/// <summary>
/// 测试 发送审批 Bot 消息 响应体
/// <para>接口ID：6907569742384906242</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/message/send-bot-messages</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fugDNyYjL4QjM24CO0IjN</para>
/// </summary>
[TestClass]
public class Test_PostApprovalV1MessageSendResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code":0,
    "msg":"success",
    "data":{
        "message_id": "6968359519504171036"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Approval.Spec.PostApprovalV1MessageSendResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}