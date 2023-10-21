using Newtonsoft.Json;
namespace FeishuNetSdk.Base;
/// <summary>
/// 更新视图 请求体
/// <para>该接口用于增量修改视图信息</para>
/// <para>接口ID：7177650713441828867</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table-view/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-view%2fpatch</para>
/// </summary>
public record PatchBitableV1AppsByAppTokenTablesByTableIdViewsByViewIdBodyDto
{
    /// <summary>
    /// <para>视图名称</para>
    /// <para>必填：否</para>
    /// <para>示例值：grid</para>
    /// </summary>
    [JsonProperty("view_name")]
    public string? ViewName { get; set; }

    /// <summary>
    /// <para>视图属性</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("property")]
    public AppTableViewProperty? Property { get; set; }

    /// <summary>
    /// <para>视图属性</para>
    /// </summary>
    public record AppTableViewProperty
    {
        /// <summary>
        /// <para>过滤条件</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("filter_info")]
        public AppTableViewPropertyFilterInfo? FilterInfo { get; set; }

        /// <summary>
        /// <para>过滤条件</para>
        /// </summary>
        public record AppTableViewPropertyFilterInfo
        {
            /// <summary>
            /// <para>多个筛选条件的关系</para>
            /// <para>必填：是</para>
            /// <para>示例值：and</para>
            /// <para>可选值：<list type="bullet">
            /// <item>and：与</item>
            /// <item>or：或</item>
            /// </list></para>
            /// <para>默认值：and</para>
            /// </summary>
            [JsonProperty("conjunction")]
            public string Conjunction { get; set; } = string.Empty;

            /// <summary>
            /// <para>筛选条件</para>
            /// <para>必填：是</para>
            /// <para>最大长度：50</para>
            /// </summary>
            [JsonProperty("conditions")]
            public AppTableViewPropertyFilterInfoCondition[] Conditions { get; set; } = Array.Empty<AppTableViewPropertyFilterInfoCondition>();

            /// <summary>
            /// <para>筛选条件</para>
            /// </summary>
            public record AppTableViewPropertyFilterInfoCondition
            {
                /// <summary>
                /// <para>用于过滤的字段唯一ID</para>
                /// <para>必填：是</para>
                /// <para>示例值：fldVioU**1</para>
                /// </summary>
                [JsonProperty("field_id")]
                public string FieldId { get; set; } = string.Empty;

                /// <summary>
                /// <para>过滤操作的类型</para>
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
                /// </list></para>
                /// <para>默认值：is</para>
                /// </summary>
                [JsonProperty("operator")]
                public string Operator { get; set; } = string.Empty;

                /// <summary>
                /// <para>筛选值</para>
                /// <para>必填：否</para>
                /// <para>示例值：["optbdVH***","optrpd3***"]</para>
                /// </summary>
                [JsonProperty("value")]
                public string? Value { get; set; }
            }
        }

        /// <summary>
        /// <para>隐藏字段ID列表</para>
        /// <para>必填：否</para>
        /// <para>示例值：["fldCGzANXx","fldCGzANXx"]</para>
        /// <para>最大长度：300</para>
        /// </summary>
        [JsonProperty("hidden_fields")]
        public string[]? HiddenFields { get; set; }

        /// <summary>
        /// <para>表格视图层级结构设置</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("hierarchy_config")]
        public AppTableViewPropertyHierarchyConfig? HierarchyConfig { get; set; }

        /// <summary>
        /// <para>表格视图层级结构设置</para>
        /// </summary>
        public record AppTableViewPropertyHierarchyConfig
        {
            /// <summary>
            /// <para>层级结构的关联列id</para>
            /// <para>必填：否</para>
            /// <para>示例值：fldTca**hb</para>
            /// </summary>
            [JsonProperty("field_id")]
            public string? FieldId { get; set; }
        }
    }
}
