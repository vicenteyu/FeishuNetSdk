// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-03-21
//
// Last Modified By : yxr
// Last Modified On : 2025-03-21
// ************************************************************************
// <copyright file="PostPayrollV1DatasourceRecordsQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量查询外部算薪数据记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Payroll;
/// <summary>
/// 批量查询外部算薪数据记录 响应体
/// <para>1. 支持通过payroll_period（必传）、employment_id（可选）这两个预置字段，批量查询指定数据源下的数据记录列表。</para>
/// <para>2. 数据源配置信息可从[获取外部数据源配置信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/payroll-v1/datasource/list)或者 「飞书人事后台-设置-算薪数据设置-外部数据源配置」页面 获取</para>
/// <para>接口ID：7411366924142477314</para>
/// <para>文档地址：https://open.feishu.cn/document/payroll-v1/datasource_record/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpayroll-v1%2fdatasource_record%2fquery</para>
/// </summary>
public record PostPayrollV1DatasourceRecordsQueryResponseDto : IPageableResponse<PostPayrollV1DatasourceRecordsQueryResponseDto.DatasourceRecord>
{
    /// <inheritdoc/>
    [JsonIgnore]
    public DatasourceRecord[]? Items => Records;

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：7413047003142619148</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>数据记录列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("records")]
    public DatasourceRecord[] Records { get; set; } = Array.Empty<DatasourceRecord>();

    /// <summary>
    /// <para>数据记录列表</para>
    /// </summary>
    public record DatasourceRecord
    {
        /// <summary>
        /// <para>记录的启停用状态</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// <para>最大值：100</para>
        /// <para>最小值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：已启用</item>
        /// <item>2：已停用</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("active_status")]
        public int ActiveStatus { get; set; }

        /// <summary>
        /// <para>记录的字段值列表</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("field_values")]
        public DatasourceRecordField[] FieldValues { get; set; } = Array.Empty<DatasourceRecordField>();

        /// <summary>
        /// <para>记录的字段值列表</para>
        /// </summary>
        public record DatasourceRecordField
        {
            /// <summary>
            /// <para>数据源字段编码</para>
            /// <para>必填：是</para>
            /// <para>示例值：yache41_8680__c</para>
            /// </summary>
            [JsonPropertyName("field_code")]
            public string FieldCode { get; set; } = string.Empty;

            /// <summary>
            /// <para>字段值 通过string传输，值为API写入的值。</para>
            /// <para>必填：是</para>
            /// <para>示例值：2024-12-01</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;

            /// <summary>
            /// <para>字段类型。可从「查询外部数据源设置」API 或者 「飞书人事后台-设置-算薪数据设置-外部数据源配置」页面 获取。</para>
            /// <para>1. 金额</para>
            /// <para>2. 数值</para>
            /// <para>3. 文本</para>
            /// <para>4. 日期</para>
            /// <para>5. 百分比</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>最大值：100</para>
            /// <para>最小值：1</para>
            /// </summary>
            [JsonPropertyName("field_type")]
            public int? FieldType { get; set; }
        }
    }
}
