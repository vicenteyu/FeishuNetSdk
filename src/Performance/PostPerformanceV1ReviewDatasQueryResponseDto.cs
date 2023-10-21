using Newtonsoft.Json;
namespace FeishuNetSdk.Performance;
/// <summary>
/// 获取绩效结果 响应体
/// <para>获取绩效结果</para>
/// <para>接口ID：7000193886257725441</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/performance-v1/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v1%2freview_data%2fquery</para>
/// </summary>
public record PostPerformanceV1ReviewDatasQueryResponseDto
{
    /// <summary>
    /// <para>绩效评估周期列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("semesters")]
    public Semester[]? Semesters { get; set; }

    /// <summary>
    /// <para>绩效评估周期列表</para>
    /// </summary>
    public record Semester
    {
        /// <summary>
        /// <para>绩效评估周期 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6992035450862224940</para>
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>绩效评估周期名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("name")]
        public I18n? Name { get; set; }

        /// <summary>
        /// <para>绩效评估周期名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>中文</para>
            /// <para>必填：否</para>
            /// <para>示例值：体验</para>
            /// </summary>
            [JsonProperty("zh-CN")]
            public string? ZhCN { get; set; }

            /// <summary>
            /// <para>英文</para>
            /// <para>必填：否</para>
            /// <para>示例值：Interactiveexperience</para>
            /// </summary>
            [JsonProperty("en-US")]
            public string? EnUS { get; set; }
        }

        /// <summary>
        /// <para>绩效评估周期开始时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1625068800000</para>
        /// </summary>
        [JsonProperty("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// <para>绩效评估周期结束时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1640966399999</para>
        /// </summary>
        [JsonProperty("end_time")]
        public string? EndTime { get; set; }
    }

    /// <summary>
    /// <para>绩效评估项目列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("activities")]
    public Activity[]? Activities { get; set; }

    /// <summary>
    /// <para>绩效评估项目列表</para>
    /// </summary>
    public record Activity
    {
        /// <summary>
        /// <para>绩效评估项目 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6992035450862323244</para>
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>绩效评估项目名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("name")]
        public I18n? Name { get; set; }

        /// <summary>
        /// <para>绩效评估项目名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>中文</para>
            /// <para>必填：否</para>
            /// <para>示例值：体验</para>
            /// </summary>
            [JsonProperty("zh-CN")]
            public string? ZhCN { get; set; }

            /// <summary>
            /// <para>英文</para>
            /// <para>必填：否</para>
            /// <para>示例值：Interactiveexperience</para>
            /// </summary>
            [JsonProperty("en-US")]
            public string? EnUS { get; set; }
        }

        /// <summary>
        /// <para>绩效评估周期 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6992035450862224940</para>
        /// </summary>
        [JsonProperty("semester_id")]
        public string? SemesterId { get; set; }
    }

    /// <summary>
    /// <para>评估项列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("indicators")]
    public Indicator[]? Indicators { get; set; }

    /// <summary>
    /// <para>评估项列表</para>
    /// </summary>
    public record Indicator
    {
        /// <summary>
        /// <para>评估项 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6982759010081818159</para>
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>评估项名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("name")]
        public I18n? Name { get; set; }

        /// <summary>
        /// <para>评估项名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>中文</para>
            /// <para>必填：否</para>
            /// <para>示例值：体验</para>
            /// </summary>
            [JsonProperty("zh-CN")]
            public string? ZhCN { get; set; }

            /// <summary>
            /// <para>英文</para>
            /// <para>必填：否</para>
            /// <para>示例值：Interactiveexperience</para>
            /// </summary>
            [JsonProperty("en-US")]
            public string? EnUS { get; set; }
        }

        /// <summary>
        /// <para>评估项等级列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("options")]
        public IndicatorOption[]? Options { get; set; }

        /// <summary>
        /// <para>评估项等级列表</para>
        /// </summary>
        public record IndicatorOption
        {
            /// <summary>
            /// <para>等级 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6966127279593588268</para>
            /// </summary>
            [JsonProperty("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>等级名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>等级名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>中文</para>
                /// <para>必填：否</para>
                /// <para>示例值：体验</para>
                /// </summary>
                [JsonProperty("zh-CN")]
                public string? ZhCN { get; set; }

                /// <summary>
                /// <para>英文</para>
                /// <para>必填：否</para>
                /// <para>示例值：Interactiveexperience</para>
                /// </summary>
                [JsonProperty("en-US")]
                public string? EnUS { get; set; }
            }

            /// <summary>
            /// <para>等级代号</para>
            /// <para>必填：否</para>
            /// <para>示例值：B</para>
            /// </summary>
            [JsonProperty("label")]
            public string? Label { get; set; }
        }
    }

    /// <summary>
    /// <para>评估模板列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("templates")]
    public Template[]? Templates { get; set; }

    /// <summary>
    /// <para>评估模板列表</para>
    /// </summary>
    public record Template
    {
        /// <summary>
        /// <para>评估模板 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6982759007063000610</para>
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>评估模板所在环节名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("name")]
        public I18n? Name { get; set; }

        /// <summary>
        /// <para>评估模板所在环节名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>中文</para>
            /// <para>必填：否</para>
            /// <para>示例值：体验</para>
            /// </summary>
            [JsonProperty("zh-CN")]
            public string? ZhCN { get; set; }

            /// <summary>
            /// <para>英文</para>
            /// <para>必填：否</para>
            /// <para>示例值：Interactiveexperience</para>
            /// </summary>
            [JsonProperty("en-US")]
            public string? EnUS { get; set; }
        }

        /// <summary>
        /// <para>评估模板环节类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：communication_and_open_result</para>
        /// </summary>
        [JsonProperty("stage")]
        public string? Stage { get; set; }
    }

    /// <summary>
    /// <para>评估内容列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("units")]
    public Unit[]? Units { get; set; }

    /// <summary>
    /// <para>评估内容列表</para>
    /// </summary>
    public record Unit
    {
        /// <summary>
        /// <para>评估内容 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6982759008043877922</para>
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>评估内容名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("name")]
        public I18n? Name { get; set; }

        /// <summary>
        /// <para>评估内容名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>中文</para>
            /// <para>必填：否</para>
            /// <para>示例值：体验</para>
            /// </summary>
            [JsonProperty("zh-CN")]
            public string? ZhCN { get; set; }

            /// <summary>
            /// <para>英文</para>
            /// <para>必填：否</para>
            /// <para>示例值：Interactiveexperience</para>
            /// </summary>
            [JsonProperty("en-US")]
            public string? EnUS { get; set; }
        }
    }

    /// <summary>
    /// <para>填写项列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("fields")]
    public Field[]? Fields { get; set; }

    /// <summary>
    /// <para>填写项列表</para>
    /// </summary>
    public record Field
    {
        /// <summary>
        /// <para>填写项 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6982759010081818159</para>
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>填写项名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("name")]
        public I18n? Name { get; set; }

        /// <summary>
        /// <para>填写项名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>中文</para>
            /// <para>必填：否</para>
            /// <para>示例值：体验</para>
            /// </summary>
            [JsonProperty("zh-CN")]
            public string? ZhCN { get; set; }

            /// <summary>
            /// <para>英文</para>
            /// <para>必填：否</para>
            /// <para>示例值：Interactiveexperience</para>
            /// </summary>
            [JsonProperty("en-US")]
            public string? EnUS { get; set; }
        }

        /// <summary>
        /// <para>评估项 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6982759010081818159</para>
        /// </summary>
        [JsonProperty("indicator_id")]
        public string? IndicatorId { get; set; }

        /// <summary>
        /// <para>父级填写项 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6982759010081818159</para>
        /// </summary>
        [JsonProperty("parent_field_id")]
        public string? ParentFieldId { get; set; }
    }

    /// <summary>
    /// <para>评估数据列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("datas")]
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
        [JsonProperty("user_id")]
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
            [JsonProperty("open_id")]
            public string? OpenId { get; set; }

            /// <summary>
            /// <para>用户的 user_id，当 user_id_type 为 people_admin_id 时值为 saas_id，否则为飞书的 user_id</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou-ux987dsf6x</para>
            /// </summary>
            [JsonProperty("user_id")]
            public string? UserId { get; set; }
        }

        /// <summary>
        /// <para>绩效评估周期 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6992035450862224940</para>
        /// </summary>
        [JsonProperty("semester_id")]
        public string? SemesterId { get; set; }

        /// <summary>
        /// <para>绩效评估项目 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6992035450862323244</para>
        /// </summary>
        [JsonProperty("activity_id")]
        public string? ActivityId { get; set; }

        /// <summary>
        /// <para>本周期内各环节内容</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("stages")]
        public ReviewStage[]? Stages { get; set; }

        /// <summary>
        /// <para>本周期内各环节内容</para>
        /// </summary>
        public record ReviewStage
        {
            /// <summary>
            /// <para>环节类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：leader_review</para>
            /// </summary>
            [JsonProperty("stage_type")]
            public string? StageType { get; set; }

            /// <summary>
            /// <para>环节状态</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>0：未开始，任务的开始时间未到达</item>
            /// <item>1：待完成，任务的开始时间到达而截止时间未到达，且任务未完成</item>
            /// <item>2：已截止，任务的截止时间已到达，且任务未完成</item>
            /// <item>3：已完成，任务已完成</item>
            /// <item>4：已复议，绩效结果已开通，且被评估人已发起复议</item>
            /// </list></para>
            /// </summary>
            [JsonProperty("progress")]
            public int? Progress { get; set; }

            /// <summary>
            /// <para>环节填写内容</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("data")]
            public ReviewDetail[]? Datas { get; set; }

            /// <summary>
            /// <para>环节填写内容</para>
            /// </summary>
            public record ReviewDetail
            {
                /// <summary>
                /// <para>评估模板 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：6982759008972326447</para>
                /// </summary>
                [JsonProperty("template_id")]
                public string? TemplateId { get; set; }

                /// <summary>
                /// <para>评估内容 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：6982759008973882926</para>
                /// </summary>
                [JsonProperty("unit_id")]
                public string? UnitId { get; set; }

                /// <summary>
                /// <para>评估控件 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：6982759009698137641</para>
                /// </summary>
                [JsonProperty("field_id")]
                public string? FieldId { get; set; }

                /// <summary>
                /// <para>评估人 ID</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("reviewer_user_id")]
                public User? ReviewerUserId { get; set; }

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
                    [JsonProperty("open_id")]
                    public string? OpenId { get; set; }

                    /// <summary>
                    /// <para>用户的 user_id，当 user_id_type 为 people_admin_id 时值为 saas_id，否则为飞书的 user_id</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：ou-ux987dsf6x</para>
                    /// </summary>
                    [JsonProperty("user_id")]
                    public string? UserId { get; set; }
                }

                /// <summary>
                /// <para>最后提交时间</para>
                /// <para>必填：否</para>
                /// <para>示例值：1627977114000</para>
                /// </summary>
                [JsonProperty("submit_time")]
                public string? SubmitTime { get; set; }

                /// <summary>
                /// <para>评估项 ID，option_id 或 score 有值的时候有值</para>
                /// <para>必填：否</para>
                /// <para>示例值：6982759009698137641</para>
                /// </summary>
                [JsonProperty("indicator_id")]
                public string? IndicatorId { get; set; }

                /// <summary>
                /// <para>评估项结果等级 ID，有值表示当前数据是评级型评估项数据</para>
                /// <para>必填：否</para>
                /// <para>示例值：6966127279593686572</para>
                /// </summary>
                [JsonProperty("option_id")]
                public string? OptionId { get; set; }

                /// <summary>
                /// <para>评分型评估项填写内容，有值表示当前数据是评分型评估项数据</para>
                /// <para>必填：否</para>
                /// <para>示例值：0.4</para>
                /// </summary>
                [JsonProperty("score")]
                public string? Score { get; set; }

                /// <summary>
                /// <para>填写项填写内容，有值表示当前数据是填写项数据</para>
                /// <para>必填：否</para>
                /// <para>示例值：与公司共同发展</para>
                /// </summary>
                [JsonProperty("text")]
                public string? Text { get; set; }
            }
        }
    }
}
