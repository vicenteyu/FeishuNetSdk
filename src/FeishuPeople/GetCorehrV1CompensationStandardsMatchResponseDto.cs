using Newtonsoft.Json;
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 获取员工薪资标准 响应体
/// <para>根据员工获取匹配的薪资标准信息。</para>
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
    [JsonProperty("standard_id")]
    public string? StandardId { get; set; }

    /// <summary>
    /// <para>薪资等级</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("grade")]
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
        [JsonProperty("grade_id")]
        public string? GradeId { get; set; }

        /// <summary>
        /// <para>薪资等级时间轴ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7174758360888247852</para>
        /// </summary>
        [JsonProperty("grade_tid")]
        public string? GradeTid { get; set; }

        /// <summary>
        /// <para>带宽上下限和标准值</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("grade_standard_value")]
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
            [JsonProperty("reference_object")]
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
                [JsonProperty("api_name")]
                public string? ApiName { get; set; }

                /// <summary>
                /// <para>值列表 例如部门ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：7156853394442044972</para>
                /// </summary>
                [JsonProperty("id")]
                public string? Id { get; set; }
            }

            /// <summary>
            /// <para>薪资标准类型</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("standard_type")]
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
                /// <item>standard_value：standard_value</item>
                /// <item>bandwidth_and_standard_value：bandwidth_and_standard_value</item>
                /// <item>bandwidth_upper_and_lower_limit：bandwidth_upper_and_lower_limit</item>
                /// </list></para>
                /// </summary>
                [JsonProperty("api_name")]
                public string? ApiName { get; set; }
            }

            /// <summary>
            /// <para>上下限</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("band_width")]
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
                [JsonProperty("upper_limit")]
                public string? UpperLimit { get; set; }

                /// <summary>
                /// <para>下限</para>
                /// <para>必填：否</para>
                /// <para>示例值：10000</para>
                /// </summary>
                [JsonProperty("lower_limit")]
                public string? LowerLimit { get; set; }
            }

            /// <summary>
            /// <para>标准值</para>
            /// <para>必填：否</para>
            /// <para>示例值：12000</para>
            /// </summary>
            [JsonProperty("standard_value")]
            public string? StandardValue { get; set; }
        }

        /// <summary>
        /// <para>币种</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("currency")]
        public CpstCurrency? Currency { get; set; }

        /// <summary>
        /// <para>币种</para>
        /// </summary>
        public record CpstCurrency
        {
            /// <summary>
            /// <para>币种ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6863329932261459464</para>
            /// </summary>
            [JsonProperty("currency_id")]
            public string? CurrencyId { get; set; }

            /// <summary>
            /// <para>币种code</para>
            /// <para>必填：否</para>
            /// <para>示例值：CNY</para>
            /// </summary>
            [JsonProperty("code")]
            public string? Code { get; set; }

            /// <summary>
            /// <para>币种名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("name")]
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
                [JsonProperty("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文</para>
                /// <para>必填：否</para>
                /// <para>示例值：englishname</para>
                /// </summary>
                [JsonProperty("en_us")]
                public string? EnUs { get; set; }
            }
        }

        /// <summary>
        /// <para>薪资标准描述</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("description")]
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
            [JsonProperty("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文</para>
            /// <para>必填：否</para>
            /// <para>示例值：englishname</para>
            /// </summary>
            [JsonProperty("en_us")]
            public string? EnUs { get; set; }
        }
    }

    /// <summary>
    /// <para>生效时间</para>
    /// <para>必填：否</para>
    /// <para>示例值：1660924800000</para>
    /// </summary>
    [JsonProperty("effective_time")]
    public string? EffectiveTime { get; set; }
}
