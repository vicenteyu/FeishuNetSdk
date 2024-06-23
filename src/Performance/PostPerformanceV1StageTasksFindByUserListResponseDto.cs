// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostPerformanceV1StageTasksFindByUserListResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取周期任务（指定用户） 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Performance;
/// <summary>
/// 获取周期任务（指定用户） 响应体
/// <para>获取指定周期的指定用户的任务信息</para>
/// <para>接口ID：7275704938197221378</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v1/stage_task/find_by_user_list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v1%2fstage_task%2ffind_by_user_list</para>
/// </summary>
public record PostPerformanceV1StageTasksFindByUserListResponseDto
{
    /// <summary>
    /// <para>周期基本信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("base")]
    public SemesterBaseInfo? Base { get; set; }

    /// <summary>
    /// <para>周期基本信息</para>
    /// </summary>
    public record SemesterBaseInfo
    {
        /// <summary>
        /// <para>周期 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7263150499637264385</para>
        /// </summary>
        [JsonPropertyName("semester_id")]
        public string? SemesterId { get; set; }

        /// <summary>
        /// <para>周期名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("semester_name")]
        public I18n? SemesterName { get; set; }

        /// <summary>
        /// <para>周期名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>中文</para>
            /// <para>必填：否</para>
            /// <para>示例值：示例周期</para>
            /// </summary>
            [JsonPropertyName("zh-CN")]
            public string? ZhCN { get; set; }

            /// <summary>
            /// <para>英文</para>
            /// <para>必填：否</para>
            /// <para>示例值：DemoSemester</para>
            /// </summary>
            [JsonPropertyName("en-US")]
            public string? EnUS { get; set; }
        }

        /// <summary>
        /// <para>开始时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1625068800000</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// <para>结束时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1625068800000</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public string? EndTime { get; set; }
    }

    /// <summary>
    /// <para>周期任务</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public StageTask[]? Items { get; set; }

    /// <summary>
    /// <para>周期任务</para>
    /// </summary>
    public record StageTask
    {
        /// <summary>
        /// <para>用户 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6765375796711327240</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>各分类的任务数</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("stage_num_lists")]
        public StageTaskStatusNum[]? StageNumLists { get; set; }

        /// <summary>
        /// <para>各分类的任务数</para>
        /// </summary>
        public record StageTaskStatusNum
        {
            /// <summary>
            /// <para>任务分类</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：待完成</item>
            /// <item>2：已完成</item>
            /// <item>3：已逾期（此分类仅在租户系统设置为不允许逾期提交时存在）</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("task_option_id")]
            public int? TaskOptionId { get; set; }

            /// <summary>
            /// <para>环节任务数量</para>
            /// <para>必填：否</para>
            /// <para>示例值：4</para>
            /// </summary>
            [JsonPropertyName("stage_num")]
            public int? StageNum { get; set; }
        }

        /// <summary>
        /// <para>环节任务信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("stage_task_info_lists")]
        public StageTaskInfo[]? StageTaskInfoLists { get; set; }

        /// <summary>
        /// <para>环节任务信息</para>
        /// </summary>
        public record StageTaskInfo
        {
            /// <summary>
            /// <para>环节 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：7263150499637379073</para>
            /// </summary>
            [JsonPropertyName("stage_id")]
            public string? StageId { get; set; }

            /// <summary>
            /// <para>环节名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>环节名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>中文</para>
                /// <para>必填：否</para>
                /// <para>示例值：360°确认</para>
                /// </summary>
                [JsonPropertyName("zh-CN")]
                public string? ZhCN { get; set; }

                /// <summary>
                /// <para>英文</para>
                /// <para>必填：否</para>
                /// <para>示例值：confirm_invitation</para>
                /// </summary>
                [JsonPropertyName("en-US")]
                public string? EnUS { get; set; }
            }

            /// <summary>
            /// <para>环节截止时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：1625068800000</para>
            /// </summary>
            [JsonPropertyName("deadline")]
            public string? Deadline { get; set; }

            /// <summary>
            /// <para>未完成的任务数量</para>
            /// <para>必填：否</para>
            /// <para>示例值：99</para>
            /// </summary>
            [JsonPropertyName("need_todo_count")]
            public int? NeedTodoCount { get; set; }

            /// <summary>
            /// <para>处理任务的系统页面链接</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://performance.feishu-pre.cn/perf/review/7235911950407352321/7235906557916086300</para>
            /// </summary>
            [JsonPropertyName("jump_url")]
            public string? JumpUrl { get; set; }

            /// <summary>
            /// <para>环节任务状态</para>
            /// <para>必填：否</para>
            /// <para>示例值：all_done</para>
            /// <para>可选值：<list type="bullet">
            /// <item>need_todo：还有待完成的任务</item>
            /// <item>overdue：剩余未完成的任务均已逾期</item>
            /// <item>all_done：全部任务均已完成</item>
            /// <item>stage_pause：环节被暂停</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("stage_task_status")]
            public string? StageTaskStatus { get; set; }

            /// <summary>
            /// <para>任务分类</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：待完成</item>
            /// <item>2：已完成</item>
            /// <item>3：已逾期（此分类仅在租户系统设置为不允许逾期提交时存在）</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("task_option_id")]
            public int? TaskOptionId { get; set; }
        }
    }
}
