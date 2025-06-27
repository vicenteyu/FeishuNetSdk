// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostMailV1PublicMailboxesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建公共邮箱 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 创建公共邮箱 响应体
/// <para>接口ID：6954915601882677251</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/public-mailbox/public_mailbox/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fpublic_mailbox%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostMailV1PublicMailboxesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "public_mailbox_id": "xxxxxxxxxxxxxxx",
        "email": "test_public_mailbox@xxx.xx",
        "name": "test public mailbox",
        "geo": "cn"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.PostMailV1PublicMailboxesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}