// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="ImChatDisbandedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>群解散 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Events;
/// <summary>
/// 群解散 事件体
/// <para>群组被解散后触发此事件，在该群组内的、已订阅当前事件的应用机器人将会收到事件通知。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=im&amp;version=v1&amp;resource=chat&amp;event=disbanded)</para>
/// <para>接口ID：6946222929790599196</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat/events/disbanded</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat%2fevents%2fdisbanded</para>
/// </summary>
public record ImChatDisbandedV1EventBodyDto() : EventBodyDto("im.chat.disbanded_v1")
{
    /// <summary>
    /// <para>群组 ID。详情介绍参见[群 ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-id-description)。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("chat_id")]
    public string? ChatId { get; set; }

    /// <summary>
    /// <para>解散群的操作者的 ID 信息。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("operator_id")]
    public UserIdSuffix? OperatorId { get; set; }

    /// <summary>
    /// <para>被解散的群是否是外部群</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("external")]
    public bool? External { get; set; }

    /// <summary>
    /// <para>操作者的租户 Key，为租户在飞书上的唯一标识，用来换取对应的tenant_access_token，也可以用作租户在应用中的唯一标识。</para>
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
