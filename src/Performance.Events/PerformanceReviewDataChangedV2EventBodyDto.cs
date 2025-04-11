// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="PerformanceReviewDataChangedV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>绩效详情变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Performance.Events;
/// <summary>
/// 绩效详情变更 事件体
/// <para>当员工的绩效详情发生变更时，订阅这个事件的应用会收到该事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=performance&amp;version=v2&amp;resource=review_data&amp;event=changed)</para>
/// <para>接口ID：7351374599659864068</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/review_data/events/changed</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2freview_data%2fevents%2fchanged</para>
/// </summary>
public record PerformanceReviewDataChangedV2EventBodyDto() : EventBodyDto("performance.review_data.changed_v2")
{
    /// <summary>
    /// <para>评估数据列表</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`0` ～ `9999999`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public ReviewDataChange[]? Items { get; set; }

    /// <summary></summary>
    public record ReviewDataChange
    {
        /// <summary>
        /// <para>员工 ID， ID 类型请参考：[用户资源介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/field-overview)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public UserIdSuffix? UserId { get; set; }

        /// <summary>
        /// <para>周期 ID，详情请查看：[获取周期](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v1/semester/list)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("semester_id")]
        public string? SemesterId { get; set; }

        /// <summary>
        /// <para>项目 ID，详情请查看：[获取项目配置](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/activity/query)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string? ActivityId { get; set; }

        /// <summary>
        /// <para>发生更新的环节</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("stage_changes")]
        public StageChange[]? StageChanges { get; set; }

        /// <summary></summary>
        public record StageChange
        {
            /// <summary>
            /// <para>发生更新的环节 ID</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("stage_id")]
            public string? StageId { get; set; }

            /// <summary>
            /// <para>环节类型</para>
            /// <para>**可选值有**：</para>
            /// <para>summarize_key_outputs:工作总结环节,review:评估型环节,communication_and_open_result:结果沟通环节,view_result:绩效结果查看环节,reconsideration:结果复议环节,leader_review:终评环节（特指最终的绩效结果数据）</para>
            /// <para>必填：否</para>
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
            /// <para>评估型环节的执行人角色</para>
            /// <para>**可选值有**：</para>
            /// <para>reviewee:被评估人,invited_reviewer:360°评估人,solid_line_leader:实线上级,dotted_line_leader:虚线上级,secondary_solid_line_leader:第二实线上级,direct_project_leader:项目直属上级,custom_review_role:自定义评估角色</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>reviewee：被评估人</item>
            /// <item>invited_reviewer：360°评估人</item>
            /// <item>solid_line_leader：实线上级</item>
            /// <item>dotted_line_leader：虚线上级</item>
            /// <item>secondary_solid_line_leader：第二实线上级</item>
            /// <item>direct_project_leader：项目直属上级</item>
            /// <item>custom_review_role：自定义评估角色</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("review_stage_role")]
            public string? ReviewStageRole { get; set; }
        }
    }
}
