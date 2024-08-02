// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-08-02
// ************************************************************************
// <copyright file="GetHelpdeskV1FaqsSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索知识库 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Helpdesk;
/// <summary>
/// 搜索知识库 响应体
/// <para>该接口用于搜索服务台知识库。</para>
/// <para>接口ID：6955768699895808002</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/faq-management/faq/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2ffaq%2fsearch</para>
/// </summary>
public record GetHelpdeskV1FaqsSearchResponseDto
{
    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>知识库列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Faq[]? Items { get; set; }

    /// <summary>
    /// <para>知识库列表</para>
    /// </summary>
    public record Faq
    {
        /// <summary>
        /// <para>知识库ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6986214054851346434</para>
        /// </summary>
        [JsonPropertyName("faq_id")]
        public string? FaqId { get; set; }

        /// <summary>
        /// <para>知识库旧版ID，请使用faq_id</para>
        /// <para>必填：否</para>
        /// <para>示例值：6986214054851346434</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>服务台ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6946124090457505820</para>
        /// </summary>
        [JsonPropertyName("helpdesk_id")]
        public string? HelpdeskId { get; set; }

        /// <summary>
        /// <para>问题</para>
        /// <para>必填：否</para>
        /// <para>示例值：盒餐发放位置查询</para>
        /// </summary>
        [JsonPropertyName("question")]
        public string? Question { get; set; }

        /// <summary>
        /// <para>答案</para>
        /// <para>必填：否</para>
        /// <para>示例值：建议根据公司实际情况编写，以文档形式答疑</para>
        /// </summary>
        [JsonPropertyName("answer")]
        public string? Answer { get; set; }

        /// <summary>
        /// <para>富文本答案</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("answer_richtext")]
        public Richtext[]? AnswerRichtexts { get; set; }

        /// <summary>
        /// <para>富文本答案</para>
        /// </summary>
        public record Richtext
        {
            /// <summary>
            /// <para>内容</para>
            /// <para>必填：否</para>
            /// <para>示例值：建议根据公司实际情况编写，以文档形式答疑</para>
            /// </summary>
            [JsonPropertyName("content")]
            public string? Content { get; set; }

            /// <summary>
            /// <para>类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：text</para>
            /// </summary>
            [JsonPropertyName("type")]
            public string? Type { get; set; }
        }

        /// <summary>
        /// <para>创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1626604715</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>修改时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1631242057</para>
        /// </summary>
        [JsonPropertyName("update_time")]
        public long? UpdateTime { get; set; }

        /// <summary>
        /// <para>分类</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("categories")]
        public Category[]? Categories { get; set; }

        /// <summary>
        /// <para>分类</para>
        /// </summary>
        public record Category
        {
            /// <summary>
            /// <para>知识库分类ID</para>
            /// <para>必填：是</para>
            /// <para>示例值：6975057629039083524</para>
            /// </summary>
            [JsonPropertyName("category_id")]
            public string CategoryId { get; set; } = string.Empty;

            /// <summary>
            /// <para>知识库分类ID，（旧版，请使用category_id）</para>
            /// <para>必填：是</para>
            /// <para>示例值：6975057629039083524</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string Id { get; set; } = string.Empty;

            /// <summary>
            /// <para>名称</para>
            /// <para>必填：是</para>
            /// <para>示例值：行政</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string Name { get; set; } = string.Empty;

            /// <summary>
            /// <para>父知识库分类ID</para>
            /// <para>必填：是</para>
            /// <para>示例值：6946124050457505820</para>
            /// </summary>
            [JsonPropertyName("parent_id")]
            public string ParentId { get; set; } = string.Empty;

            /// <summary>
            /// <para>服务台ID</para>
            /// <para>必填：是</para>
            /// <para>示例值：6946124090457505820</para>
            /// </summary>
            [JsonPropertyName("helpdesk_id")]
            public string HelpdeskId { get; set; } = string.Empty;

            /// <summary>
            /// <para>语言</para>
            /// <para>必填：否</para>
            /// <para>示例值：zh_cn</para>
            /// </summary>
            [JsonPropertyName("language")]
            public string? Language { get; set; }
        }

        /// <summary>
        /// <para>相似问题列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("tags")]
        public string[]? Tags { get; set; }

        /// <summary>
        /// <para>失效时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1631243057</para>
        /// </summary>
        [JsonPropertyName("expire_time")]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// <para>更新用户</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("update_user")]
        public TicketUser? UpdateUser { get; set; }

        /// <summary>
        /// <para>更新用户</para>
        /// </summary>
        public record TicketUser
        {
            /// <summary>
            /// <para>用户ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_eb208c4799a1f3a86c12e0b03e5a54b1</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>用户头像url</para>
            /// <para>必填：否</para>
            /// <para>示例值：xxxxxxxxxx</para>
            /// </summary>
            [JsonPropertyName("avatar_url")]
            public string? AvatarUrl { get; set; }

            /// <summary>
            /// <para>用户名</para>
            /// <para>必填：否</para>
            /// <para>示例值：xx</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>所在部门名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：行政</para>
            /// </summary>
            [JsonPropertyName("department")]
            public string? Department { get; set; }

            /// <summary>
            /// <para>城市</para>
            /// <para>必填：否</para>
            /// <para>示例值：xx</para>
            /// </summary>
            [JsonPropertyName("city")]
            public string? City { get; set; }

            /// <summary>
            /// <para>国家代号(CountryCode)，参考：http://www.mamicode.com/info-detail-2186501.html</para>
            /// <para>必填：否</para>
            /// <para>示例值：xx</para>
            /// </summary>
            [JsonPropertyName("country")]
            public string? Country { get; set; }
        }

        /// <summary>
        /// <para>创建用户</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("create_user")]
        public TicketUser? CreateUser { get; set; }
    }
}
