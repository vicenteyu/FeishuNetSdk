// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-12
//
// Last Modified By : yxr
// Last Modified On : 2024-12-12
// ************************************************************************
// <copyright file="GetHireV2InterviewRecordsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量获取面试评价详细信息（新版） 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 批量获取面试评价详细信息（新版） 响应体
/// <para>批量获取面试评价详细信息，如面试结论、面试得分和面试官等信息。</para>
/// <para>接口ID：7356428725080375298</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/candidate-management/delivery-process-management/interview/list-4</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhire-v2%2finterview_record%2flist</para>
/// </summary>
public record GetHireV2InterviewRecordsResponseDto
{
    /// <summary>
    /// <para>面试评价详细信息列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public InterviewRecord[]? Items { get; set; }

    /// <summary>
    /// <para>面试评价详细信息列表</para>
    /// </summary>
    public record InterviewRecord
    {
        /// <summary>
        /// <para>面试评价 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7171693733661327361</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>面试评价表 ID，详情可查看：[获取面试评价表列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/interview_feedback_form/list)</para>
        /// <para>必填：否</para>
        /// <para>示例值：71716937336613273612</para>
        /// </summary>
        [JsonPropertyName("feedback_form_id")]
        public string? FeedbackFormId { get; set; }

        /// <summary>
        /// <para>提交状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：已提交</item>
        /// <item>2：未提交</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("commit_status")]
        public int? CommitStatus { get; set; }

        /// <summary>
        /// <para>面试评价提交时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1710405457390</para>
        /// </summary>
        [JsonPropertyName("submit_time")]
        public string? SubmitTime { get; set; }

        /// <summary>
        /// <para>面试评价分数</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("record_score")]
        public InterviewRecordRecordScore? RecordScore { get; set; }

        /// <summary>
        /// <para>面试评价分数</para>
        /// </summary>
        public record InterviewRecordRecordScore
        {
            /// <summary>
            /// <para>面试评价得分，精确到小数点后两位</para>
            /// <para>必填：否</para>
            /// <para>示例值：100.00</para>
            /// <para>最大值：2147483647</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("score")]
            public float? Score { get; set; }

            /// <summary>
            /// <para>面试评价总分，精确到小数点后两位</para>
            /// <para>必填：否</para>
            /// <para>示例值：100.00</para>
            /// <para>最大值：2147483647</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("total_score")]
            public float? TotalScore { get; set; }
        }

        /// <summary>
        /// <para>面试官信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("interviewer")]
        public IdNameObject? Interviewer { get; set; }

        /// <summary>
        /// <para>面试官信息</para>
        /// </summary>
        public record IdNameObject
        {
            /// <summary>
            /// <para>面试官 ID，与入参 `user_id_type` 类型一致</para>
            /// <para>必填：是</para>
            /// <para>示例值：7171693733661327364</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string Id { get; set; } = string.Empty;

            /// <summary>
            /// <para>面试官姓名</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>面试官姓名</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>面试官中文名</para>
                /// <para>必填：否</para>
                /// <para>示例值：小明</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>面试官英文名</para>
                /// <para>必填：否</para>
                /// <para>示例值：xiaoming</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }
        }

        /// <summary>
        /// <para>面试评价附件列表</para>
        /// <para>必填：否</para>
        /// <para>最大长度：1000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("attachments")]
        public Attachment[]? Attachments { get; set; }

        /// <summary>
        /// <para>面试评价附件列表</para>
        /// </summary>
        public record Attachment
        {
            /// <summary>
            /// <para>附件 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：7140517838785481004</para>
            /// </summary>
            [JsonPropertyName("file_id")]
            public string? FileId { get; set; }

            /// <summary>
            /// <para>附件名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：1.13测试1的面试记录.pdf</para>
            /// </summary>
            [JsonPropertyName("file_name")]
            public string? FileName { get; set; }

            /// <summary>
            /// <para>附件类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：application/pdf</para>
            /// </summary>
            [JsonPropertyName("content_type")]
            public string? ContentType { get; set; }

            /// <summary>
            /// <para>附件大小</para>
            /// <para>必填：否</para>
            /// <para>示例值：16615</para>
            /// <para>最大值：2147483647</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("file_size")]
            public int? FileSize { get; set; }

            /// <summary>
            /// <para>附件创建时间，毫秒时间戳</para>
            /// <para>必填：否</para>
            /// <para>示例值：1710399930151</para>
            /// </summary>
            [JsonPropertyName("create_time")]
            public string? CreateTime { get; set; }
        }

        /// <summary>
        /// <para>模块评价列表</para>
        /// <para>必填：否</para>
        /// <para>最大长度：1000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("module_assessments")]
        public ModuleAssessment[]? ModuleAssessments { get; set; }

        /// <summary>
        /// <para>模块评价列表</para>
        /// </summary>
        public record ModuleAssessment
        {
            /// <summary>
            /// <para>面试评价表模块 ID，详情可查看：[获取面试评价表列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/interview_feedback_form/list)返回结果中 `data.items.modules` 字段</para>
            /// <para>必填：否</para>
            /// <para>示例值：7171693733661327361</para>
            /// </summary>
            [JsonPropertyName("interview_feedback_form_module_id")]
            public string? InterviewFeedbackFormModuleId { get; set; }

            /// <summary>
            /// <para>模块名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("module_name")]
            public I18n? ModuleName { get; set; }

            /// <summary>
            /// <para>模块名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>模块中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：面试结论</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>模块英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：Interview Result</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }

            /// <summary>
            /// <para>模块类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：系统预置「面试结论」模块</item>
            /// <item>2：自定义模块</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("module_type")]
            public int? ModuleType { get; set; }

            /// <summary>
            /// <para>模块权重，精确到小数点后两位</para>
            /// <para>必填：否</para>
            /// <para>示例值：10.00</para>
            /// <para>最大值：2147483647</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("module_weight")]
            public float? ModuleWeight { get; set; }

            /// <summary>
            /// <para>模块打分，精确到小数点后两位</para>
            /// <para>必填：否</para>
            /// <para>示例值：10.00</para>
            /// <para>最大值：2147483647</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("module_score")]
            public float? ModuleScore { get; set; }

            /// <summary>
            /// <para>模块评价</para>
            /// <para>必填：否</para>
            /// <para>最大长度：1000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("dimension_assessments")]
            public DimensionAssessment[]? DimensionAssessments { get; set; }

            /// <summary>
            /// <para>模块评价</para>
            /// </summary>
            public record DimensionAssessment
            {
                /// <summary>
                /// <para>维度 ID，详情可查看：[获取面试评价表列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/interview_feedback_form/list)返回结果中 `data.items.modules.dimensions` 字段</para>
                /// <para>必填：否</para>
                /// <para>示例值：7171693733661327361</para>
                /// </summary>
                [JsonPropertyName("interview_feedback_form_dimension_id")]
                public string? InterviewFeedbackFormDimensionId { get; set; }

                /// <summary>
                /// <para>维度名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("dimension_name")]
                public I18n? DimensionName { get; set; }

                /// <summary>
                /// <para>维度名称</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>维度中文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：行业知识储备水平</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>维度英文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：Industry knowledge reserve level</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }

                /// <summary>
                /// <para>维度评价方式</para>
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
                [JsonPropertyName("dimension_type")]
                public int? DimensionType { get; set; }

                /// <summary>
                /// <para>维度权重，精确到小数点后两位</para>
                /// <para>必填：否</para>
                /// <para>示例值：1.00</para>
                /// <para>最大值：2147483647</para>
                /// <para>最小值：0</para>
                /// </summary>
                [JsonPropertyName("weight")]
                public float? Weight { get; set; }

                /// <summary>
                /// <para>当维度评价方式为 `描述题` 时，从此取值</para>
                /// <para>必填：否</para>
                /// <para>示例值：描述题作答</para>
                /// </summary>
                [JsonPropertyName("dimension_content")]
                public string? DimensionContent { get; set; }

                /// <summary>
                /// <para>当维度评价方式为 `单选题` 时，从此取值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("dimension_option")]
                public DimensionAssessmentDimensionOption? DimensionOption { get; set; }

                /// <summary>
                /// <para>当维度评价方式为 `单选题` 时，从此取值</para>
                /// </summary>
                public record DimensionAssessmentDimensionOption
                {
                    /// <summary>
                    /// <para>选项 ID，详情可查看：[获取面试评价表列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/interview_feedback_form/list)返回结果中 `data.items.modules.dimensions.option_items` 字段</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：7171693733661327361</para>
                    /// </summary>
                    [JsonPropertyName("id")]
                    public string? Id { get; set; }

                    /// <summary>
                    /// <para>选项名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：7171693733661327361</para>
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
                        /// <para>示例值：选项一</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>选项英文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：Option 1</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }

                    /// <summary>
                    /// <para>选项分数</para>
                    /// <para>**数据范围**：</para>
                    /// <para>- `0` ～ `100`</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：10</para>
                    /// <para>最大值：2147483647</para>
                    /// <para>最小值：0</para>
                    /// </summary>
                    [JsonPropertyName("score_val")]
                    public int? ScoreVal { get; set; }
                }

                /// <summary>
                /// <para>当维度评价方式为 `多选题` 时，从此取值</para>
                /// <para>必填：否</para>
                /// <para>最大长度：1000</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("dimension_options")]
                public DimensionOptionSuffix[]? DimensionOptions { get; set; }

                /// <summary>
                /// <para>当维度评价方式为 `多选题` 时，从此取值</para>
                /// </summary>
                public record DimensionOptionSuffix
                {
                    /// <summary>
                    /// <para>选项 ID，详情可查看：[获取面试评价表列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/interview_feedback_form/list)返回结果中 `data.items.modules.dimensions.option_items` 字段</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：7171693733661327361</para>
                    /// </summary>
                    [JsonPropertyName("id")]
                    public string? Id { get; set; }

                    /// <summary>
                    /// <para>选项名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：7171693733661327361</para>
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
                        /// <para>示例值：选项一</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>选项英文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：Option 1</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }

                    /// <summary>
                    /// <para>选项分数</para>
                    /// <para>**数据范围**：</para>
                    /// <para>- `0` ～ `100`</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：10</para>
                    /// <para>最大值：2147483647</para>
                    /// <para>最小值：0</para>
                    /// </summary>
                    [JsonPropertyName("score_val")]
                    public int? ScoreVal { get; set; }
                }

                /// <summary>
                /// <para>当维度评价方式为 `打分题(填空)` 时，从此取值</para>
                /// <para>必填：否</para>
                /// <para>示例值：10</para>
                /// <para>最大值：2147483647</para>
                /// <para>最小值：0</para>
                /// </summary>
                [JsonPropertyName("dimension_score")]
                public int? DimensionScore { get; set; }

                /// <summary>
                /// <para>当维度评价方式为 `职级建议` 时，从此取值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("recommended_job_level")]
                public DimensionAssessmentRecommendedJobLevel? RecommendedJobLevel { get; set; }

                /// <summary>
                /// <para>当维度评价方式为 `职级建议` 时，从此取值</para>
                /// </summary>
                public record DimensionAssessmentRecommendedJobLevel
                {
                    /// <summary>
                    /// <para>最低职级建议</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("lower_limit_job_level_name")]
                    public I18n? LowerLimitJobLevelName { get; set; }

                    /// <summary>
                    /// <para>最低职级建议</para>
                    /// </summary>
                    public record I18n
                    {
                        /// <summary>
                        /// <para>最低职级建议中文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：2-2</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>最低职级建议英文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：2-2</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }

                    /// <summary>
                    /// <para>最高职级建议</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("higher_limit_job_level_name")]
                    public I18n? HigherLimitJobLevelName { get; set; }
                }

                /// <summary>
                /// <para>面试题</para>
                /// <para>必填：否</para>
                /// <para>最大长度：1000</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("question_assessments")]
                public QuestionAssessment[]? QuestionAssessments { get; set; }

                /// <summary>
                /// <para>面试题</para>
                /// </summary>
                public record QuestionAssessment
                {
                    /// <summary>
                    /// <para>面试题类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>1：普通面试题目</item>
                    /// <item>2：在线编程题目</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("question_type")]
                    public int? QuestionType { get; set; }

                    /// <summary>
                    /// <para>面试题名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("title")]
                    public I18n? Title { get; set; }

                    /// <summary>
                    /// <para>面试题名称</para>
                    /// </summary>
                    public record I18n
                    {
                        /// <summary>
                        /// <para>面试题中文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：操作系统进程调度</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>面试题英文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：Operating system process scheduling</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }

                    /// <summary>
                    /// <para>面试题描述</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("description")]
                    public I18n? Description { get; set; }

                    /// <summary>
                    /// <para>面试者作答内容</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：操作系统的进程调度是通过...</para>
                    /// </summary>
                    [JsonPropertyName("content")]
                    public string? Content { get; set; }

                    /// <summary>
                    /// <para>能力项列表</para>
                    /// <para>必填：否</para>
                    /// <para>最大长度：1000</para>
                    /// <para>最小长度：0</para>
                    /// </summary>
                    [JsonPropertyName("abilities")]
                    public Ability[]? Abilities { get; set; }

                    /// <summary>
                    /// <para>能力项列表</para>
                    /// </summary>
                    public record Ability
                    {
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
                            /// <para>示例值：算法</para>
                            /// </summary>
                            [JsonPropertyName("zh_cn")]
                            public string? ZhCn { get; set; }

                            /// <summary>
                            /// <para>能力项英文名称</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：Algorithm</para>
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
