// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_DeleteContactV3UsersByUserIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 删除用户 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 删除用户 请求体
/// <para>接口ID：6943913881476907035</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/user/delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fuser%2fdelete</para>
/// </summary>
[TestClass]
public class Test_DeleteContactV3UsersByUserIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "department_chat_acceptor_user_id": "ou_7dab8a3d3cdcc9da365777c7ad535d62",
    "external_chat_acceptor_user_id": "ou_7dab8a3d3cdcc9da365777c7ad535d62",
    "docs_acceptor_user_id": "ou_7dab8a3d3cdcc9da365777c7ad535d62",
    "calendar_acceptor_user_id": "ou_7dab8a3d3cdcc9da365777c7ad535d62",
    "application_acceptor_user_id": "ou_7dab8a3d3cdcc9da365777c7ad535d62",
    "email_acceptor": {
        "processing_type": "1",
        "acceptor_user_id": "ou_7dab8a3d3cdcc9da365777c7ad535d62"
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Contact.DeleteContactV3UsersByUserIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}