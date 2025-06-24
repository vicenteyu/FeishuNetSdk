// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostApaasV1UserTasksByTaskIdChatGroupResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 基于人工任务发起群聊 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 基于人工任务发起群聊 响应体
/// <para>接口ID：7446337145820413956</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/flow/user-task/chat_group</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fuser_task%2fchat_group</para>
/// </summary>
[TestClass]
public class Test_PostApaasV1UserTasksByTaskIdChatGroupResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "chat_id": "ou_7d8a6e6df7621556ce0d21922b676706ccs"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.AppEngine.PostApaasV1UserTasksByTaskIdChatGroupResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}