namespace FeishuNetSdk.Base;
/// <summary>
/// 查询记录 请求体
/// <para>该接口用于查询数据表中的现有记录，单次最多查询 500 行记录，支持分页获取。</para>
/// <para>接口ID：7312729248342360068</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-record/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-record%2fsearch</para>
/// </summary>
public record PostBitableV1AppsByAppTokenTablesByTableIdRecordsSearchBodyDto
{
    /// <summary>
    /// <para>视图的唯一标识符，获取指定视图下的记录[view_id 参数说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/notification#8121eebe)</para>
    /// <para>注意：</para>
    /// <para>当 filter 参数 或 sort 参数不为空时，请求视为对数据表中的全部数据做条件过滤，指定的view_id 会被忽略。</para>
    /// <para>必填：否</para>
    /// <para>示例值：vewqhz51lk</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("view_id")]
    public string? ViewId { get; set; }

    /// <summary>
    /// <para>字段名称，用于指定本次查询返回记录中包含的字段</para>
    /// <para>必填：否</para>
    /// <para>最大长度：200</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("field_names")]
    public string[]? FieldNames { get; set; }

    /// <summary>
    /// <para>排序条件</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("sort")]
    public Sort[]? Sorts { get; set; }

    /// <summary>
    /// <para>排序条件</para>
    /// </summary>
    public record Sort
    {
        /// <summary>
        /// <para>字段名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：多行文本</para>
        /// <para>最大长度：1000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("field_name")]
        public string? FieldName { get; set; }

        /// <summary>
        /// <para>是否倒序排序</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// <para>默认值：false</para>
        /// </summary>
        [JsonPropertyName("desc")]
        public bool? Desc { get; set; }
    }

    /// <summary>
    /// <para>筛选条件</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("filter")]
    public FilterInfo? Filter { get; set; }

    /// <summary>
    /// <para>筛选条件</para>
    /// </summary>
    public record FilterInfo
    {
        /// <summary>
        /// <para>条件逻辑连接词</para>
        /// <para>必填：否</para>
        /// <para>示例值：and</para>
        /// <para>最大长度：10</para>
        /// <para>最小长度：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>and：满足全部条件</item>
        /// <item>or：满足任一条件</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("conjunction")]
        public string? Conjunction { get; set; }

        /// <summary>
        /// <para>筛选条件集合</para>
        /// <para>必填：否</para>
        /// <para>最大长度：50</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("conditions")]
        public Condition[]? Conditions { get; set; }

        /// <summary>
        /// <para>筛选条件集合</para>
        /// </summary>
        public record Condition
        {
            /// <summary>
            /// <para>筛选条件的左值，值为字段的名称</para>
            /// <para>必填：是</para>
            /// <para>示例值：字段1</para>
            /// <para>最大长度：1000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("field_name")]
            public string FieldName { get; set; } = string.Empty;

            /// <summary>
            /// <para>条件运算符</para>
            /// <para>必填：是</para>
            /// <para>示例值：is</para>
            /// <para>可选值：<list type="bullet">
            /// <item>is：等于</item>
            /// <item>isNot：不等于</item>
            /// <item>contains：包含</item>
            /// <item>doesNotContain：不包含</item>
            /// <item>isEmpty：为空</item>
            /// <item>isNotEmpty：不为空</item>
            /// <item>isGreater：大于</item>
            /// <item>isGreaterEqual：大于等于</item>
            /// <item>isLess：小于</item>
            /// <item>isLessEqual：小于等于</item>
            /// <item>like：like</item>
            /// <item>in：in</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("operator")]
            public string Operator { get; set; } = string.Empty;

            /// <summary>
            /// <para>目标值</para>
            /// <para>[目标值填写指南](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-record/record-filter-guide)</para>
            /// <para>必填：否</para>
            /// <para>示例值：文本内容</para>
            /// <para>最大长度：10</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string[]? Value { get; set; }
        }
    }

    /// <summary>
    /// <para>控制是否返回自动计算的字段, true 表示返回</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("automatic_fields")]
    public bool? AutomaticFields { get; set; }
}
