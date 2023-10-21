using Newtonsoft.Json;
namespace FeishuNetSdk.Base;
/// <summary>
/// 列出表单问题 响应体
/// <para>列出表单的所有问题项</para>
/// <para>接口ID：7112628058154909698</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/form/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-form-field%2flist</para>
/// </summary>
public record GetBitableV1AppsByAppTokenTablesByTableIdFormsByFormIdFieldsResponseDto
{
    /// <summary>
    /// <para>表单问题信息</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("items")]
    public AppTableFormField[] Items { get; set; } = Array.Empty<AppTableFormField>();

    /// <summary>
    /// <para>表单问题信息</para>
    /// </summary>
    public record AppTableFormField
    {
        /// <summary>
        /// <para>表单问题 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：fldjX7dUj5</para>
        /// </summary>
        [JsonProperty("field_id")]
        public string? FieldId { get; set; }

        /// <summary>
        /// <para>表单问题</para>
        /// <para>必填：否</para>
        /// <para>示例值：多行文本</para>
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// <para>问题描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：多行文本描述</para>
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>是否必填</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonProperty("required")]
        public bool? Required { get; set; }

        /// <summary>
        /// <para>是否可见</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonProperty("visible")]
        public bool? Visible { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：是</para>
    /// <para>示例值：fld1lAbHh7</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string PageToken { get; set; } = string.Empty;

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonProperty("has_more")]
    public bool HasMore { get; set; }

    /// <summary>
    /// <para>总数</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonProperty("total")]
    public int Total { get; set; }
}
