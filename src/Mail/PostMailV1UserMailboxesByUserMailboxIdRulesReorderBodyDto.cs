// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-04-11
//
// Last Modified By : yxr
// Last Modified On : 2025-04-11
// ************************************************************************
// <copyright file="PostMailV1UserMailboxesByUserMailboxIdRulesReorderBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>对收信规则进行排序 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 对收信规则进行排序 请求体
/// <para>对收信规则进行排序</para>
/// <para>接口ID：7275929163676188675</para>
/// <para>文档地址：https://open.feishu.cn/document/mail-v1/user_mailbox-rule/reorder</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-rule%2freorder</para>
/// </summary>
public record PostMailV1UserMailboxesByUserMailboxIdRulesReorderBodyDto
{
    /// <summary>
    /// <para>规则 id 列表，获取方式见 [列出收信规则](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-rule/list)</para>
    /// <para>必填：是</para>
    /// <para>示例值：111111111</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("rule_ids")]
    public string[] RuleIds { get; set; } = [];
}
