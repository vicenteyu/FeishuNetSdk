// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetOkrV1OkrsBatchGetResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量获取 OKR 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Okr;
/// <summary>
/// 批量获取 OKR 响应体
/// <para>根据 OKR id 批量获取 OKR。</para>
/// <para>接口ID：6961663213280722945</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/okr-v1/okr/batch_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fokr-v1%2fokr%2fbatch_get</para>
/// </summary>
public record GetOkrV1OkrsBatchGetResponseDto
{
    /// <summary>
    /// <para>OKR 列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("okr_list")]
    public OkrBatch[]? OkrLists { get; set; }

    /// <summary>
    /// <para>OKR 列表</para>
    /// </summary>
    public record OkrBatch
    {
        /// <summary>
        /// <para>id</para>
        /// <para>必填：否</para>
        /// <para>示例值：11123123123123</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>OKR的访问权限</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：此时OKR只返回id</item>
        /// <item>1：返回OKR的其他具体字段</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("permission")]
        public int? Permission { get; set; }

        /// <summary>
        /// <para>period_id</para>
        /// <para>必填：否</para>
        /// <para>示例值：11123123123123</para>
        /// </summary>
        [JsonPropertyName("period_id")]
        public string? PeriodId { get; set; }

        /// <summary>
        /// <para>名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：My OKR</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>Objective列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("objective_list")]
        public OkrObjective[]? ObjectiveLists { get; set; }

        /// <summary>
        /// <para>Objective列表</para>
        /// </summary>
        public record OkrObjective
        {
            /// <summary>
            /// <para>Objective ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：1231231231231</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>权限</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// <para>可选值：<list type="bullet">
            /// <item>0：此时OKR只返回id</item>
            /// <item>1：返回OKR的其他具体字段</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("permission")]
            public int? Permission { get; set; }

            /// <summary>
            /// <para>Objective 内容</para>
            /// <para>必填：否</para>
            /// <para>示例值：Objective 内容</para>
            /// </summary>
            [JsonPropertyName("content")]
            public string? Content { get; set; }

            /// <summary>
            /// <para>Objective 备注内容</para>
            /// <para>必填：否</para>
            /// <para>示例值：Objective 进度记录内容</para>
            /// </summary>
            [JsonPropertyName("progress_report")]
            public string? ProgressReport { get; set; }

            /// <summary>
            /// <para>Objective 分数（0 - 100）</para>
            /// <para>必填：否</para>
            /// <para>示例值：100</para>
            /// </summary>
            [JsonPropertyName("score")]
            public int? Score { get; set; }

            /// <summary>
            /// <para>Objective的权重（0 - 100）</para>
            /// <para>必填：否</para>
            /// <para>示例值：33.33</para>
            /// </summary>
            [JsonPropertyName("weight")]
            public float? Weight { get; set; }

            /// <summary>
            /// <para>Objective进度</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("progress_rate")]
            public OkrObjectiveProgressRate? ProgressRate { get; set; }

            /// <summary>
            /// <para>Objective进度</para>
            /// </summary>
            public record OkrObjectiveProgressRate
            {
                /// <summary>
                /// <para>Objective 进度百分比 &gt;= 0</para>
                /// <para>必填：否</para>
                /// <para>示例值：50</para>
                /// </summary>
                [JsonPropertyName("percent")]
                public int? Percent { get; set; }

                /// <summary>
                /// <para>Objective 进度状态:</para>
                /// <para>- "-1" 暂无</para>
                /// <para>- "0" 正常</para>
                /// <para>- "1" 风险</para>
                /// <para>- "2" 延期</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("status")]
                public string? Status { get; set; }
            }

            /// <summary>
            /// <para>Objective KeyResult 列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("kr_list")]
            public OkrObjectiveKr[]? KrLists { get; set; }

            /// <summary>
            /// <para>Objective KeyResult 列表</para>
            /// </summary>
            public record OkrObjectiveKr
            {
                /// <summary>
                /// <para>Key Result ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：1231231223</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>KeyResult 内容</para>
                /// <para>必填：否</para>
                /// <para>示例值：KeyResult 内容</para>
                /// </summary>
                [JsonPropertyName("content")]
                public string? Content { get; set; }

                /// <summary>
                /// <para>KeyResult打分（0 - 100）</para>
                /// <para>必填：否</para>
                /// <para>示例值：100</para>
                /// </summary>
                [JsonPropertyName("score")]
                public int? Score { get; set; }

                /// <summary>
                /// <para>KeyResult权重（0 - 100）（废弃）</para>
                /// <para>必填：否</para>
                /// <para>示例值：100</para>
                /// </summary>
                [JsonPropertyName("weight")]
                public int? Weight { get; set; }

                /// <summary>
                /// <para>KeyResult的权重（0 - 100）</para>
                /// <para>必填：否</para>
                /// <para>示例值：33.33</para>
                /// </summary>
                [JsonPropertyName("kr_weight")]
                public float? KrWeight { get; set; }

                /// <summary>
                /// <para>KR进度</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("progress_rate")]
                public OkrObjectiveProgressRate? ProgressRate { get; set; }

                /// <summary>
                /// <para>KR进度</para>
                /// </summary>
                public record OkrObjectiveProgressRate
                {
                    /// <summary>
                    /// <para>Objective 进度百分比 &gt;= 0</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：50</para>
                    /// </summary>
                    [JsonPropertyName("percent")]
                    public int? Percent { get; set; }

                    /// <summary>
                    /// <para>Objective 进度状态:</para>
                    /// <para>- "-1" 暂无</para>
                    /// <para>- "0" 正常</para>
                    /// <para>- "1" 风险</para>
                    /// <para>- "2" 延期</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// </summary>
                    [JsonPropertyName("status")]
                    public string? Status { get; set; }
                }

                /// <summary>
                /// <para>该KR的进度列表</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("progress_record_list")]
                public ProgressRecordSimplify[]? ProgressRecordLists { get; set; }

                /// <summary>
                /// <para>该KR的进度列表</para>
                /// </summary>
                public record ProgressRecordSimplify
                {
                    /// <summary>
                    /// <para>OKR 进展记录ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：7041469619902693396</para>
                    /// </summary>
                    [JsonPropertyName("id")]
                    public string? Id { get; set; }
                }

                /// <summary>
                /// <para>最后一次进度百分比更新时间 毫秒</para>
                /// <para>必填：否</para>
                /// <para>示例值：1618500278663</para>
                /// </summary>
                [JsonPropertyName("progress_rate_percent_last_updated_time")]
                public string? ProgressRatePercentLastUpdatedTime { get; set; }

                /// <summary>
                /// <para>最后一次状态更新时间 毫秒</para>
                /// <para>必填：否</para>
                /// <para>示例值：1618500278663</para>
                /// </summary>
                [JsonPropertyName("progress_rate_status_last_updated_time")]
                public string? ProgressRateStatusLastUpdatedTime { get; set; }

                /// <summary>
                /// <para>最后一次在侧边栏新增或者编辑进展的时间 毫秒</para>
                /// <para>必填：否</para>
                /// <para>示例值：1618500278663</para>
                /// </summary>
                [JsonPropertyName("progress_record_last_updated_time")]
                public string? ProgressRecordLastUpdatedTime { get; set; }

                /// <summary>
                /// <para>最后一次编辑备注的时间 毫秒</para>
                /// <para>必填：否</para>
                /// <para>示例值：1618500278663</para>
                /// </summary>
                [JsonPropertyName("progress_report_last_updated_time")]
                public string? ProgressReportLastUpdatedTime { get; set; }

                /// <summary>
                /// <para>最后一次打分更新时间 毫秒</para>
                /// <para>必填：否</para>
                /// <para>示例值：1618500278663</para>
                /// </summary>
                [JsonPropertyName("score_last_updated_time")]
                public string? ScoreLastUpdatedTime { get; set; }

                /// <summary>
                /// <para>截止时间 毫秒</para>
                /// <para>必填：否</para>
                /// <para>示例值：1618500278663</para>
                /// </summary>
                [JsonPropertyName("deadline")]
                public string? Deadline { get; set; }

                /// <summary>
                /// <para>该Objective提到的人员列表</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("mentioned_user_list")]
                public OkrObjectiveAlignedObjectiveOwner[]? MentionedUserLists { get; set; }

                /// <summary>
                /// <para>该Objective提到的人员列表</para>
                /// </summary>
                public record OkrObjectiveAlignedObjectiveOwner
                {
                    /// <summary>
                    /// <para>用户的 open_id</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：od-asd2dasdasd</para>
                    /// </summary>
                    [JsonPropertyName("open_id")]
                    public string? OpenId { get; set; }

                    /// <summary>
                    /// <para>用户的 user_id</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：ou-ux987dsf6x</para>
                    /// </summary>
                    [JsonPropertyName("user_id")]
                    public string? UserId { get; set; }
                }
            }

            /// <summary>
            /// <para>对齐到该Objective的Objective列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("aligned_objective_list")]
            public OkrObjectiveAlignedObjective[]? AlignedObjectiveLists { get; set; }

            /// <summary>
            /// <para>对齐到该Objective的Objective列表</para>
            /// </summary>
            public record OkrObjectiveAlignedObjective
            {
                /// <summary>
                /// <para>Objective的ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：1231231231213</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>OKR的ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：12323231231213</para>
                /// </summary>
                [JsonPropertyName("okr_id")]
                public string? OkrId { get; set; }

                /// <summary>
                /// <para>该Objective的Owner</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("owner")]
                public OkrObjectiveAlignedObjectiveOwner? Owner { get; set; }

                /// <summary>
                /// <para>该Objective的Owner</para>
                /// </summary>
                public record OkrObjectiveAlignedObjectiveOwner
                {
                    /// <summary>
                    /// <para>用户的 open_id</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：od-asd2dasdasd</para>
                    /// </summary>
                    [JsonPropertyName("open_id")]
                    public string? OpenId { get; set; }

                    /// <summary>
                    /// <para>用户的 user_id</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：ou-ux987dsf6x</para>
                    /// </summary>
                    [JsonPropertyName("user_id")]
                    public string? UserId { get; set; }
                }
            }

            /// <summary>
            /// <para>该Objective对齐到的Objective列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("aligning_objective_list")]
            public OkrObjectiveAlignedObjective[]? AligningObjectiveLists { get; set; }

            /// <summary>
            /// <para>该Objective的进度列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("progress_record_list")]
            public ProgressRecordSimplify[]? ProgressRecordLists { get; set; }

            /// <summary>
            /// <para>该Objective的进度列表</para>
            /// </summary>
            public record ProgressRecordSimplify
            {
                /// <summary>
                /// <para>OKR 进展记录ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：7041469619902693396</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }
            }

            /// <summary>
            /// <para>最后一次进度百分比更新时间 毫秒</para>
            /// <para>必填：否</para>
            /// <para>示例值：1618500278663</para>
            /// </summary>
            [JsonPropertyName("progress_rate_percent_last_updated_time")]
            public string? ProgressRatePercentLastUpdatedTime { get; set; }

            /// <summary>
            /// <para>最后一次状态更新时间 毫秒</para>
            /// <para>必填：否</para>
            /// <para>示例值：1618500278663</para>
            /// </summary>
            [JsonPropertyName("progress_rate_status_last_updated_time")]
            public string? ProgressRateStatusLastUpdatedTime { get; set; }

            /// <summary>
            /// <para>最后一次在侧边栏新增或者编辑进展的时间 毫秒</para>
            /// <para>必填：否</para>
            /// <para>示例值：1618500278663</para>
            /// </summary>
            [JsonPropertyName("progress_record_last_updated_time")]
            public string? ProgressRecordLastUpdatedTime { get; set; }

            /// <summary>
            /// <para>最后一次编辑备注的时间 毫秒</para>
            /// <para>必填：否</para>
            /// <para>示例值：1618500278663</para>
            /// </summary>
            [JsonPropertyName("progress_report_last_updated_time")]
            public string? ProgressReportLastUpdatedTime { get; set; }

            /// <summary>
            /// <para>最后一次打分更新时间 毫秒</para>
            /// <para>必填：否</para>
            /// <para>示例值：1618500278663</para>
            /// </summary>
            [JsonPropertyName("score_last_updated_time")]
            public string? ScoreLastUpdatedTime { get; set; }

            /// <summary>
            /// <para>截止时间 毫秒</para>
            /// <para>必填：否</para>
            /// <para>示例值：1618500278663</para>
            /// </summary>
            [JsonPropertyName("deadline")]
            public string? Deadline { get; set; }

            /// <summary>
            /// <para>该Objective提到的人员列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("mentioned_user_list")]
            public OkrObjectiveAlignedObjectiveOwner[]? MentionedUserLists { get; set; }

            /// <summary>
            /// <para>该Objective提到的人员列表</para>
            /// </summary>
            public record OkrObjectiveAlignedObjectiveOwner
            {
                /// <summary>
                /// <para>用户的 open_id</para>
                /// <para>必填：否</para>
                /// <para>示例值：od-asd2dasdasd</para>
                /// </summary>
                [JsonPropertyName("open_id")]
                public string? OpenId { get; set; }

                /// <summary>
                /// <para>用户的 user_id</para>
                /// <para>必填：否</para>
                /// <para>示例值：ou-ux987dsf6x</para>
                /// </summary>
                [JsonPropertyName("user_id")]
                public string? UserId { get; set; }
            }
        }

        /// <summary>
        /// <para>OKR确认状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：初始状态</item>
        /// <item>1：待提交/未提交</item>
        /// <item>2：待处理/待确认</item>
        /// <item>3：已拒绝/已建议</item>
        /// <item>4：已通过/已确认</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("confirm_status")]
        public int? ConfirmStatus { get; set; }
    }
}
