// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-03-21
//
// Last Modified By : yxr
// Last Modified On : 2025-03-21
// ************************************************************************
// <copyright file="PostPayrollV1DatasourceRecordsQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量查询外部算薪数据记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Payroll;
/// <summary>
/// 批量查询外部算薪数据记录 请求体
/// <para>1. 支持通过payroll_period（必传）、employment_id（可选）这两个预置字段，批量查询指定数据源下的数据记录列表。</para>
/// <para>2. 数据源配置信息可从[获取外部数据源配置信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/payroll-v1/datasource/list)或者 「飞书人事后台-设置-算薪数据设置-外部数据源配置」页面 获取</para>
/// <para>接口ID：7411366924142477314</para>
/// <para>文档地址：https://open.feishu.cn/document/payroll-v1/datasource_record/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpayroll-v1%2fdatasource_record%2fquery</para>
/// </summary>
public record PostPayrollV1DatasourceRecordsQueryBodyDto
{
    /// <summary>
    /// <para>数据源code</para>
    /// <para>必填：是</para>
    /// <para>示例值：test__c</para>
    /// </summary>
    [JsonPropertyName("source_code")]
    public string SourceCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>指定查询的数据源字段code。</para>
    /// <para>1. 如不传入此字段，默认返回所有数据源字段</para>
    /// <para>2. 如果传入，除了返回指定字段外，系统会默认返回emplyment_id、payroll_period字段的值。</para>
    /// <para>必填：否</para>
    /// <para>最大长度：200</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("selected_fields")]
    public string[]? SelectedFields { get; set; }

    /// <summary>
    /// <para>查询条件列表，多个条件之间为And关系，只支持「employment_id」、「payroll_period」这两个预置字段的等值查询：</para>
    /// <para>1. payroll_period</para>
    /// <para>- 必传，最多传入2个。</para>
    /// <para>- 字段类型：field_type=4(日期) ， 格式“yyyy-mm”，示例：“2024-01”， 注意并非“yyyy-mm-dd”</para>
    /// <para>2. employment_id</para>
    /// <para>- 非必传，最多传入100个，field_type=3（文本类型）。</para>
    /// <para>- 该id为飞书人事中员工的基本信息id，可通过[搜索员工信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)获取</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("field_filters")]
    public DatasourceRecordFieldFilter[]? FieldFilters { get; set; }

    /// <summary>
    /// <para>查询条件列表，多个条件之间为And关系，只支持「employment_id」、「payroll_period」这两个预置字段的等值查询：</para>
    /// <para>1. payroll_period</para>
    /// <para>- 必传，最多传入2个。</para>
    /// <para>- 字段类型：field_type=4(日期) ， 格式“yyyy-mm”，示例：“2024-01”， 注意并非“yyyy-mm-dd”</para>
    /// <para>2. employment_id</para>
    /// <para>- 非必传，最多传入100个，field_type=3（文本类型）。</para>
    /// <para>- 该id为飞书人事中员工的基本信息id，可通过[搜索员工信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)获取</para>
    /// </summary>
    public record DatasourceRecordFieldFilter
    {
        /// <summary>
        /// <para>字段编码</para>
        /// <para>必填：是</para>
        /// <para>示例值：employment_id</para>
        /// </summary>
        [JsonPropertyName("field_code")]
        public string FieldCode { get; set; } = string.Empty;

        /// <summary>
        /// <para>包含的字段值列表。</para>
        /// <para>必填：否</para>
        /// <para>最大长度：500</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("field_values")]
        public string[]? FieldValues { get; set; }
    }
}
