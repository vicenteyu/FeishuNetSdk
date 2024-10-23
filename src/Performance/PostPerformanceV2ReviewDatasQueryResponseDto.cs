// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-02
//
// Last Modified By : yxr
// Last Modified On : 2024-10-23
// ************************************************************************
// <copyright file="PostPerformanceV2ReviewDatasQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取绩效详情数据 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Performance;
/// <summary>
/// 获取绩效详情数据 响应体
/// <para>获取被评估人各环节的绩效评估详情（不包含校准环节），如环节评估数据、环节提交状态等</para>
/// <para>接口ID：7351374599659847684</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/review_data/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2freview_data%2fquery</para>
/// </summary>
public record PostPerformanceV2ReviewDatasQueryResponseDto
{
    /// <summary>
    /// <para>评估数据列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("datas")]
    public ReviewProfile[]? Datas { get; set; }

    /// <summary>
    /// <para>评估数据列表</para>
    /// </summary>
    public record ReviewProfile
    {
        /// <summary>
        /// <para>被评估人 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public User? UserId { get; set; }

        /// <summary>
        /// <para>被评估人 ID</para>
        /// </summary>
        public record User
        {
            /// <summary>
            /// <para>用户的 open_id</para>
            /// <para>必填：否</para>
            /// <para>示例值：od-asd2dasdasd</para>
            /// </summary>
            [JsonPropertyName("open_id")]
            public string? OpenId { get; set; }

            /// <summary>
            /// <para>用户的 user_id，ID 类型与user_id_type 的取值一致</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou-ux987dsf6x</para>
            /// </summary>
            [JsonPropertyName("user_id")]
            public string? UserId { get; set; }
        }

        /// <summary>
        /// <para>绩效评估周期 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7343513161666707459</para>
        /// </summary>
        [JsonPropertyName("semester_id")]
        public string? SemesterId { get; set; }

        /// <summary>
        /// <para>绩效评估项目 ID，详细信息请参考[获取项目配置](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/activity/query)</para>
        /// <para>必填：否</para>
        /// <para>示例值：7343513161666707459</para>
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string? ActivityId { get; set; }

        /// <summary>
        /// <para>被评估人在该周期对应的后台评估模板 ID，详细信息请参考[获取评估模版配置](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/review_template/query)</para>
        /// <para>必填：否</para>
        /// <para>示例值：7343513161666707459</para>
        /// </summary>
        [JsonPropertyName("review_template_id")]
        public string? ReviewTemplateId { get; set; }

        /// <summary>
        /// <para>本周期内各环节内容</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("stages")]
        public ReviewStage[]? Stages { get; set; }

        /// <summary>
        /// <para>本周期内各环节内容</para>
        /// </summary>
        public record ReviewStage
        {
            /// <summary>
            /// <para>环节 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：7343513161666707459</para>
            /// </summary>
            [JsonPropertyName("stage_id")]
            public string? StageId { get; set; }

            /// <summary>
            /// <para>环节类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：review</para>
            /// <para>可选值：<list type="bullet">
            /// <item>summarize_key_outputs：工作总结环节</item>
            /// <item>review：评估型环节</item>
            /// <item>communication_and_open_result：结果沟通环节</item>
            /// <item>view_result：绩效结果查看环节</item>
            /// <item>reconsideration：结果复议环节</item>
            /// <item>leader_review：终评环节（特指最终的绩效结果数据）</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("stage_type")]
            public string? StageType { get; set; }

            /// <summary>
            /// <para>该环节对应的环节模板的 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：7343513161666707459</para>
            /// </summary>
            [JsonPropertyName("template_id")]
            public string? TemplateId { get; set; }

            /// <summary>
            /// <para>评估内容记录。多人评估的环节有多份记录，比如 360 评估环节。如果开启了 360 匿名评估，并且是对全部查看者匿名，则评估记录数低于匿名下限，则不返回 360 评估记录</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("records")]
            public ReviewRecord[]? Records { get; set; }

            /// <summary>
            /// <para>评估内容记录。多人评估的环节有多份记录，比如 360 评估环节。如果开启了 360 匿名评估，并且是对全部查看者匿名，则评估记录数低于匿名下限，则不返回 360 评估记录</para>
            /// </summary>
            public record ReviewRecord
            {
                /// <summary>
                /// <para>评估人的环节状态。各类型的环节分别有以下环节状态：</para>
                /// <para>查看绩效结果环节状态</para>
                /// <para>可选值有：</para>
                /// <para>- `0`：已开通，绩效结果已开通，未发起复议也无需确认结果</para>
                /// <para>- `1`：待确认，绩效结果已开通但被评估人还未确认结果，确认的截止时间还未到达</para>
                /// <para>- `2`：已截止，绩效结果已开通但被评估人还未确认结果，确认的截止时间已到达</para>
                /// <para>- `3`：已确认，绩效结果已开通，被评估人已确认结果</para>
                /// <para>- `4`：已复议，绩效结果已开通，且被评估人已发起复议</para>
                /// <para>终评环节/结果沟通环节状态（不传默认包含所有的状态）</para>
                /// <para>绩效结果复议环节状态</para>
                /// <para>可选值有：</para>
                /// <para>- `1`：待完成，任务未完成</para>
                /// <para>- `2`：已截止，任务的截止时间已到达，且任务未完成</para>
                /// <para>- `3`：已完成，任务已完成</para>
                /// <para>除上述类型外的其他环节类型状态</para>
                /// <para>可选值有：</para>
                /// <para>- `0`：未开始，任务的开始时间未到达</para>
                /// <para>- `1`：待完成，任务的开始时间到达而截止时间未到达，且任务未完成</para>
                /// <para>- `2`：已截止，任务的截止时间已到达，且任务未完成</para>
                /// <para>- `3`: 已完成，任务已完成</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("progress")]
                public int? Progress { get; set; }

                /// <summary>
                /// <para>评估记录中的评估内容明细</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("units")]
                public ReviewUnit[]? Units { get; set; }

                /// <summary>
                /// <para>评估记录中的评估内容明细</para>
                /// </summary>
                public record ReviewUnit
                {
                    /// <summary>
                    /// <para>评估内容 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：7343513161666707459</para>
                    /// </summary>
                    [JsonPropertyName("unit_id")]
                    public string? UnitId { get; set; }

                    /// <summary>
                    /// <para>是否为不了解。当评估人选不了解时，会返回为 true，其他时候不返回。</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：false</para>
                    /// </summary>
                    [JsonPropertyName("is_unknown")]
                    public bool? IsUnknown { get; set; }

                    /// <summary>
                    /// <para>评估题列表，指评估内容中的每个题，可能是评估项或者填写项</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("data")]
                    public ReviewDetail[]? Datas { get; set; }

                    /// <summary>
                    /// <para>评估题列表，指评估内容中的每个题，可能是评估项或者填写项</para>
                    /// </summary>
                    public record ReviewDetail
                    {
                        /// <summary>
                        /// <para>评估题 ID，指评估内容中的每个评估项或填写项</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：7343513161666707459</para>
                        /// </summary>
                        [JsonPropertyName("field_id")]
                        public string FieldId { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>评估人 ID。如果开启了 360 匿名评估，并且是对全部查看者匿名，则不返回该值</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("reviewer_user_id")]
                        public User? ReviewerUserId { get; set; }

                        /// <summary>
                        /// <para>评估人 ID。如果开启了 360 匿名评估，并且是对全部查看者匿名，则不返回该值</para>
                        /// </summary>
                        public record User
                        {
                            /// <summary>
                            /// <para>用户的 open_id</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：od-asd2dasdasd</para>
                            /// </summary>
                            [JsonPropertyName("open_id")]
                            public string? OpenId { get; set; }

                            /// <summary>
                            /// <para>用户的 user_id，ID 类型与user_id_type 的取值一致</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：ou-ux987dsf6x</para>
                            /// </summary>
                            [JsonPropertyName("user_id")]
                            public string? UserId { get; set; }
                        }

                        /// <summary>
                        /// <para>该评估题的最后提交时间，毫秒级时间戳</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：7343513161666707459</para>
                        /// </summary>
                        [JsonPropertyName("submit_time")]
                        public string? SubmitTime { get; set; }

                        /// <summary>
                        /// <para>评估项 ID（不包含子评估项），option_id 或 score 有值的时候有值，详细信息请参考[获取评估项配置](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/indicator/query)</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：7343513161666707459</para>
                        /// </summary>
                        [JsonPropertyName("indicator_id")]
                        public string? IndicatorId { get; set; }

                        /// <summary>
                        /// <para>评估等级 ID</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：7343513161666707459</para>
                        /// </summary>
                        [JsonPropertyName("option_id")]
                        public string? OptionId { get; set; }

                        /// <summary>
                        /// <para>评分</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1.1</para>
                        /// </summary>
                        [JsonPropertyName("score")]
                        public string? Score { get; set; }

                        /// <summary>
                        /// <para>填写项填写的文本</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：qwert</para>
                        /// </summary>
                        [JsonPropertyName("text")]
                        public string? Text { get; set; }

                        /// <summary>
                        /// <para>标签填写题 ID，详细信息请参考[获取标签填写题配置](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/question/query)</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：7343513161666707459</para>
                        /// </summary>
                        [JsonPropertyName("tag_based_question_id")]
                        public string? TagBasedQuestionId { get; set; }

                        /// <summary>
                        /// <para>标签填写项的内容</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("tag_text_item_data")]
                        public TagText[]? TagTextItemDatas { get; set; }

                        /// <summary>
                        /// <para>标签填写项的内容</para>
                        /// </summary>
                        public record TagText
                        {
                            /// <summary>
                            /// <para>标签 ID</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：7343513161666707459</para>
                            /// </summary>
                            [JsonPropertyName("tag_text_id")]
                            public string? TagTextId { get; set; }

                            /// <summary>
                            /// <para>评估人在该标签下填写的文本</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：qwertyu</para>
                            /// </summary>
                            [JsonPropertyName("tag_text")]
                            public string? TagTextSuffix { get; set; }

                            /// <summary>
                            /// <para>富文本格式的填写内容，解析方式见 [editor](https://open.larkoffice.com/document/client-docs/gadget/component-component/basic-component/form/editor#51af2f4f)</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：{\"ops\":[{\"name\":\"insert\",\"text\":\"qwerty\"}]}</para>
                            /// </summary>
                            [JsonPropertyName("tag_richtext")]
                            public string? TagRichtext { get; set; }
                        }

                        /// <summary>
                        /// <para>绩效系数值</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1.1</para>
                        /// </summary>
                        [JsonPropertyName("perf_coefficient_value")]
                        public string? PerfCoefficientValue { get; set; }

                        /// <summary>
                        /// <para>子评估项内容</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("sub_indicator_data")]
                        public SubIndicator[]? SubIndicatorDatas { get; set; }

                        /// <summary>
                        /// <para>子评估项内容</para>
                        /// </summary>
                        public record SubIndicator
                        {
                            /// <summary>
                            /// <para>子评估题 ID</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：7343513161666707459</para>
                            /// </summary>
                            [JsonPropertyName("field_id")]
                            public string FieldId { get; set; } = string.Empty;

                            /// <summary>
                            /// <para>子评估项 ID</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：7343513161666707459</para>
                            /// </summary>
                            [JsonPropertyName("indicator_id")]
                            public string? IndicatorId { get; set; }

                            /// <summary>
                            /// <para>子评估项的评估等级 ID</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：7343513161666707459</para>
                            /// </summary>
                            [JsonPropertyName("option_id")]
                            public string? OptionId { get; set; }

                            /// <summary>
                            /// <para>子评估项的评分</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：1.1</para>
                            /// </summary>
                            [JsonPropertyName("score")]
                            public string? Score { get; set; }

                            /// <summary>
                            /// <para>子评估项填写的文本</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：qwertyuiop</para>
                            /// </summary>
                            [JsonPropertyName("text")]
                            public string? Text { get; set; }

                            /// <summary>
                            /// <para>富文本格式的填写内容，解析方式见 [editor](https://open.larkoffice.com/document/client-docs/gadget/component-component/basic-component/form/editor#51af2f4f)</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：{\"ops\":[{\"name\":\"insert\",\"text\":\"qwerty\"}]}</para>
                            /// </summary>
                            [JsonPropertyName("richtext")]
                            public string? Richtext { get; set; }
                        }

                        /// <summary>
                        /// <para>评估的目标数据，当评估内容是对目标（O）或关键举措（KR）评估时有值</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("objective_data")]
                        public ObjectiveData[]? ObjectiveDatas { get; set; }

                        /// <summary>
                        /// <para>评估的目标数据，当评估内容是对目标（O）或关键举措（KR）评估时有值</para>
                        /// </summary>
                        public record ObjectiveData
                        {
                            /// <summary>
                            /// <para>目标 ID</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：7343513161666707459</para>
                            /// </summary>
                            [JsonPropertyName("objective_id")]
                            public string ObjectiveId { get; set; } = string.Empty;

                            /// <summary>
                            /// <para>目标的评分</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：1.1</para>
                            /// </summary>
                            [JsonPropertyName("score")]
                            public string? Score { get; set; }

                            /// <summary>
                            /// <para>评估人在该填写项填写的文本</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：qwertyu</para>
                            /// </summary>
                            [JsonPropertyName("text")]
                            public string? Text { get; set; }

                            /// <summary>
                            /// <para>评估的关键举措，当评估内容是对关键举措（KR）评估时有值</para>
                            /// <para>必填：否</para>
                            /// </summary>
                            [JsonPropertyName("keyresult_data")]
                            public KeyresultData[]? KeyresultDatas { get; set; }

                            /// <summary>
                            /// <para>评估的关键举措，当评估内容是对关键举措（KR）评估时有值</para>
                            /// </summary>
                            public record KeyresultData
                            {
                                /// <summary>
                                /// <para>关键举措 ID</para>
                                /// <para>必填：是</para>
                                /// <para>示例值：7343513161666707459</para>
                                /// </summary>
                                [JsonPropertyName("keyresult_id")]
                                public string KeyresultId { get; set; } = string.Empty;

                                /// <summary>
                                /// <para>关键举措的评分</para>
                                /// <para>必填：否</para>
                                /// <para>示例值：1.1</para>
                                /// </summary>
                                [JsonPropertyName("score")]
                                public string? Score { get; set; }

                                /// <summary>
                                /// <para>该关键举措的填写项内容</para>
                                /// <para>必填：否</para>
                                /// <para>示例值：qwerty</para>
                                /// </summary>
                                [JsonPropertyName("text")]
                                public string? Text { get; set; }

                                /// <summary>
                                /// <para>富文本格式的填写内容，解析方式见 [editor](https://open.larkoffice.com/document/client-docs/gadget/component-component/basic-component/form/editor#51af2f4f)</para>
                                /// <para>必填：否</para>
                                /// <para>示例值：{\"ops\":[{\"name\":\"insert\",\"text\":\"qwerty\"}]}</para>
                                /// </summary>
                                [JsonPropertyName("richtext")]
                                public string? Richtext { get; set; }
                            }

                            /// <summary>
                            /// <para>富文本格式的填写内容，解析方式见 [editor](https://open.larkoffice.com/document/client-docs/gadget/component-component/basic-component/form/editor#51af2f4f)</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：{\"ops\":[{\"name\":\"insert\",\"text\":\"qwerty\"}]}</para>
                            /// </summary>
                            [JsonPropertyName("richtext")]
                            public string? Richtext { get; set; }
                        }

                        /// <summary>
                        /// <para>评估的指标，当评估内容是对指标评估时有值</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("metric_data")]
                        public MetricData[]? MetricDatas { get; set; }

                        /// <summary>
                        /// <para>评估的指标，当评估内容是对指标评估时有值</para>
                        /// </summary>
                        public record MetricData
                        {
                            /// <summary>
                            /// <para>指标 ID</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：7343513161666707459</para>
                            /// </summary>
                            [JsonPropertyName("id")]
                            public string Id { get; set; } = string.Empty;

                            /// <summary>
                            /// <para>指标评分</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：1.1</para>
                            /// </summary>
                            [JsonPropertyName("score")]
                            public string? Score { get; set; }
                        }

                        /// <summary>
                        /// <para>终评环节填写内容的来源（仅终评环节的数据有值）</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：review</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>review：产生终评结果的评估型环节</item>
                        /// <item>calibaration：校准环节</item>
                        /// <item>reconsideration：结果复议环节</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("leader_review_data_source")]
                        public string? LeaderReviewDataSource { get; set; }

                        /// <summary>
                        /// <para>工作/总结类型的文本内容</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("multi_texts")]
                        public string[]? MultiTexts { get; set; }

                        /// <summary>
                        /// <para>富文本格式的填写内容，解析方式见 [editor](https://open.larkoffice.com/document/client-docs/gadget/component-component/basic-component/form/editor#51af2f4f)</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：{\"ops\":[{\"name\":\"insert\",\"text\":\"qwerty\"}]}</para>
                        /// </summary>
                        [JsonPropertyName("richtext")]
                        public string? Richtext { get; set; }

                        /// <summary>
                        /// <para>富文本格式的填写内容，解析方式见 [editor](https://open.larkoffice.com/document/client-docs/gadget/component-component/basic-component/form/editor#51af2f4f)</para>
                        /// <para>必填：否</para>
                        /// <para>最大长度：100000</para>
                        /// <para>最小长度：0</para>
                        /// </summary>
                        [JsonPropertyName("multi_richtexts")]
                        public string[]? MultiRichtexts { get; set; }
                    }
                }

                /// <summary>
                /// <para>360 ° 评估记录的信息。如果开启了 360 匿名评估，并且是对全部查看者匿名，则不返回评估人的部分信息</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("invited_review_record_info")]
                public ReviewRecordInvitedReviewRecordInfo? InvitedReviewRecordInfo { get; set; }

                /// <summary>
                /// <para>360 ° 评估记录的信息。如果开启了 360 匿名评估，并且是对全部查看者匿名，则不返回评估人的部分信息</para>
                /// </summary>
                public record ReviewRecordInvitedReviewRecordInfo
                {
                    /// <summary>
                    /// <para>评估人 ID。如果开启了 360 匿名评估，并且是对全部查看者匿名，则不返回该值</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("reviewer_id")]
                    public User? ReviewerId { get; set; }

                    /// <summary>
                    /// <para>评估人 ID。如果开启了 360 匿名评估，并且是对全部查看者匿名，则不返回该值</para>
                    /// </summary>
                    public record User
                    {
                        /// <summary>
                        /// <para>用户的 open_id</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：od-asd2dasdasd</para>
                        /// </summary>
                        [JsonPropertyName("open_id")]
                        public string? OpenId { get; set; }

                        /// <summary>
                        /// <para>用户的 user_id，ID 类型与user_id_type 的取值一致</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：ou-ux987dsf6x</para>
                        /// </summary>
                        [JsonPropertyName("user_id")]
                        public string? UserId { get; set; }
                    }

                    /// <summary>
                    /// <para>是否拒绝</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：false</para>
                    /// </summary>
                    [JsonPropertyName("is_rejected")]
                    public bool? IsRejected { get; set; }

                    /// <summary>
                    /// <para>360° 评估人拒绝评估的理由，当 360° 评估环节被评估人拒绝时有值</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：test</para>
                    /// </summary>
                    [JsonPropertyName("rejected_reason")]
                    public string? RejectedReason { get; set; }

                    /// <summary>
                    /// <para>360° 评估人的评估尺度标签</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>1：严格</item>
                    /// <item>2：适中</item>
                    /// <item>3：宽松</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("distribute_type")]
                    public int? DistributeType { get; set; }

                    /// <summary>
                    /// <para>360° 评估人的评估尺度数值</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1.23</para>
                    /// </summary>
                    [JsonPropertyName("avg_diff")]
                    public string? AvgDiff { get; set; }

                    /// <summary>
                    /// <para>360° 评估人的与被评估人关系。如果开启了 360 匿名评估，并且是对全部查看者匿名，且配置隐藏描述信息则不返回该值</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：direct_report</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>direct_report：直属下级</item>
                    /// <item>skiplevel_report：隔级下级</item>
                    /// <item>former_direct_manager：原直属上级</item>
                    /// <item>skiplevel_manager：隔级上级</item>
                    /// <item>teammate：相同上级同事</item>
                    /// <item>crossteam_colleague：不同上级同事</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("relationship_with_reviewee")]
                    public string? RelationshipWithReviewee { get; set; }

                    /// <summary>
                    /// <para>360° 评估人的邀请人类型。如果开启了 360 匿名评估，并且是对全部查看者匿名，且配置隐藏描述信息则不返回该值</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：system_default</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>system_default：系统默认</item>
                    /// <item>reviewee：被评估人本人</item>
                    /// <item>manager：上级</item>
                    /// <item>hrbp_or_others：HRBP或其他人</item>
                    /// <item>voluntary：自愿评估</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("invitedby")]
                    public string? Invitedby { get; set; }
                }

                /// <summary>
                /// <para>合作项目中上级的评估记录信息，仅在「项目直属上级环节」有值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("direct_project_leader_record_info")]
                public ReviewRecordDirectProjectLeaderRecordInfo? DirectProjectLeaderRecordInfo { get; set; }

                /// <summary>
                /// <para>合作项目中上级的评估记录信息，仅在「项目直属上级环节」有值</para>
                /// </summary>
                public record ReviewRecordDirectProjectLeaderRecordInfo
                {
                    /// <summary>
                    /// <para>评估人 ID</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("reviewer_id")]
                    public User? ReviewerId { get; set; }

                    /// <summary>
                    /// <para>评估人 ID</para>
                    /// </summary>
                    public record User
                    {
                        /// <summary>
                        /// <para>用户的 open_id</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：od-asd2dasdasd</para>
                        /// </summary>
                        [JsonPropertyName("open_id")]
                        public string? OpenId { get; set; }

                        /// <summary>
                        /// <para>用户的 user_id，ID 类型与user_id_type 的取值一致</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：ou-ux987dsf6x</para>
                        /// </summary>
                        [JsonPropertyName("user_id")]
                        public string? UserId { get; set; }
                    }

                    /// <summary>
                    /// <para>评估人作为直属项目上级所在的项目</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("cooperation_projects")]
                    public CooperationProject[]? CooperationProjects { get; set; }

                    /// <summary>
                    /// <para>评估人作为直属项目上级所在的项目</para>
                    /// </summary>
                    public record CooperationProject
                    {
                        /// <summary>
                        /// <para>合作项目 ID</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：7309457114076807188</para>
                        /// </summary>
                        [JsonPropertyName("id")]
                        public string? Id { get; set; }

                        /// <summary>
                        /// <para>合作项目的名称</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("name")]
                        public I18n? Name { get; set; }

                        /// <summary>
                        /// <para>合作项目的名称</para>
                        /// </summary>
                        public record I18n
                        {
                            /// <summary>
                            /// <para>中文</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：体验</para>
                            /// </summary>
                            [JsonPropertyName("zh_cn")]
                            public string? ZhCn { get; set; }

                            /// <summary>
                            /// <para>英文</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：Interactive experience</para>
                            /// </summary>
                            [JsonPropertyName("en_us")]
                            public string? EnUs { get; set; }
                        }

                        /// <summary>
                        /// <para>合作项目角色</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("roles")]
                        public CooperationRole[]? Roles { get; set; }

                        /// <summary>
                        /// <para>合作项目角色</para>
                        /// </summary>
                        public record CooperationRole
                        {
                            /// <summary>
                            /// <para>评估人在合作项目中的角色。在未配置合作项目角色情况下，该字段为空值。</para>
                            /// <para>必填：否</para>
                            /// </summary>
                            [JsonPropertyName("reviewer_role")]
                            public CooperationUserRole? ReviewerRole { get; set; }

                            /// <summary>
                            /// <para>评估人在合作项目中的角色。在未配置合作项目角色情况下，该字段为空值。</para>
                            /// </summary>
                            public record CooperationUserRole
                            {
                                /// <summary>
                                /// <para>合作项目角色 ID</para>
                                /// <para>必填：否</para>
                                /// <para>示例值：7213434603057807379</para>
                                /// </summary>
                                [JsonPropertyName("role_id")]
                                public string? RoleId { get; set; }

                                /// <summary>
                                /// <para>名称</para>
                                /// <para>必填：否</para>
                                /// </summary>
                                [JsonPropertyName("name")]
                                public I18n? Name { get; set; }

                                /// <summary>
                                /// <para>名称</para>
                                /// </summary>
                                public record I18n
                                {
                                    /// <summary>
                                    /// <para>中文</para>
                                    /// <para>必填：否</para>
                                    /// <para>示例值：体验</para>
                                    /// </summary>
                                    [JsonPropertyName("zh_cn")]
                                    public string? ZhCn { get; set; }

                                    /// <summary>
                                    /// <para>英文</para>
                                    /// <para>必填：否</para>
                                    /// <para>示例值：Interactive experience</para>
                                    /// </summary>
                                    [JsonPropertyName("en_us")]
                                    public string? EnUs { get; set; }
                                }
                            }

                            /// <summary>
                            /// <para>被评估人在合作项目中的项目角色。在未配置合作项目角色情况下，该字段为空值。</para>
                            /// <para>必填：否</para>
                            /// </summary>
                            [JsonPropertyName("reviewee_role")]
                            public CooperationUserRole? RevieweeRole { get; set; }
                        }
                    }
                }

                /// <summary>
                /// <para>评估记录 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：7385000219907457024-7385000219907457025</para>
                /// </summary>
                [JsonPropertyName("record_id")]
                public string? RecordId { get; set; }
            }

            /// <summary>
            /// <para>评估型环节的执行人角色</para>
            /// <para>必填：否</para>
            /// <para>示例值：reviewee</para>
            /// <para>可选值：<list type="bullet">
            /// <item>reviewee：被评估人</item>
            /// <item>invited_reviewer：360°评估人</item>
            /// <item>solid_line_leader：实线上级</item>
            /// <item>dotted_line_leader：虚线上级</item>
            /// <item>secondary_solid_line_leader：第二实线上级</item>
            /// <item>direct_project_leader：项目直属上级</item>
            /// <item>custom_review_role：自定义评估角色</item>
            /// <item>metric_reviewer：指标评价人角色</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("review_stage_role")]
            public string? ReviewStageRole { get; set; }
        }
    }
}
