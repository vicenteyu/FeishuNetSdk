// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="GetHireV1InterviewFeedbackFormsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取面试评价表列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取面试评价表列表 响应体
/// <para>获取面试评价表信息列表，评价表信息包括题目描述、题目选项等。可用于面试评价表展示等场景。</para>
/// <para>## 注意事项</para>
/// <para>- 面试评价表通过版本进行变更管理，每次修改评价表都会更新版本，同时变更评价表ID、模块ID、模块维度ID、选项ID、能力项ID。</para>
/// <para>- 当使用分页方式获取数据时，仅能获取到最新版本的面试评价表，当指定面试评价表 ID 列表时，可以获取到历史版本面评评价表。</para>
/// <para>## 面试评价表产品示意图</para>
/// <para>接口ID：7356428725080342530</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/recruitment-related-configuration/interview-settings/list-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2finterview_feedback_form%2flist</para>
/// </summary>
public record GetHireV1InterviewFeedbackFormsResponseDto : IPageableResponse<GetHireV1InterviewFeedbackFormsResponseDto.InterviewFeedbackForm>
{
    /// <summary>
    /// <para>面试评价表信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public InterviewFeedbackForm[]? Items { get; set; }

    /// <summary>
    /// <para>面试评价表信息</para>
    /// </summary>
    public record InterviewFeedbackForm
    {
        /// <summary>
        /// <para>面试评价表ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6969137186734393644</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>面试评价表版本号</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// <para>面试评价表名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n? Name { get; set; }

        /// <summary>
        /// <para>面试评价表名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>面试评价表中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：默认面试评价表</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>面试评价表英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：default interview assessment template</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>面试评价表类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：普通评价表</item>
        /// <item>2：打分评价表</item>
        /// <item>3：权重评价表</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("type")]
        public int? Type { get; set; }

        /// <summary>
        /// <para>面试评价表打分计算配置，当评价表类型为打分评价表（type=2）时，该字段生效</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("score_calculation_config")]
        public InterviewFeedbackFormScoreCalculationConfig? ScoreCalculationConfig { get; set; }

        /// <summary>
        /// <para>面试评价表打分计算配置，当评价表类型为打分评价表（type=2）时，该字段生效</para>
        /// </summary>
        public record InterviewFeedbackFormScoreCalculationConfig
        {
            /// <summary>
            /// <para>是否启用</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("enabled")]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>计算类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：计算总分</item>
            /// <item>2：计算平均分</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("calculation_mode")]
            public int? CalculationMode { get; set; }
        }

        /// <summary>
        /// <para>面试评价表模块列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("modules")]
        public InterviewFeedbackFormModule[]? Modules { get; set; }

        /// <summary>
        /// <para>面试评价表模块列表</para>
        /// </summary>
        public record InterviewFeedbackFormModule
        {
            /// <summary>
            /// <para>面试评价表模块ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6930815272790114324</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>模块名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>模块名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>模块中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：默认面试评价表模块</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>模块英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：default interview assessment module</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }

            /// <summary>
            /// <para>模块描述</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("description")]
            public I18n? Description { get; set; }

            /// <summary>
            /// <para>模块类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：系统预置「面试结论」模块</item>
            /// <item>2：自定义模块</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("type")]
            public int? Type { get; set; }

            /// <summary>
            /// <para>模块顺序</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonPropertyName("sequence")]
            public int? Sequence { get; set; }

            /// <summary>
            /// <para>模块权重</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonPropertyName("weight")]
            public float? Weight { get; set; }

            /// <summary>
            /// <para>模块维度列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("dimensions")]
            public InterviewFeedbackFormDimension[]? Dimensions { get; set; }

            /// <summary>
            /// <para>模块维度列表</para>
            /// </summary>
            public record InterviewFeedbackFormDimension
            {
                /// <summary>
                /// <para>模块维度ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：6930815272790114324</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>维度名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public I18n? Name { get; set; }

                /// <summary>
                /// <para>维度名称</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>维度中文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：默认评价维度</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>维度英文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：default dimension</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }

                /// <summary>
                /// <para>维度描述</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("description")]
                public I18n? Description { get; set; }

                /// <summary>
                /// <para>维度类型</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：单选题</item>
                /// <item>2：多选题</item>
                /// <item>3：描述题</item>
                /// <item>5：职级建议</item>
                /// <item>6：打分题(单选)</item>
                /// <item>7：打分题(填空)</item>
                /// <item>10：系统预置-结论</item>
                /// <item>11：系统预置-得分</item>
                /// <item>12：系统预置-记录</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("type")]
                public int? Type { get; set; }

                /// <summary>
                /// <para>是否启用</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("enabled")]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>维度顺序</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("sequence")]
                public int? Sequence { get; set; }

                /// <summary>
                /// <para>是否必选</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_required")]
                public bool? IsRequired { get; set; }

                /// <summary>
                /// <para>维度权重</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("weight")]
                public float? Weight { get; set; }

                /// <summary>
                /// <para>评价维度的分数配置，适用于打分题(type = 6 或者 type =7)</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("score_dimension_config")]
                public InterviewFeedbackFormDimensionScoreDimensionConfig? ScoreDimensionConfig { get; set; }

                /// <summary>
                /// <para>评价维度的分数配置，适用于打分题(type = 6 或者 type =7)</para>
                /// </summary>
                public record InterviewFeedbackFormDimensionScoreDimensionConfig
                {
                    /// <summary>
                    /// <para>分数维度类型，属于打分题的子维度类型，包括固定分值、自定义分值</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>1：固定分值打分题</item>
                    /// <item>2：自定义分值打分题</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("score_dimension_type")]
                    public int? ScoreDimensionType { get; set; }

                    /// <summary>
                    /// <para>分数下限</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// </summary>
                    [JsonPropertyName("lower_limit_score")]
                    public int? LowerLimitScore { get; set; }

                    /// <summary>
                    /// <para>分数上限</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：100</para>
                    /// </summary>
                    [JsonPropertyName("upper_limit_score")]
                    public int? UpperLimitScore { get; set; }
                }

                /// <summary>
                /// <para>选项列表, 适用于单选题和多选题（单选题type=1，多选题type=2）</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("option_items")]
                public InterviewDimensionOption[]? OptionItems { get; set; }

                /// <summary>
                /// <para>选项列表, 适用于单选题和多选题（单选题type=1，多选题type=2）</para>
                /// </summary>
                public record InterviewDimensionOption
                {
                    /// <summary>
                    /// <para>选项ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：6930815272790114324</para>
                    /// </summary>
                    [JsonPropertyName("id")]
                    public string? Id { get; set; }

                    /// <summary>
                    /// <para>选项名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public I18n? Name { get; set; }

                    /// <summary>
                    /// <para>选项名称</para>
                    /// </summary>
                    public record I18n
                    {
                        /// <summary>
                        /// <para>选项中文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：默认选项</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>选项英文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：default option</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }

                    /// <summary>
                    /// <para>选项描述</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("description")]
                    public I18n? Description { get; set; }

                    /// <summary>
                    /// <para>选项分数值</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// </summary>
                    [JsonPropertyName("score_val")]
                    public int? ScoreVal { get; set; }
                }

                /// <summary>
                /// <para>是否展示「无法判断」选项，仅适用于「职级建议」的维度类型（type=5）</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("display_not_evident")]
                public bool? DisplayNotEvident { get; set; }

                /// <summary>
                /// <para>能力项列表，全类型适用</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("ability_list")]
                public DimensionAbility[]? AbilityLists { get; set; }

                /// <summary>
                /// <para>能力项列表，全类型适用</para>
                /// </summary>
                public record DimensionAbility
                {
                    /// <summary>
                    /// <para>能力项ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：6930815272790114324</para>
                    /// </summary>
                    [JsonPropertyName("id")]
                    public string? Id { get; set; }

                    /// <summary>
                    /// <para>能力项名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public I18n? Name { get; set; }

                    /// <summary>
                    /// <para>能力项名称</para>
                    /// </summary>
                    public record I18n
                    {
                        /// <summary>
                        /// <para>能力项中文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：默认能力项</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>能力项英文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：default ability</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }

                    /// <summary>
                    /// <para>能力项描述</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("description")]
                    public I18n? Description { get; set; }
                }
            }
        }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
