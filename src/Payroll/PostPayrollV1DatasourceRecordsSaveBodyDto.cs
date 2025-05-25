// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-03-21
//
// Last Modified By : yxr
// Last Modified On : 2025-03-21
// ************************************************************************
// <copyright file="PostPayrollV1DatasourceRecordsSaveBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建 / 更新外部算薪数据 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Payroll;
/// <summary>
/// 创建 / 更新外部算薪数据 请求体
/// <para>参照数据源配置字段格式，批量保存（创建或更新）数据记录。</para>
/// <para>1. 记录的唯一标志通过业务主键判断（employment_id + payroll_period）</para>
/// <para>2. 若不存在数据记录，则本次保存会插入1条记录。</para>
/// <para>3. 若已存在数据记录，则本次保存会覆盖更新已有记录（只更新传入字段的值，未传入字段值不更新），如果传入的数据记录没有任何变化，则不更新。</para>
/// <para>4. 若更新或者插入成功，会返回产生数据变更的记录条数。</para>
/// <para>接口ID：7411366924142460930</para>
/// <para>文档地址：https://open.feishu.cn/document/payroll-v1/datasource_record/save</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpayroll-v1%2fdatasource_record%2fsave</para>
/// </summary>
public record PostPayrollV1DatasourceRecordsSaveBodyDto
{
    /// <summary>
    /// <para>数据源code。可从[获取外部数据源配置信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/payroll-v1/datasource/list)</para>
    /// <para>或者 「飞书人事后台-设置-算薪数据设置-外部数据源配置」页面 获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：test__c</para>
    /// </summary>
    [JsonPropertyName("source_code")]
    public string SourceCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>需保存的记录列表</para>
    /// <para>必填：是</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("records")]
    public DatasourceRecord[] Records { get; set; } = Array.Empty<DatasourceRecord>();

    /// <summary>
    /// <para>需保存的记录列表</para>
    /// </summary>
    public record DatasourceRecord
    {
        /// <summary>
        /// <para>记录的启停用状态。说明：数据记录被停用后，依旧可以被API保存、查询，但无法被算薪使用。</para>
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
        /// <para>需创建或者更新记录的具体字段值列表：</para>
        /// <para>- 必传字段：</para>
        /// <para>根据记录的数据源的数据写入维度属性，有不同的必传字段：</para>
        /// <para>1. 算薪期间维度。“payroll_period”、“employment_id”字段必传，payroll_period格式：“2024-01”。</para>
        /// <para>2. 数据发生日期维度（灰度中）。“occur_day”、“employment_id”字段必传。occur_day格式：“2024-01-02”。</para>
        /// <para>3. 自定义数据周期维度（灰度中）。“custom_start”、“custom_end”、“employment_id”字段必传。custom_start、custom_end格式：“2024-01-02”。</para>
        /// <para>employment_id为飞书人事中员工的基本信息id，可通过[搜索员工信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)获取</para>
        /// <para>- 其他自定字段按照诉求可选传入，需保证写入的字段在配置中存在且启用。字段code不得重复传入，且字段的值需符合类型对应的约束。</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("field_values")]
        public DatasourceRecordField[] FieldValues { get; set; } = Array.Empty<DatasourceRecordField>();

        /// <summary>
        /// <para>需创建或者更新记录的具体字段值列表：</para>
        /// <para>- 必传字段：</para>
        /// <para>根据记录的数据源的数据写入维度属性，有不同的必传字段：</para>
        /// <para>1. 算薪期间维度。“payroll_period”、“employment_id”字段必传，payroll_period格式：“2024-01”。</para>
        /// <para>2. 数据发生日期维度（灰度中）。“occur_day”、“employment_id”字段必传。occur_day格式：“2024-01-02”。</para>
        /// <para>3. 自定义数据周期维度（灰度中）。“custom_start”、“custom_end”、“employment_id”字段必传。custom_start、custom_end格式：“2024-01-02”。</para>
        /// <para>employment_id为飞书人事中员工的基本信息id，可通过[搜索员工信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)获取</para>
        /// <para>- 其他自定字段按照诉求可选传入，需保证写入的字段在配置中存在且启用。字段code不得重复传入，且字段的值需符合类型对应的约束。</para>
        /// </summary>
        public record DatasourceRecordField
        {
            /// <summary>
            /// <para>数据源字段编码，请确保字段存在且是启用的。可从「查询外部数据源设置」API 或者 「飞书人事后台-设置-算薪数据设置-外部数据源配置」页面 获取</para>
            /// <para>必填：是</para>
            /// <para>示例值：test__c</para>
            /// </summary>
            [JsonPropertyName("field_code")]
            public string FieldCode { get; set; } = string.Empty;

            /// <summary>
            /// <para>字段值 通过string传输，不允许输入空字符串，请确保字段的值符合类型的约束。</para>
            /// <para>必填：是</para>
            /// <para>示例值：123</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;

            /// <summary>
            /// <para>1. 不需要传入此字段，这里只做文档说明用。</para>
            /// <para>2. 字段类型可从「查询外部数据源设置」的返回值中的datasources.fields. field_type中获取</para>
            /// <para>3. value的传值的格式需符合类型的约束：</para>
            /// <para>- field_type=1：金额。eg: "12.23"。目前仅支持人民币¥元，超过设置的精度会被四舍五入；</para>
            /// <para>- field_type=2：数值。eg: "12.23"。超过设置的精度会被四舍五入。</para>
            /// <para>- field_type=3：文本。 eg: "我是一段文本"。文本字符个数不允许超过500，一条记录的文本总的字符个数不允许超过3000.</para>
            /// <para>- field_type=4：日期。除系统预置的payroll_period字段外的所有自定义字段，日期格式均为“yyyy-mm-dd”，示例：“2024-01-01”。但payroll_period代表算薪期间，精确到月，格式“yyyy-mm”，示例：“2024-01”。</para>
            /// <para>- field_type=5：百分比。百分比 "10" 代表10%，最多保留两位小数，超过后四舍五入</para>
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
