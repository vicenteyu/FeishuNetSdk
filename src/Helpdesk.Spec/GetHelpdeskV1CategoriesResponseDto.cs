namespace FeishuNetSdk.Helpdesk.Spec;
/// <summary>
/// 获取全部知识库分类 响应体
/// <para>该接口用于获取服务台知识库所有分类。</para>
/// <para>接口ID：6955768699895889922</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/faq-management/category/list-categories</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fcategory%2flist-categories</para>
/// </summary>
public record GetHelpdeskV1CategoriesResponseDto
{
    /// <summary>
    /// <para>知识库分类列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("categories")]
    public Category[]? Categories { get; set; }

    /// <summary></summary>
    public record Category
    {
        /// <summary>
        /// <para>知识库分类ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("category_id")]
        public string? CategoryId { get; set; }

        /// <summary>
        /// <para>知识库分类ID，（旧版，请使用category_id）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>父知识库分类ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// <para>服务台ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("helpdesk_id")]
        public string? HelpdeskId { get; set; }

        /// <summary>
        /// <para>语言</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// <para>子分类详情</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("children")]
        public Category[]? Children { get; set; }

    }
}
