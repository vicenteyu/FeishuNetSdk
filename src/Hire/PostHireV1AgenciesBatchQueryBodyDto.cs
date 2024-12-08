// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-08
//
// Last Modified By : yxr
// Last Modified On : 2024-12-08
// ************************************************************************
// <copyright file="PostHireV1AgenciesBatchQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索猎头供应商列表 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 搜索猎头供应商列表 请求体
/// <para>可根据猎头供应商 ID 列表或关键字、筛选项查询供应商信息。</para>
/// <para>接口ID：7413697955198074884</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/agency/batch_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fagency%2fbatch_query</para>
/// </summary>
public record PostHireV1AgenciesBatchQueryBodyDto
{
    /// <summary>
    /// <para>猎头供应商 ID 列表，当传递此值，以此值为准，其余查询字段失效</para>
    /// <para>必填：否</para>
    /// <para>最大长度：20</para>
    /// </summary>
    [JsonPropertyName("agency_supplier_id_list")]
    public string[]? AgencySupplierIdList { get; set; }

    /// <summary>
    /// <para>搜索关键字，可传入名称或邮箱</para>
    /// <para>必填：否</para>
    /// <para>示例值：猎头</para>
    /// </summary>
    [JsonPropertyName("keyword")]
    public string? Keyword { get; set; }

    /// <summary>
    /// <para>筛选项，相同的 Key 仅可传一次，字段取值可查看本文`筛选字段说明`节</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("filter_list")]
    public CommonFilter[]? FilterLists { get; set; }

    /// <summary>
    /// <para>筛选项，相同的 Key 仅可传一次，字段取值可查看本文`筛选字段说明`节</para>
    /// </summary>
    public record CommonFilter
    {
        /// <summary>
        /// <para>筛选项 key，使用筛选项查询时必填</para>
        /// <para>必填：是</para>
        /// <para>示例值：supplier_area</para>
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; } = string.Empty;

        /// <summary>
        /// <para>筛选项值类型，使用筛选项查询时必填</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：值过滤，填充 value_list 字段</item>
        /// <item>2：范围过滤，填充 range_filter 字段</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("value_type")]
        public int ValueType { get; set; }

        /// <summary>
        /// <para>筛选项值列表，当`value_type`为`1`时必填</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("value_list")]
        public string[]? ValueList { get; set; }

        /// <summary>
        /// <para>范围筛选，当`value_type`为`2`时必填</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("range_filter")]
        public CommonFilterRangeFilter? RangeFilter { get; set; }

        /// <summary>
        /// <para>范围筛选，当`value_type`为`2`时必填</para>
        /// </summary>
        public record CommonFilterRangeFilter
        {
            /// <summary>
            /// <para>起始值</para>
            /// <para>必填：否</para>
            /// <para>示例值：1725951088959</para>
            /// </summary>
            [JsonPropertyName("from")]
            public string? From { get; set; }

            /// <summary>
            /// <para>终止值</para>
            /// <para>必填：否</para>
            /// <para>示例值：1725951088960</para>
            /// </summary>
            [JsonPropertyName("to")]
            public string? To { get; set; }
        }
    }
}
