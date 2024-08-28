// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-08-02
// ************************************************************************
// <copyright file="GetHireV1InterviewRecordsByInterviewRecordIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取面试评价详细信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取面试评价详细信息 响应体
/// <para>获取面试评价详细信息，如面试结论、面试得分和面试官等信息。</para>
/// <para>接口ID：6989078472837316611</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/interview/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2finterview_record%2fget</para>
/// </summary>
public record GetHireV1InterviewRecordsByInterviewRecordIdResponseDto
{
    /// <summary>
    /// <para>面试评价详细信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("interview_record")]
    public GetHireV1InterviewRecordsByInterviewRecordIdResponseDtoInterviewRecord? InterviewRecord { get; set; }

    /// <summary>
    /// <para>面试评价详细信息</para>
    /// </summary>
    public record GetHireV1InterviewRecordsByInterviewRecordIdResponseDtoInterviewRecord
    {
        /// <summary>
        /// <para>面试评价 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6949805467799537964</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>面试官用户 ID，与入参 `user_id_type` 类型一致</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_d5a80ec46044e4454036308c8e19dc64</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>系统预设「记录」题目内容，见「飞书招聘」-「设置」-「面试设置」-「面试评价表设置」中的「记录」模块</para>
        /// <para>必填：否</para>
        /// <para>示例值：代码能力强，思维逻辑清晰</para>
        /// </summary>
        [JsonPropertyName("content")]
        public string? Content { get; set; }

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
        /// <para>面试评价提交时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1659318415000</para>
        /// </summary>
        [JsonPropertyName("feedback_submit_time")]
        public long? FeedbackSubmitTime { get; set; }

        /// <summary>
        /// <para>面试结论</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：通过</item>
        /// <item>2：未通过</item>
        /// <item>3：未开始</item>
        /// <item>4：未提交</item>
        /// <item>5：未到场</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("conclusion")]
        public int? Conclusion { get; set; }

        /// <summary>
        /// <para>面试得分</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("interview_score")]
        public GetHireV1InterviewRecordsByInterviewRecordIdResponseDtoInterviewRecordInterviewScore? InterviewScore { get; set; }

        /// <summary>
        /// <para>面试得分</para>
        /// </summary>
        public record GetHireV1InterviewRecordsByInterviewRecordIdResponseDtoInterviewRecordInterviewScore
        {
            /// <summary>
            /// <para>面试得分 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6949805467799537964</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>面试得分分数级别</para>
            /// <para>必填：否</para>
            /// <para>示例值：3</para>
            /// </summary>
            [JsonPropertyName("level")]
            public int? Level { get; set; }

            /// <summary>
            /// <para>面试得分中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：3</para>
            /// </summary>
            [JsonPropertyName("zh_name")]
            public string? ZhName { get; set; }

            /// <summary>
            /// <para>面试得分中文描述</para>
            /// <para>必填：否</para>
            /// <para>示例值：通过, 能力达到要求, 建议录用</para>
            /// </summary>
            [JsonPropertyName("zh_description")]
            public string? ZhDescription { get; set; }

            /// <summary>
            /// <para>面试得分英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：three</para>
            /// </summary>
            [JsonPropertyName("en_name")]
            public string? EnName { get; set; }

            /// <summary>
            /// <para>面试得分英文描述</para>
            /// <para>必填：否</para>
            /// <para>示例值：Pass, ability to meet the requirements, suggest to hire</para>
            /// </summary>
            [JsonPropertyName("en_description")]
            public string? EnDescription { get; set; }
        }

        /// <summary>
        /// <para>面评打分题分数</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("assessment_score")]
        public AssessmentScoreInfo? AssessmentScore { get; set; }

        /// <summary>
        /// <para>面评打分题分数</para>
        /// </summary>
        public record AssessmentScoreInfo
        {
            /// <summary>
            /// <para>计分方式</para>
            /// <para>必填：是</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：总分</item>
            /// <item>2：平均分</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("calculate_type")]
            public int CalculateType { get; set; }

            /// <summary>
            /// <para>分数，精确到小数点后两位</para>
            /// <para>必填：是</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonPropertyName("score")]
            public float Score { get; set; }

            /// <summary>
            /// <para>满分</para>
            /// <para>必填：否</para>
            /// <para>示例值：100</para>
            /// </summary>
            [JsonPropertyName("full_score")]
            public int? FullScore { get; set; }
        }

        /// <summary>
        /// <para>面试题目</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("question_list")]
        public InterviewQuestion[]? QuestionLists { get; set; }

        /// <summary>
        /// <para>面试题目</para>
        /// </summary>
        public record InterviewQuestion
        {
            /// <summary>
            /// <para>面试题题目 ID</para>
            /// <para>必填：是</para>
            /// <para>示例值：7270798542321666367</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string Id { get; set; } = string.Empty;

            /// <summary>
            /// <para>面试题题目</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("title")]
            public I18n? Title { get; set; }

            /// <summary>
            /// <para>面试题题目</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>面试题中文题目</para>
                /// <para>必填：否</para>
                /// <para>示例值：你从业几年了？</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>面试题英文题目</para>
                /// <para>必填：否</para>
                /// <para>示例值：How long have you been working？</para>
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
            /// <para>示例值：没有</para>
            /// </summary>
            [JsonPropertyName("content")]
            public string? Content { get; set; }

            /// <summary>
            /// <para>题目关联的能力项</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("ability_list")]
            public Ability[]? AbilityLists { get; set; }

            /// <summary>
            /// <para>题目关联的能力项</para>
            /// </summary>
            public record Ability
            {
                /// <summary>
                /// <para>能力项 ID</para>
                /// <para>必填：是</para>
                /// <para>示例值：7270798542321666366</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string Id { get; set; } = string.Empty;

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
                    /// <para>示例值：创新思维</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>能力项英文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：Creative Thinking</para>
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

        /// <summary>
        /// <para>在线编程题目</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("code_question_list")]
        public InterviewQuestion[]? CodeQuestionLists { get; set; }

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
            /// <para>面试官用户 ID，与入参 `user_id_type` 类型一致</para>
            /// <para>必填：否</para>
            /// <para>示例值：1213213123123</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

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
                /// <para>示例值：赵鹏</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>面试官英文名</para>
                /// <para>必填：否</para>
                /// <para>示例值：Tom cruise</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }
        }

        /// <summary>
        /// <para>面试评价图片附件</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("image_list")]
        public AttachmentV2[]? ImageLists { get; set; }

        /// <summary>
        /// <para>面试评价图片附件</para>
        /// </summary>
        public record AttachmentV2
        {
            /// <summary>
            /// <para>图片附件 ID，详情请参考[获取附件信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/attachment/get)</para>
            /// <para>必填：是</para>
            /// <para>示例值：7270798542321666364</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string Id { get; set; } = string.Empty;

            /// <summary>
            /// <para>图片附件下载链接，有效期为 30 分钟</para>
            /// <para>必填：是</para>
            /// <para>示例值：https://open.feishu.cn/hire/file/blob/xxxx/</para>
            /// </summary>
            [JsonPropertyName("url")]
            public string Url { get; set; } = string.Empty;

            /// <summary>
            /// <para>图片附件文件名</para>
            /// <para>必填：否</para>
            /// <para>示例值：成绩单</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>图片附件类型（[MIME](https://baike.baidu.com/item/MIME/2900607?fr=ge_ala#2)）</para>
            /// <para>必填：否</para>
            /// <para>示例值：image/jpg</para>
            /// </summary>
            [JsonPropertyName("mime")]
            public string? Mime { get; set; }

            /// <summary>
            /// <para>图片附件创建时间，毫秒时间戳</para>
            /// <para>必填：否</para>
            /// <para>示例值：1693884103327</para>
            /// </summary>
            [JsonPropertyName("create_time")]
            public string? CreateTime { get; set; }
        }

        /// <summary>
        /// <para>面试维度评价信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("dimension_assessment_list")]
        public InterviewDimensionAssessment[]? DimensionAssessmentLists { get; set; }

        /// <summary>
        /// <para>面试维度评价信息</para>
        /// </summary>
        public record InterviewDimensionAssessment
        {
            /// <summary>
            /// <para>维度评价 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6949805467799537964</para>
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
                /// <para>示例值：执行力</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>维度英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：Execution capability</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }

            /// <summary>
            /// <para>打分题总分，仅当维度评价方式为 `打分题(单选)`、`打分题(填空)` 时可用</para>
            /// <para>必填：否</para>
            /// <para>示例值：100</para>
            /// </summary>
            [JsonPropertyName("full_score")]
            public int? FullScore { get; set; }

            /// <summary>
            /// <para>当维度评价方式为 `描述题` 时，从此取值</para>
            /// <para>必填：否</para>
            /// <para>示例值：这个候选人还不错</para>
            /// </summary>
            [JsonPropertyName("content")]
            public string? Content { get; set; }

            /// <summary>
            /// <para>维度 ID，详情可查看：[获取面试评价表列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/interview_feedback_form/list)返回结果中 `data.items.modules.dimensions` 字段</para>
            /// <para>必填：否</para>
            /// <para>示例值：11111111</para>
            /// </summary>
            [JsonPropertyName("dimension_id")]
            public string? DimensionId { get; set; }

            /// <summary>
            /// <para>当维度评价方式为 `单选题`/`打分题(单选)` 时，从此取值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("dimension_score")]
            public InterviewDimensionScore? DimensionScore { get; set; }

            /// <summary>
            /// <para>当维度评价方式为 `单选题`/`打分题(单选)` 时，从此取值</para>
            /// </summary>
            public record InterviewDimensionScore
            {
                /// <summary>
                /// <para>选项 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：6949805467799537964</para>
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
                    /// <para>示例值：选项 1</para>
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
                /// <para>选项对应的分数，维度评价为方式 `打分题(单选)` 时关注该字段</para>
                /// <para>必填：否</para>
                /// <para>示例值：10</para>
                /// </summary>
                [JsonPropertyName("score_val")]
                public int? ScoreVal { get; set; }
            }

            /// <summary>
            /// <para>当维度评价方式为 `多选题` 时，从此取值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("dimension_score_list")]
            public InterviewDimensionScore[]? DimensionScoreLists { get; set; }

            /// <summary>
            /// <para>当维度评价方式为 `打分题(填空)时`，从此取值</para>
            /// <para>必填：否</para>
            /// <para>示例值：10</para>
            /// </summary>
            [JsonPropertyName("dimension_custom_score")]
            public int? DimensionCustomScore { get; set; }

            /// <summary>
            /// <para>维度关联能力项</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("ability_list")]
            public Ability[]? AbilityLists { get; set; }

            /// <summary>
            /// <para>维度关联能力项</para>
            /// </summary>
            public record Ability
            {
                /// <summary>
                /// <para>能力项 ID</para>
                /// <para>必填：是</para>
                /// <para>示例值：7270798542321666366</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string Id { get; set; } = string.Empty;

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
                    /// <para>示例值：创新思维</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>能力项英文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：Creative Thinking</para>
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

            /// <summary>
            /// <para>维度关联面试题</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("question_list")]
            public InterviewQuestion[]? QuestionLists { get; set; }

            /// <summary>
            /// <para>维度关联面试题</para>
            /// </summary>
            public record InterviewQuestion
            {
                /// <summary>
                /// <para>面试题题目 ID</para>
                /// <para>必填：是</para>
                /// <para>示例值：7270798542321666367</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string Id { get; set; } = string.Empty;

                /// <summary>
                /// <para>面试题题目</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("title")]
                public I18n? Title { get; set; }

                /// <summary>
                /// <para>面试题题目</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>面试中文题目</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：是否遇到过团队成员没有达到目标的情况</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>面试英文题目</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：Have you ever encountered a situation where a team member did not meet their goals?</para>
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
                /// <para>示例值：没有</para>
                /// </summary>
                [JsonPropertyName("content")]
                public string? Content { get; set; }

                /// <summary>
                /// <para>题目关联的能力项</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("ability_list")]
                public Ability[]? AbilityLists { get; set; }

                /// <summary>
                /// <para>题目关联的能力项</para>
                /// </summary>
                public record Ability
                {
                    /// <summary>
                    /// <para>能力项 ID</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：7270798542321666366</para>
                    /// </summary>
                    [JsonPropertyName("id")]
                    public string Id { get; set; } = string.Empty;

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
                        /// <para>示例值：创新思维</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>能力项英文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：Creative Thinking</para>
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

            /// <summary>
            /// <para>维度评价方式</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：单选题</item>
            /// <item>2：多选题</item>
            /// <item>3：描述题</item>
            /// <item>4：单行文本</item>
            /// <item>5：职级范围</item>
            /// <item>6：打分题(单选)</item>
            /// <item>7：打分题(填空)</item>
            /// <item>10：系统预设题目 - 结论</item>
            /// <item>11：系统预设题目 - 得分</item>
            /// <item>12：系统预设题目 - 记录</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("dimension_type")]
            public int? DimensionType { get; set; }
        }
    }
}
