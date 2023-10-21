using Newtonsoft.Json;
namespace FeishuNetSdk.Im;
/// <summary>
/// 获取群成员列表 响应体
/// <para>获取用户/机器人所在群的群成员列表。</para>
/// <para>接口ID：6946222929790550044</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-member/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-members%2fget</para>
/// </summary>
public record GetImV1ChatsByChatIdMembersResponseDto
{
    /// <summary>
    /// <para>成员列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("items")]
    public ListMember[]? Items { get; set; }

    /// <summary>
    /// <para>成员列表</para>
    /// </summary>
    public record ListMember
    {
        /// <summary>
        /// <para>成员的用户 ID 类型，与查询参数中的 member_id_type 相同。取值为：`open_id`、`user_id`、`union_id`其中之一。</para>
        /// <para>必填：否</para>
        /// <para>示例值：user_id</para>
        /// </summary>
        [JsonProperty("member_id_type")]
        public string? MemberIdType { get; set; }

        /// <summary>
        /// <para>成员的用户ID，ID值与查询参数中的 member_id_type 对应。</para>
        /// <para>不同 ID 的说明参见 [用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)</para>
        /// <para>必填：否</para>
        /// <para>示例值：4d7a3c6g</para>
        /// </summary>
        [JsonProperty("member_id")]
        public string? MemberId { get; set; }

        /// <summary>
        /// <para>名字</para>
        /// <para>必填：否</para>
        /// <para>示例值：张三</para>
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>租户Key，为租户在飞书上的唯一标识，用来换取对应的tenant_access_token，也可以用作租户在应用中的唯一标识</para>
        /// <para>必填：否</para>
        /// <para>示例值：736588c9260f175d</para>
        /// </summary>
        [JsonProperty("tenant_key")]
        public string? TenantKey { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：0</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonProperty("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>成员总数</para>
    /// <para>必填：否</para>
    /// <para>示例值：2</para>
    /// </summary>
    [JsonProperty("member_total")]
    public int? MemberTotal { get; set; }
}
