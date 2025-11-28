// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchBitableV1AppsByAppTokenTablesByTableIdViewsByViewIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新视图 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 更新视图 请求体
/// <para>增量更新视图信息，包括视图名称、属性等，可设置视图的筛选条件。</para>
/// <para>接口ID：7177650713441828867</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table-view/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-view%2fpatch</para>
/// </summary>
public record PatchBitableV1AppsByAppTokenTablesByTableIdViewsByViewIdBodyDto
{
    /// <summary>
    /// <para>视图名称。名称不能包含特殊字符，请确保其符合以下规则：</para>
    /// <para>- 长度不超过 100 个字符</para>
    /// <para>- 不为空且不包含这些特殊符号：[ ]</para>
    /// <para>必填：否</para>
    /// <para>示例值：表格视图 1</para>
    /// </summary>
    [JsonPropertyName("view_name")]
    public string? ViewName { get; set; }

    /// <summary>
    /// <para>视图属性</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("property")]
    public AppTableViewProperty? Property { get; set; }

    /// <summary>
    /// <para>视图属性</para>
    /// </summary>
    public record AppTableViewProperty
    {
        /// <summary>
        /// <para>筛选条件</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("filter_info")]
        public AppTableViewPropertyFilterInfo? FilterInfo { get; set; }

        /// <summary>
        /// <para>筛选条件</para>
        /// </summary>
        public record AppTableViewPropertyFilterInfo
        {
            /// <summary>
            /// <para>多个筛选条件的关系，表示条件之间的逻辑连接词</para>
            /// <para>必填：是</para>
            /// <para>示例值：and</para>
            /// <para>可选值：<list type="bullet">
            /// <item>and：与</item>
            /// <item>or：或</item>
            /// </list></para>
            /// <para>默认值：and</para>
            /// </summary>
            [JsonPropertyName("conjunction")]
            public string Conjunction { get; set; } = string.Empty;

            /// <summary>
            /// <para>筛选条件集合</para>
            /// <para>必填：是</para>
            /// <para>最大长度：50</para>
            /// </summary>
            [JsonPropertyName("conditions")]
            public AppTableViewPropertyFilterInfoCondition[] Conditions { get; set; } = [];

            /// <summary>
            /// <para>筛选条件集合</para>
            /// </summary>
            public record AppTableViewPropertyFilterInfoCondition
            {
                /// <summary>
                /// <para>用于筛选的字段的 ID。可通过[列出字段](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-field/list)接口获取</para>
                /// <para>必填：是</para>
                /// <para>示例值：fldmeqmpVA</para>
                /// </summary>
                [JsonPropertyName("field_id")]
                public string FieldId { get; set; } = string.Empty;

                /// <summary>
                /// <para>筛选操作的类型，条件运算符</para>
                /// <para>必填：是</para>
                /// <para>示例值：is</para>
                /// <para>可选值：<list type="bullet">
                /// <item>is：等于</item>
                /// <item>isNot：不等于（不支持日期字段）</item>
                /// <item>contains：包含（不支持日期字段）</item>
                /// <item>doesNotContain：不包含（不支持日期字段）</item>
                /// <item>isEmpty：为空</item>
                /// <item>isNotEmpty：不为空</item>
                /// <item>isGreater：大于</item>
                /// <item>isGreaterEqual：大于等于（不支持日期字段）</item>
                /// <item>isLess：小于</item>
                /// <item>isLessEqual：小于等于（不支持日期字段）</item>
                /// </list></para>
                /// <para>默认值：is</para>
                /// </summary>
                [JsonPropertyName("operator")]
                public string Operator { get; set; } = string.Empty;

                /// <summary>
                /// <para>条件的值，可以是单个值或多个值的数组。不同字段类型和不同的 operator 可填的值不同。详情参考[字段目标值（value）填写说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-record/record-filter-guide#3e0fd644)。</para>
                /// <para>必填：否</para>
                /// <para>示例值：`[\"text content\"]`</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string? Value { get; set; }
            }
        }

        /// <summary>
        /// <para>隐藏字段 ID 列表</para>
        /// <para>必填：否</para>
        /// <para>示例值：["fldCGzANXx", "fldCGzANXx"]</para>
        /// <para>最大长度：300</para>
        /// </summary>
        [JsonPropertyName("hidden_fields")]
        public string[]? HiddenFields { get; set; }

        /// <summary>
        /// <para>表格视图层级结构设置</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("hierarchy_config")]
        public AppTableViewPropertyHierarchyConfig? HierarchyConfig { get; set; }

        /// <summary>
        /// <para>表格视图层级结构设置</para>
        /// </summary>
        public record AppTableViewPropertyHierarchyConfig
        {
            /// <summary>
            /// <para>层级结构的关联列 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：fldmeqmpVA</para>
            /// </summary>
            [JsonPropertyName("field_id")]
            public string? FieldId { get; set; }
        }
    }
}
