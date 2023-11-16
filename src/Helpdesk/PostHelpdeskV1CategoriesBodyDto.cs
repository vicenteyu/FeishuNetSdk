namespace FeishuNetSdk.Helpdesk;
/// <summary>
/// 创建知识库分类 请求体
/// <para>该接口用于创建知识库分类。</para>
/// <para>接口ID：6955768699895775234</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/faq-management/category/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fcategory%2fcreate</para>
/// </summary>
public record PostHelpdeskV1CategoriesBodyDto
{
    /// <summary>
    /// <para>名称</para>
    /// <para>必填：是</para>
    /// <para>示例值：创建团队和邀请成员</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// <para>父知识库分类ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：0</para>
    /// </summary>
    [JsonPropertyName("parent_id")]
    public string ParentId { get; set; } = string.Empty;

    /// <summary>
    /// <para>语言</para>
    /// <para>必填：否</para>
    /// <para>示例值：zh_cn</para>
    /// </summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }
}
