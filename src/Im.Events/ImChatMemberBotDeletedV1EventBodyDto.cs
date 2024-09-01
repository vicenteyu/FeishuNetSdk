// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="ImChatMemberBotDeletedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>机器人被移出群 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Events;
/// <summary>
/// 机器人被移出群 事件体
/// <para>机器人被移出群聊后触发此事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=im&amp;version=v1&amp;resource=chat.member.bot&amp;event=deleted)</para>
/// <para>接口ID：6946222929790566428</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-member/event/deleted</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-member-bot%2fevents%2fdeleted</para>
/// </summary>
public record ImChatMemberBotDeletedV1EventBodyDto() : EventBodyDto("im.chat.member.bot.deleted_v1")
{
    /// <summary>
    /// <para>群组 ID，详情参见[群ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-id-description)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("chat_id")]
    public string? ChatId { get; set; }

    /// <summary>
    /// <para>用户 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("operator_id")]
    public UserIdSuffix? OperatorId { get; set; }

    /// <summary>
    /// <para>是否是外部群</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("external")]
    public bool? External { get; set; }

    /// <summary>
    /// <para>操作者租户 Key</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("operator_tenant_key")]
    public string? OperatorTenantKey { get; set; }

    /// <summary>
    /// <para>群名称</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// <para>群国际化名称</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("i18n_names")]
    public I18nLanguage<string>? I18nNames { get; set; }
}
