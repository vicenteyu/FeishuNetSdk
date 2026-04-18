// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-18
//
// Last Modified By : yxr
// Last Modified On : 2026-04-18
// ************************************************************************
// <copyright file="Test_PatchMailV1UserMailboxesByUserMailboxIdLabelsByLabelIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新标签 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 更新标签 请求体
/// <para>接口ID：7620478754624392124</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-label/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-label%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchMailV1UserMailboxesByUserMailboxIdLabelsByLabelIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "label": {
        "name": "test",
        "background_color": "blue"
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Mail.PatchMailV1UserMailboxesByUserMailboxIdLabelsByLabelIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}