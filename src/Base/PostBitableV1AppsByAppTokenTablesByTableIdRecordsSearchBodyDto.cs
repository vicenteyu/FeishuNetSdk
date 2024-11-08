// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostBitableV1AppsByAppTokenTablesByTableIdRecordsSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 查询记录 请求体
/// <para>该接口用于查询数据表中的现有记录，单次最多查询 500 行记录，支持分页获取。</para>
/// <para>## 注意事项</para>
/// <para>若多维表格开启了高级权限，你需确保调用身份拥有多维表格的可管理权限，否则可能出现调用成功但返回数据为空的情况。了解具体步骤，参考[如何为应用或用户开通文档权限](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#16c6475a)。</para>
/// <para>接口ID：7312729248342360068</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-record/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-record%2fsearch</para>
/// </summary>
public record PostBitableV1AppsByAppTokenTablesByTableIdRecordsSearchBodyDto
{
    /// <summary>
    /// <para>多维表格中视图的唯一标识。获取方式：</para>
    /// <para>- 在多维表格的 URL 地址栏中，view_id 是下图中高亮部分：</para>
    /// <para>![view_id.png](//sf3-cn.feishucdn.com/obj/open-platform-opendoc/140668632c97e0095832219001d17c54_DJMgVH9x2S.png?height=748&amp;lazyload=true&amp;width=2998)</para>
    /// <para>- 通过[列出视图](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-view/list)接口获取。暂时无法获取到嵌入到云文档中的多维表格的 view_id。</para>
    /// <para>**注意**：</para>
    /// <para>当 filter 参数 或 sort 参数不为空时，请求视为对数据表中的全部数据做条件过滤，指定的 view_id 会被忽略。</para>
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
    /// <para>包含条件筛选信息的对象。了解 filter 填写指南和使用示例（如怎样同时使用 `and` 和 `or` 逻辑链接词），参考[记录筛选参数填写指南](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-record/record-filter-guide)。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("filter")]
    public FilterInfo? Filter { get; set; }

    /// <summary>
    /// <para>包含条件筛选信息的对象。了解 filter 填写指南和使用示例（如怎样同时使用 `and` 和 `or` 逻辑链接词），参考[记录筛选参数填写指南](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-record/record-filter-guide)。</para>
    /// </summary>
    public record FilterInfo
    {
        /// <summary>
        /// <para>表示条件之间的逻辑连接词</para>
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
            /// <item>isNot：不等于（不支持日期字段，了解如何查询日期字段，参考[日期字段填写说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-record/record-filter-guide#29d9dc89)）</item>
            /// <item>contains：包含（不支持日期字段）</item>
            /// <item>doesNotContain：不包含（不支持日期字段）</item>
            /// <item>isEmpty：为空</item>
            /// <item>isNotEmpty：不为空</item>
            /// <item>isGreater：大于</item>
            /// <item>isGreaterEqual：大于等于（不支持日期字段）</item>
            /// <item>isLess：小于</item>
            /// <item>isLessEqual：小于等于（不支持日期字段）</item>
            /// <item>like：LIKE 运算符。暂未支持</item>
            /// <item>in：IN 运算符。暂未支持</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("operator")]
            public string Operator { get; set; } = string.Empty;

            /// <summary>
            /// <para>条件的值，可以是单个值或多个值的数组。不同字段类型和不同的 operator 可填的值不同。详情参考[字段目标值（value）填写说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-record/record-filter-guide#3e0fd644)。</para>
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
    /// <para>是否返回自动计算的字段。默认为 false，表示不返回。</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("automatic_fields")]
    public bool? AutomaticFields { get; set; }
}
