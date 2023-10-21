using Newtonsoft.Json;
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取备注列表 响应体
/// <para>获取备注列表。</para>
/// <para>接口ID：6950644745484419099</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/note/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fnote%2flist</para>
/// </summary>
public record GetHireV1NotesResponseDto
{
    /// <summary>
    /// <para>备注数据列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("items")]
    public Note[]? Items { get; set; }

    /// <summary>
    /// <para>备注数据列表</para>
    /// </summary>
    public record Note
    {
        /// <summary>
        /// <para>备注ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6949805467799537964</para>
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>人才ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：6916472453069883661</para>
        /// </summary>
        [JsonProperty("talent_id")]
        public string TalentId { get; set; } = string.Empty;

        /// <summary>
        /// <para>投递ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6891565253964859661</para>
        /// </summary>
        [JsonProperty("application_id")]
        public string? ApplicationId { get; set; }

        /// <summary>
        /// <para>是否私密</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonProperty("is_private")]
        public bool? IsPrivate { get; set; }

        /// <summary>
        /// <para>创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1618209327096</para>
        /// </summary>
        [JsonProperty("create_time")]
        public int? CreateTime { get; set; }

        /// <summary>
        /// <para>更新时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1618209327096</para>
        /// </summary>
        [JsonProperty("modify_time")]
        public int? ModifyTime { get; set; }

        /// <summary>
        /// <para>创建人ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_f476cb099ac9227c9bae09ce46112579</para>
        /// </summary>
        [JsonProperty("creator_id")]
        public string? CreatorId { get; set; }

        /// <summary>
        /// <para>内容</para>
        /// <para>必填：是</para>
        /// <para>示例值：测试</para>
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonProperty("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：10</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string? PageToken { get; set; }
}
