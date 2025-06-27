// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostApaasV1UserTasksByTaskIdChatGroupBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 基于人工任务发起群聊 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 基于人工任务发起群聊 请求体
/// <para>接口ID：7446337145820413956</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/flow/user-task/chat_group</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fuser_task%2fchat_group</para>
/// </summary>
[TestClass]
public class Test_PostApaasV1UserTasksByTaskIdChatGroupBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "operator_user_id": "1234",
    "invite_user_ids": [
        "1234"
    ],
    "chat_id": "oc_1234",
    "chat_name": "群名称"
}
""";
        var result = Deserialize<FeishuNetSdk.AppEngine.PostApaasV1UserTasksByTaskIdChatGroupBodyDto>(json);
        Assert.IsNotNull(result);
    }
}