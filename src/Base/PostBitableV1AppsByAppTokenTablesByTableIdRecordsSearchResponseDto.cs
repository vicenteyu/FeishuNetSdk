namespace FeishuNetSdk.Base;
/// <summary>
/// 查询记录 响应体
/// <para>该接口用于查询数据表中的现有记录，单次最多查询 500 行记录，支持分页获取。</para>
/// <para>接口ID：7312729248342360068</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-record/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-record%2fsearch</para>
/// </summary>
public record PostBitableV1AppsByAppTokenTablesByTableIdRecordsSearchResponseDto
{
    /// <summary>
    /// <para>record 结果</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public AppTableRecord[]? Items { get; set; }

    /// <summary>
    /// <para>record 结果</para>
    /// </summary>
    public record AppTableRecord
    {
        /// <summary>
        /// <para>记录字段[记录数据结构](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-record/bitable-record-data-structure-overview)</para>
        /// <para>必填：是</para>
        /// <para>示例值：{}</para>
        /// </summary>
        [JsonPropertyName("fields")]
        public object Fields { get; set; } = new();

        /// <summary>
        /// <para>记录Id</para>
        /// <para>必填：否</para>
        /// <para>示例值：recgcfdzKq</para>
        /// </summary>
        [JsonPropertyName("record_id")]
        public string? RecordId { get; set; }

        /// <summary>
        /// <para>创建人</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("created_by")]
        public Person? CreatedBy { get; set; }

        /// <summary>
        /// <para>创建人</para>
        /// </summary>
        public record Person
        {
            /// <summary>
            /// <para>人员Id</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_9a971ded01b4ca66f4798549878abcef</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>中文姓名</para>
            /// <para>必填：否</para>
            /// <para>示例值：黄小豆</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>英文姓名</para>
            /// <para>必填：否</para>
            /// <para>示例值：Xiaodou Huang</para>
            /// </summary>
            [JsonPropertyName("en_name")]
            public string? EnName { get; set; }

            /// <summary>
            /// <para>邮箱</para>
            /// <para>必填：否</para>
            /// <para>示例值：email@example.com</para>
            /// </summary>
            [JsonPropertyName("email")]
            public string? Email { get; set; }

            /// <summary>
            /// <para>头像链接</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://example.com/avatar</para>
            /// </summary>
            [JsonPropertyName("avatar_url")]
            public string? AvatarUrl { get; set; }
        }

        /// <summary>
        /// <para>创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1675244156000</para>
        /// </summary>
        [JsonPropertyName("created_time")]
        public long? CreatedTime { get; set; }

        /// <summary>
        /// <para>修改人</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("last_modified_by")]
        public Person? LastModifiedBy { get; set; }

        /// <summary>
        /// <para>最近更新时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1677556020000</para>
        /// </summary>
        [JsonPropertyName("last_modified_time")]
        public long? LastModifiedTime { get; set; }
    }

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
    /// <para>示例值：xxx</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>总数</para>
    /// <para>必填：否</para>
    /// <para>示例值：100</para>
    /// </summary>
    [JsonPropertyName("total")]
    public int? Total { get; set; }
}
