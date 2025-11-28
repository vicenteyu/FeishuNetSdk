// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-03-21
//
// Last Modified By : yxr
// Last Modified On : 2025-05-25
// ************************************************************************
// <copyright file="GetPayrollV1DatasourcesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取外部数据源配置信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Payroll;
/// <summary>
/// 获取外部数据源配置信息 响应体
/// <para>批量查询飞书人事后台：设置-&gt;算薪数据设置-&gt;外部数据源设置 中的数据源设置列表</para>
/// <para>接口ID：7411366924142493698</para>
/// <para>文档地址：https://open.feishu.cn/document/payroll-v1/datasource/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpayroll-v1%2fdatasource%2flist</para>
/// </summary>
public record GetPayrollV1DatasourcesResponseDto : IPageableResponse<GetPayrollV1DatasourcesResponseDto.Datasource>
{
    /// <inheritdoc/>
    [JsonIgnore]
    public Datasource[]? Items => Datasources;

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
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
    /// <para>数据源列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("datasources")]
    public Datasource[] Datasources { get; set; } = [];

    /// <summary>
    /// <para>数据源列表</para>
    /// </summary>
    public record Datasource
    {
        /// <summary>
        /// <para>数据源编码</para>
        /// <para>必填：是</para>
        /// <para>示例值：test_datasource__c</para>
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; } = string.Empty;

        /// <summary>
        /// <para>数据源名称</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("i18n_names")]
        public I18nContent[] I18nNames { get; set; } = [];

        /// <summary>
        /// <para>数据源名称</para>
        /// </summary>
        public record I18nContent
        {
            /// <summary>
            /// <para>语种</para>
            /// <para>必填：否</para>
            /// <para>示例值：zh_cn</para>
            /// <para>默认值：zh_cn</para>
            /// </summary>
            [JsonPropertyName("locale")]
            public string? Locale { get; set; }

            /// <summary>
            /// <para>语种对应的值</para>
            /// <para>必填：否</para>
            /// <para>示例值：名称</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string? Value { get; set; }

            /// <summary>
            /// <para>名称对应的实体id</para>
            /// <para>必填：否</para>
            /// <para>示例值：723123123123123213</para>
            /// <para>最大长度：99</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }
        }

        /// <summary>
        /// <para>启停用状态</para>
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
        /// <para>数据源字段列表</para>
        /// <para>必填：是</para>
        /// <para>最大长度：1000</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("fields")]
        public DatasourceField[] Fields { get; set; } = [];

        /// <summary>
        /// <para>数据源字段列表</para>
        /// </summary>
        public record DatasourceField
        {
            /// <summary>
            /// <para>数据源字段编码</para>
            /// <para>必填：是</para>
            /// <para>示例值：test__c</para>
            /// </summary>
            [JsonPropertyName("code")]
            public string Code { get; set; } = string.Empty;

            /// <summary>
            /// <para>数据源字段名称</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("i18n_names")]
            public I18nContent[] I18nNames { get; set; } = [];

            /// <summary>
            /// <para>数据源字段名称</para>
            /// </summary>
            public record I18nContent
            {
                /// <summary>
                /// <para>语种</para>
                /// <para>必填：否</para>
                /// <para>示例值：zh_cn</para>
                /// <para>默认值：zh_cn</para>
                /// </summary>
                [JsonPropertyName("locale")]
                public string? Locale { get; set; }

                /// <summary>
                /// <para>语种对应的值</para>
                /// <para>必填：否</para>
                /// <para>示例值：名称</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string? Value { get; set; }

                /// <summary>
                /// <para>名称对应的实体id</para>
                /// <para>必填：否</para>
                /// <para>示例值：723123123123123213</para>
                /// <para>最大长度：99</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }
            }

            /// <summary>
            /// <para>字段类型</para>
            /// <para>必填：是</para>
            /// <para>示例值：1</para>
            /// <para>最大值：100</para>
            /// <para>最小值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：金额</item>
            /// <item>2：数值</item>
            /// <item>3：文本</item>
            /// <item>4：日期</item>
            /// <item>5：百分比</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("field_type")]
            public int FieldType { get; set; }

            /// <summary>
            /// <para>字段启停用状态</para>
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
            /// <para>数据源字段描述</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("i18n_description")]
            public I18nContent[]? I18nDescriptions { get; set; }

            /// <summary>
            /// <para>保留小数位数。目前只有number、money类型字段需要设置保留小数</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>最大值：6</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("decimal_places")]
            public int? DecimalPlaces { get; set; }
        }

        /// <summary>
        /// <para>数据源描述</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("i18n_description")]
        public I18nContent[]? I18nDescriptions { get; set; }

        /// <summary>
        /// <para>数据写入维度</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>最大值：3</para>
        /// <para>最小值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：算薪期间</item>
        /// <item>2：数据发生日期。功能灰度中，如需创建该维度数据源配置，请申请灰度。</item>
        /// <item>3：自定义数据周期。功能灰度中，如需创建该维度数据源配置，请申请灰度。</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("data_period_type")]
        public int? DataPeriodType { get; set; }
    }
}
