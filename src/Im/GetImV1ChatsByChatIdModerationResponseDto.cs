// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetImV1ChatsByChatIdModerationResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取群成员发言权限 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 获取群成员发言权限 响应体
/// <para>获取指定群组的发言模式、可发言用户名单等信息。</para>
/// <para>## 前提条件</para>
/// <para>应用需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>## 使用限制</para>
/// <para>调用本接口的用户或机器人必须要在对应的群组内。</para>
/// <para>接口ID：6951292665602883586</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-moderation%2fget</para>
/// </summary>
public record GetImV1ChatsByChatIdModerationResponseDto : IPageableResponse<GetImV1ChatsByChatIdModerationResponseDto.ListModerator>
{
    /// <summary>
    /// <para>群发言模式，可能值有：</para>
    /// <para>- all_members：所有群成员可发言</para>
    /// <para>- only_owner：仅群主或管理员可发言</para>
    /// <para>- moderator_list：指定群成员可发言</para>
    /// <para>必填：否</para>
    /// <para>示例值：moderator_list</para>
    /// </summary>
    [JsonPropertyName("moderation_setting")]
    public string? ModerationSetting { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：0</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>可发言用户列表，当群发言模式为 `moderator_list` 时，该参数有返回值。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public ListModerator[]? Items { get; set; }

    /// <summary>
    /// <para>可发言用户列表，当群发言模式为 `moderator_list` 时，该参数有返回值。</para>
    /// </summary>
    public record ListModerator
    {
        /// <summary>
        /// <para>可发言用户 ID 类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：user_id</para>
        /// </summary>
        [JsonPropertyName("user_id_type")]
        public string? UserIdType { get; set; }

        /// <summary>
        /// <para>可发言用户 ID，ID 类型与查询参数 user_id_type 取值一致。</para>
        /// <para>必填：否</para>
        /// <para>示例值：4d7a3c6g</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>租户 Key，为租户在飞书上的唯一标识，用来换取对应的tenant_access_token，也可以用作租户在应用中的唯一标识。</para>
        /// <para>必填：否</para>
        /// <para>示例值：2ca1d211f64f6438</para>
        /// </summary>
        [JsonPropertyName("tenant_key")]
        public string? TenantKey { get; set; }
    }
}
