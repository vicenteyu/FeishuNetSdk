using Newtonsoft.Json;
namespace FeishuNetSdk.Helpdesk;
/// <summary>
/// 创建知识库 响应体
/// <para>该接口用于创建知识库。</para>
/// <para>接口ID：6955768699895791618</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/faq-management/faq/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2ffaq%2fcreate</para>
/// </summary>
public record PostHelpdeskV1FaqsResponseDto
{
    /// <summary>
    /// <para>知识库详情</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("faq")]
    public PostHelpdeskV1FaqsResponseDtoFaq? Faq { get; set; }

    /// <summary>
    /// <para>知识库详情</para>
    /// </summary>
    public record PostHelpdeskV1FaqsResponseDtoFaq
    {
        /// <summary>
        /// <para>知识库ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6936004780707807231</para>
        /// </summary>
        [JsonProperty("faq_id")]
        public string? FaqId { get; set; }

        /// <summary>
        /// <para>知识库旧版ID，请使用faq_id</para>
        /// <para>必填：否</para>
        /// <para>示例值：6936004780707807231</para>
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>服务台ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6936004780707807251</para>
        /// </summary>
        [JsonProperty("helpdesk_id")]
        public string? HelpdeskId { get; set; }

        /// <summary>
        /// <para>问题</para>
        /// <para>必填：否</para>
        /// <para>示例值：问题</para>
        /// </summary>
        [JsonProperty("question")]
        public string? Question { get; set; }

        /// <summary>
        /// <para>答案</para>
        /// <para>必填：否</para>
        /// <para>示例值：答案</para>
        /// </summary>
        [JsonProperty("answer")]
        public string? Answer { get; set; }

        /// <summary>
        /// <para>富文本答案</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("answer_richtext")]
        public Richtext[]? AnswerRichtexts { get; set; }

        /// <summary>
        /// <para>富文本答案</para>
        /// </summary>
        public record Richtext
        {
            /// <summary>
            /// <para>内容</para>
            /// <para>必填：否</para>
            /// <para>示例值：我的答案</para>
            /// </summary>
            [JsonProperty("content")]
            public string? Content { get; set; }

            /// <summary>
            /// <para>类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：text</para>
            /// </summary>
            [JsonProperty("type")]
            public string? Type { get; set; }
        }

        /// <summary>
        /// <para>创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1596379008</para>
        /// </summary>
        [JsonProperty("create_time")]
        public int? CreateTime { get; set; }

        /// <summary>
        /// <para>修改时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1596379008</para>
        /// </summary>
        [JsonProperty("update_time")]
        public int? UpdateTime { get; set; }

        /// <summary>
        /// <para>分类</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("categories")]
        public Category[]? Categories { get; set; }

        /// <summary>
        /// <para>分类</para>
        /// </summary>
        public record Category
        {
            /// <summary>
            /// <para>知识库分类ID</para>
            /// <para>必填：是</para>
            /// <para>示例值：6948728206392295444</para>
            /// </summary>
            [JsonProperty("category_id")]
            public string CategoryId { get; set; } = string.Empty;

            /// <summary>
            /// <para>知识库分类ID，（旧版，请使用category_id）</para>
            /// <para>必填：是</para>
            /// <para>示例值：6948728206392295444</para>
            /// </summary>
            [JsonProperty("id")]
            public string Id { get; set; } = string.Empty;

            /// <summary>
            /// <para>名称</para>
            /// <para>必填：是</para>
            /// <para>示例值：创建团队和邀请成员</para>
            /// </summary>
            [JsonProperty("name")]
            public string Name { get; set; } = string.Empty;

            /// <summary>
            /// <para>父知识库分类ID</para>
            /// <para>必填：是</para>
            /// <para>示例值：0</para>
            /// </summary>
            [JsonProperty("parent_id")]
            public string ParentId { get; set; } = string.Empty;

            /// <summary>
            /// <para>服务台ID</para>
            /// <para>必填：是</para>
            /// <para>示例值：6939771743531696147</para>
            /// </summary>
            [JsonProperty("helpdesk_id")]
            public string HelpdeskId { get; set; } = string.Empty;

            /// <summary>
            /// <para>语言</para>
            /// <para>必填：否</para>
            /// <para>示例值：zh_cn</para>
            /// </summary>
            [JsonProperty("language")]
            public string? Language { get; set; }
        }

        /// <summary>
        /// <para>相似问题列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("tags")]
        public string[]? Tags { get; set; }

        /// <summary>
        /// <para>失效时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1596379008</para>
        /// </summary>
        [JsonProperty("expire_time")]
        public int? ExpireTime { get; set; }

        /// <summary>
        /// <para>更新用户</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("update_user")]
        public TicketUser? UpdateUser { get; set; }

        /// <summary>
        /// <para>更新用户</para>
        /// </summary>
        public record TicketUser
        {
            /// <summary>
            /// <para>用户ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_37019b7c830210acd88fdce886e25c71</para>
            /// </summary>
            [JsonProperty("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>用户头像url</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://xxxx</para>
            /// </summary>
            [JsonProperty("avatar_url")]
            public string? AvatarUrl { get; set; }

            /// <summary>
            /// <para>用户名</para>
            /// <para>必填：否</para>
            /// <para>示例值：abc</para>
            /// </summary>
            [JsonProperty("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>所在部门名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：用户部门名称(有权限才展示)</para>
            /// </summary>
            [JsonProperty("department")]
            public string? Department { get; set; }

            /// <summary>
            /// <para>城市</para>
            /// <para>必填：否</para>
            /// <para>示例值：城市</para>
            /// </summary>
            [JsonProperty("city")]
            public string? City { get; set; }

            /// <summary>
            /// <para>国家代号(CountryCode)，参考：http://www.mamicode.com/info-detail-2186501.html</para>
            /// <para>必填：否</para>
            /// <para>示例值：国家</para>
            /// </summary>
            [JsonProperty("country")]
            public string? Country { get; set; }
        }

        /// <summary>
        /// <para>创建用户</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("create_user")]
        public TicketUser? CreateUser { get; set; }
    }
}
