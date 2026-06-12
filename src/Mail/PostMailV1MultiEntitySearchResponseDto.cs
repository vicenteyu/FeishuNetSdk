// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-13
//
// Last Modified By : yxr
// Last Modified On : 2026-06-13
// ************************************************************************
// <copyright file="PostMailV1MultiEntitySearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>多实体搜索 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 多实体搜索 响应体
/// <para>多实体搜索，适用于写信联系人搜索</para>
/// <para>接口ID：7648865505080413417</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/multi_entity/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fmulti_entity%2fsearch</para>
/// </summary>
public record PostMailV1MultiEntitySearchResponseDto
{
    /// <summary>
    /// <para>返回的实体详情</para>
    /// <para>必填：否</para>
    /// <para>最大长度：20</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("items")]
    public MultiEntitySearchItem[]? Items { get; set; }

    /// <summary>
    /// <para>返回的实体详情</para>
    /// </summary>
    public record MultiEntitySearchItem
    {
        /// <summary>
        /// <para>标识当前的实体是哪种（例如：user, chat 等）</para>
        /// <para>必填：否</para>
        /// <para>示例值：user</para>
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// <para>唯一标识 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6911188411932033028</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：张三</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>邮箱地址</para>
        /// <para>必填：否</para>
        /// <para>示例值：zhangsan@bytedance.com</para>
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// <para>备注名</para>
        /// <para>必填：否</para>
        /// <para>示例值：备注名</para>
        /// </summary>
        [JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// <para>群成员数量</para>
        /// <para>必填：否</para>
        /// <para>示例值：128</para>
        /// <para>最大值：128</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("member_count")]
        public int? MemberCount { get; set; }

        /// <summary>
        /// <para>用户 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_2d131f4c3a28b0</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>部门信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：飞书研发团队</para>
        /// </summary>
        [JsonPropertyName("department")]
        public string? Department { get; set; }

        /// <summary>
        /// <para>群聊或会话 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：oc_40ed357053e34b9</para>
        /// </summary>
        [JsonPropertyName("chat_id")]
        public string? ChatId { get; set; }

        /// <summary>
        /// <para>标签</para>
        /// <para>必填：否</para>
        /// <para>示例值：超大群/部门群/邮箱联系人/邮件组/外部</para>
        /// </summary>
        [JsonPropertyName("tag")]
        public string? Tag { get; set; }
    }

    /// <summary>
    /// <para>搜索补充提示信息，返回本次搜索的额外说明，例如：query被截断；搜索结果不全 等</para>
    /// <para>必填：否</para>
    /// <para>示例值：The query is too long and has been truncated to the first 50 characters for search.</para>
    /// </summary>
    [JsonPropertyName("notice")]
    public string? Notice { get; set; }
}
