namespace FeishuNetSdk.Base;
/// <summary>
/// 列出数据表 响应体
/// <para>根据 app_token，获取多维表格下的所有数据表。</para>
/// <para>接口ID：6960166873968476163</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table%2flist</para>
/// </summary>
public record GetBitableV1AppsByAppTokenTablesResponseDto
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
    /// <para>总数</para>
    /// <para>必填：否</para>
    /// <para>示例值：\-</para>
    /// </summary>
    [JsonPropertyName("total")]
    public int? Total { get; set; }

    /// <summary>
    /// <para>数据表信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public AppTable[]? Items { get; set; }

    /// <summary>
    /// <para>数据表信息</para>
    /// </summary>
    public record AppTable
    {
        /// <summary>
        /// <para>数据表 id</para>
        /// <para>必填：否</para>
        /// <para>示例值：\-</para>
        /// </summary>
        [JsonPropertyName("table_id")]
        public string? TableId { get; set; }

        /// <summary>
        /// <para>数据表的版本号</para>
        /// <para>必填：否</para>
        /// <para>示例值：\-</para>
        /// </summary>
        [JsonPropertyName("revision")]
        public int? Revision { get; set; }

        /// <summary>
        /// <para>数据表名字</para>
        /// <para>必填：否</para>
        /// <para>示例值：\-</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }
}
