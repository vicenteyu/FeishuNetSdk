// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetCorehrV1CompensationStandardsMatchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取员工薪资标准 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 获取员工薪资标准 响应体
/// <para>- 调用此接口来获取员工匹配的薪资标准信息</para>
/// <para>- 请求时，可选传递员工的部门 ID、职级 ID、职务ID 、序列 ID 等筛选条件，用于匹配薪资标准</para>
/// <para>- 此接口将返回员工可匹配到的薪资标准全部信息，包括薪资标准表 ID、薪级薪等、薪资带宽、薪资标准值等</para>
/// <para>接口ID：7182538601166028802</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/compensation_standard/match</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fcompensation_standard%2fmatch</para>
/// </summary>
public record GetCorehrV1CompensationStandardsMatchResponseDto
{
    /// <summary>
    /// <para>薪资标准表ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：7174758593538295340</para>
    /// </summary>
    [JsonPropertyName("standard_id")]
    public string? StandardId { get; set; }

    /// <summary>
    /// <para>薪资等级</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("grade")]
    public CpstGrade? Grade { get; set; }

    /// <summary>
    /// <para>薪资等级</para>
    /// </summary>
    public record CpstGrade
    {
        /// <summary>
        /// <para>薪资等级ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7174758360888215084</para>
        /// </summary>
        [JsonPropertyName("grade_id")]
        public string? GradeId { get; set; }

        /// <summary>
        /// <para>薪资等级时间轴ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7174758360888247852</para>
        /// </summary>
        [JsonPropertyName("grade_tid")]
        public string? GradeTid { get; set; }

        /// <summary>
        /// <para>带宽上下限和标准值</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("grade_standard_value")]
        public CpstGradeStandardValue? GradeStandardValue { get; set; }

        /// <summary>
        /// <para>带宽上下限和标准值</para>
        /// </summary>
        public record CpstGradeStandardValue
        {
            /// <summary>
            /// <para>薪资标准的关联对象，项目或者指标</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("reference_object")]
            public CpstGradeStandardValueReferenceObject? ReferenceObject { get; set; }

            /// <summary>
            /// <para>薪资标准的关联对象，项目或者指标</para>
            /// </summary>
            public record CpstGradeStandardValueReferenceObject
            {
                /// <summary>
                /// <para>cpst_item(项目)、 cpst_indicator(指标)</para>
                /// <para>必填：否</para>
                /// <para>示例值：cpst_item</para>
                /// <para>可选值：<list type="bullet">
                /// <item>cpst_item：项目</item>
                /// <item>cpst_indicator：指标</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("api_name")]
                public string? ApiName { get; set; }

                /// <summary>
                /// <para>值列表 例如薪资项和薪资统计指标ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：7156853394442044972</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }
            }

            /// <summary>
            /// <para>薪资标准类型</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("standard_type")]
            public CpstStandardType? StandardType { get; set; }

            /// <summary>
            /// <para>薪资标准类型</para>
            /// </summary>
            public record CpstStandardType
            {
                /// <summary>
                /// <para>薪资标准类型</para>
                /// <para>必填：否</para>
                /// <para>示例值：standard_value</para>
                /// <para>可选值：<list type="bullet">
                /// <item>standard_value：标准值</item>
                /// <item>bandwidth_and_standard_value：上下限和标准值</item>
                /// <item>bandwidth_upper_and_lower_limit：上下限</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("api_name")]
                public string? ApiName { get; set; }
            }

            /// <summary>
            /// <para>上下限</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("band_width")]
            public CpstBandWidth? BandWidth { get; set; }

            /// <summary>
            /// <para>上下限</para>
            /// </summary>
            public record CpstBandWidth
            {
                /// <summary>
                /// <para>上限</para>
                /// <para>必填：否</para>
                /// <para>示例值：15000</para>
                /// </summary>
                [JsonPropertyName("upper_limit")]
                public string? UpperLimit { get; set; }

                /// <summary>
                /// <para>下限</para>
                /// <para>必填：否</para>
                /// <para>示例值：10000</para>
                /// </summary>
                [JsonPropertyName("lower_limit")]
                public string? LowerLimit { get; set; }
            }

            /// <summary>
            /// <para>标准值</para>
            /// <para>必填：否</para>
            /// <para>示例值：12000</para>
            /// </summary>
            [JsonPropertyName("standard_value")]
            public string? StandardValue { get; set; }
        }

        /// <summary>
        /// <para>币种</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("currency")]
        public CpstCurrency? Currency { get; set; }

        /// <summary>
        /// <para>币种</para>
        /// </summary>
        public record CpstCurrency
        {
            /// <summary>
            /// <para>币种ID，可通过接口[【查询货币信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-currency/search)获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6863329932261459464</para>
            /// </summary>
            [JsonPropertyName("currency_id")]
            public string? CurrencyId { get; set; }

            /// <summary>
            /// <para>币种code</para>
            /// <para>必填：否</para>
            /// <para>示例值：CNY</para>
            /// </summary>
            [JsonPropertyName("code")]
            public string? Code { get; set; }

            /// <summary>
            /// <para>币种名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public CpstI18n? Name { get; set; }

            /// <summary>
            /// <para>币种名称</para>
            /// </summary>
            public record CpstI18n
            {
                /// <summary>
                /// <para>中文</para>
                /// <para>必填：否</para>
                /// <para>示例值：中文名称</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文</para>
                /// <para>必填：否</para>
                /// <para>示例值：english name</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }
        }

        /// <summary>
        /// <para>薪资标准描述</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("description")]
        public CpstI18n? Description { get; set; }

        /// <summary>
        /// <para>薪资标准描述</para>
        /// </summary>
        public record CpstI18n
        {
            /// <summary>
            /// <para>中文</para>
            /// <para>必填：否</para>
            /// <para>示例值：中文名称</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文</para>
            /// <para>必填：否</para>
            /// <para>示例值：english name</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }
    }

    /// <summary>
    /// <para>生效时间（毫秒级时间戳）</para>
    /// <para>必填：否</para>
    /// <para>示例值：1660924800000</para>
    /// </summary>
    [JsonPropertyName("effective_time")]
    public string? EffectiveTime { get; set; }
}
