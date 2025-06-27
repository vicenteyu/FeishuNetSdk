// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostMailV1UserMailboxesByUserMailboxIdRulesReorderBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 对收信规则进行排序 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 对收信规则进行排序 请求体
/// <para>接口ID：7275929163676188675</para>
/// <para>文档地址：https://open.feishu.cn/document/mail-v1/user_mailbox-rule/reorder</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-rule%2freorder</para>
/// </summary>
[TestClass]
public class Test_PostMailV1UserMailboxesByUserMailboxIdRulesReorderBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "rule_ids": [
        "11111111"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Mail.PostMailV1UserMailboxesByUserMailboxIdRulesReorderBodyDto>(json);
        Assert.IsNotNull(result);
    }
}