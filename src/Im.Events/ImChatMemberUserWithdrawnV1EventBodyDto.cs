// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="ImChatMemberUserWithdrawnV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>撤销拉用户进群 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Events;
/// <summary>
/// 撤销拉用户进群 事件体
/// <para>撤销拉用户进群后触发此事件，在群组内的、已订阅该事件的机器人会收到事件消息。撤销操作是指如下图所示的群内 **撤销邀请**。</para>
/// <para>![image.png](//sf3-cn.feishucdn.com/obj/open-platform-opendoc/2faba42d3e4203e1dd899931da6dbfc8_DFXlHNscdw.png?height=278&amp;maxWidth=550&amp;width=1383){使用示例}(url=/api/tools/api_explore/api_explore_config?project=im&amp;version=v1&amp;resource=chat.member.user&amp;event=withdrawn)</para>
/// <para>接口ID：6946222929790664732</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-member/event/withdrawn</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-member-user%2fevents%2fwithdrawn</para>
/// </summary>
public record ImChatMemberUserWithdrawnV1EventBodyDto() : EventBodyDto("im.chat.member.user.withdrawn_v1")
{
    /// <summary>
    /// <para>群组 ID，详情参见[群 ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-id-description)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("chat_id")]
    public string? ChatId { get; set; }

    /// <summary>
    /// <para>操作者的 ID。用户不同 ID 类型介绍参考[用户身份概述](https://open.feishu.cn/document/home/user-identity-introduction/introduction)。</para>
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
    /// <para>操作者的租户 Key，为租户在飞书上的唯一标识，用来换取对应的 tenant_access_token，也可以用作租户在应用中的唯一标识</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("operator_tenant_key")]
    public string? OperatorTenantKey { get; set; }

    /// <summary>
    /// <para>被撤销加群的用户列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("users")]
    public ChatMemberUser[]? Users { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record ChatMemberUser
    {
        /// <summary>
        /// <para>用户名字</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>租户Key，为租户在飞书上的唯一标识，用来换取对应的tenant_access_token，也可以用作租户在应用中的唯一标识</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("tenant_key")]
        public string? TenantKey { get; set; }

        /// <summary>
        /// <para>用户 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public UserIdSuffix? UserId { get; set; }
    }

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
