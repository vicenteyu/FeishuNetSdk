namespace FeishuNetSdk.Im;
/// <summary>
/// 获取用户或机器人所在的群列表 响应体
/// <para>根据使用的 access_token 获取用户或者机器人所在群列表。</para>
/// <para>接口ID：6946222931479412737</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat%2flist</para>
/// </summary>
public record GetImV1ChatsResponseDto
{
    /// <summary>
    /// <para>chat 列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public ListChat[]? Items { get; set; }

    /// <summary>
    /// <para>chat 列表</para>
    /// </summary>
    public record ListChat
    {
        /// <summary>
        /// <para>群组 ID，详情参见[群ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-id-description)</para>
        /// <para>必填：否</para>
        /// <para>示例值：oc_a0553eda9014c201e6969b478895c230</para>
        /// </summary>
        [JsonPropertyName("chat_id")]
        public string? ChatId { get; set; }

        /// <summary>
        /// <para>群头像 URL</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://p3-lark-file.byteimg.com/img/lark-avatar-staging/default-avatar_44ae0ca3-e140-494b-956f-78091e348435~100x100.jpg</para>
        /// </summary>
        [JsonPropertyName("avatar")]
        public string? Avatar { get; set; }

        /// <summary>
        /// <para>群名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：测试群名称</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>群描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：测试群描述</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>群主 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：4d7a3c6g</para>
        /// </summary>
        [JsonPropertyName("owner_id")]
        public string? OwnerId { get; set; }

        /// <summary>
        /// <para>群主 ID 类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：user_id</para>
        /// </summary>
        [JsonPropertyName("owner_id_type")]
        public string? OwnerIdType { get; set; }

        /// <summary>
        /// <para>是否是外部群</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("external")]
        public bool? External { get; set; }

        /// <summary>
        /// <para>租户Key，为租户在飞书上的唯一标识，用来换取对应的tenant_access_token，也可以用作租户在应用中的唯一标识</para>
        /// <para>必填：否</para>
        /// <para>示例值：736588c9260f175e</para>
        /// </summary>
        [JsonPropertyName("tenant_key")]
        public string? TenantKey { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：dmJCRHhpd3JRbGV1VEVNRFFyTitRWDY5ZFkybmYrMEUwMUFYT0VMMWdENEtuYUhsNUxGMDIwemtvdE5ORjBNQQ==</para>
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
}
