namespace FeishuNetSdk.Im;
/// <summary>
/// 获取群成员发言权限 响应体
/// <para>获取群发言模式、可发言用户名单等。</para>
/// <para>接口ID：6951292665602883586</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-moderation%2fget</para>
/// </summary>
public record GetImV1ChatsByChatIdModerationResponseDto
{
    /// <summary>
    /// <para>群发言模式（all_members/only_owner/moderator_list，其中 moderator_list 表示部分用户可发言的模式）</para>
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
    /// <para>可发言用户列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public ListModerator[]? Items { get; set; }

    /// <summary>
    /// <para>可发言用户列表</para>
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
        /// <para>可发言用户 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：4d7a3c6g</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>租户Key，为租户在飞书上的唯一标识，用来换取对应的tenant_access_token，也可以用作租户在应用中的唯一标识</para>
        /// <para>必填：否</para>
        /// <para>示例值：2ca1d211f64f6438</para>
        /// </summary>
        [JsonPropertyName("tenant_key")]
        public string? TenantKey { get; set; }
    }
}
