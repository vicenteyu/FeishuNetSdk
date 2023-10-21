using Newtonsoft.Json;
namespace FeishuNetSdk.Okr.Spec;
/// <summary>
/// 获取用户的 OKR 列表 响应体
/// <para>根据用户的 id 获取 OKR 列表。{尝试一下}(url=/api/tools/api_explore/api_explore_config?project=okr&version=v1&resource=user.okr&method=list)</para>
/// <para>接口ID：6961663213280739329</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/okr-v1/okr/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fokr-v1%2fuser-okr%2flist</para>
/// </summary>
public record GetOkrV1UsersByUserIdOkrsResponseDto
{
    /// <summary>
    /// <para>OKR周期总数</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("total")]
    public int? Total { get; set; }

    /// <summary>
    /// <para>OKR 列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("okr_list")]
    public OkrBatch[]? OkrList { get; set; }

    public record OkrBatch
    {
        /// <summary>
        /// <para>id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>OKR的访问权限</para>
        /// <para>**可选值有**：</para>
        /// <para>0:此时OKR只返回id,1:返回OKR的其他具体字段</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：此时OKR只返回id</item>
        /// <item>1：返回OKR的其他具体字段</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("permission")]
        public int? Permission { get; set; }

        /// <summary>
        /// <para>period_id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("period_id")]
        public string? PeriodId { get; set; }

        /// <summary>
        /// <para>名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>Objective列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("objective_list")]
        public OkrObjective[]? ObjectiveList { get; set; }

        public record OkrObjective
        {
            /// <summary>
            /// <para>Objective ID</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>权限</para>
            /// <para>**可选值有**：</para>
            /// <para>0:此时OKR只返回id,1:返回OKR的其他具体字段</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>0：此时OKR只返回id</item>
            /// <item>1：返回OKR的其他具体字段</item>
            /// </list></para>
            /// </summary>
            [JsonProperty("permission")]
            public int? Permission { get; set; }

            /// <summary>
            /// <para>Objective 内容</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("content")]
            public string? Content { get; set; }

            /// <summary>
            /// <para>Objective 备注内容</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("progress_report")]
            public string? ProgressReport { get; set; }

            /// <summary>
            /// <para>Objective 分数（0 - 100）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("score")]
            public int? Score { get; set; }

            /// <summary>
            /// <para>Objective的权重（0 - 100）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("weight")]
            public float? Weight { get; set; }

            /// <summary>
            /// <para>Objective进度</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("progress_rate")]
            public OkrObjectiveProgressRate? ProgressRate { get; set; }

            public record OkrObjectiveProgressRate
            {
                /// <summary>
                /// <para>Objective 进度百分比 &gt;= 0</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("percent")]
                public int? Percent { get; set; }

                /// <summary>
                /// <para>Objective 进度状态:</para>
                /// <para>- "-1" 暂无</para>
                /// <para>- "0" 正常</para>
                /// <para>- "1" 风险</para>
                /// <para>- "2" 延期</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("status")]
                public string? Status { get; set; }
            }

            /// <summary>
            /// <para>Objective KeyResult 列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("kr_list")]
            public OkrObjectiveKr[]? KrList { get; set; }

            public record OkrObjectiveKr
            {
                /// <summary>
                /// <para>Key Result ID</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>KeyResult 内容</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("content")]
                public string? Content { get; set; }

                /// <summary>
                /// <para>KeyResult打分（0 - 100）</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("score")]
                public int? Score { get; set; }

                /// <summary>
                /// <para>KeyResult权重（0 - 100）（废弃）</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("weight")]
                public int? Weight { get; set; }

                /// <summary>
                /// <para>KeyResult的权重（0 - 100）</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("kr_weight")]
                public float? KrWeight { get; set; }

                /// <summary>
                /// <para>KR进度</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("progress_rate")]
                public OkrObjectiveProgressRate? ProgressRate { get; set; }

                /// <summary>
                /// <para>该KR的进度列表</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("progress_record_list")]
                public ProgressRecordSimplify[]? ProgressRecordList { get; set; }

                /// <summary>
                /// <para>最后一次进度百分比更新时间 毫秒</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("progress_rate_percent_last_updated_time")]
                public string? ProgressRatePercentLastUpdatedTime { get; set; }

                /// <summary>
                /// <para>最后一次状态更新时间 毫秒</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("progress_rate_status_last_updated_time")]
                public string? ProgressRateStatusLastUpdatedTime { get; set; }

                /// <summary>
                /// <para>最后一次在侧边栏新增或者编辑进展的时间 毫秒</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("progress_record_last_updated_time")]
                public string? ProgressRecordLastUpdatedTime { get; set; }

                /// <summary>
                /// <para>最后一次编辑备注的时间 毫秒</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("progress_report_last_updated_time")]
                public string? ProgressReportLastUpdatedTime { get; set; }

                /// <summary>
                /// <para>最后一次打分更新时间 毫秒</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("score_last_updated_time")]
                public string? ScoreLastUpdatedTime { get; set; }

                /// <summary>
                /// <para>截止时间 毫秒</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("deadline")]
                public string? Deadline { get; set; }

                /// <summary>
                /// <para>该Objective提到的人员列表</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("mentioned_user_list")]
                public OkrObjectiveAlignedObjectiveOwner[]? MentionedUserList { get; set; }
            }

            /// <summary>
            /// <para>对齐到该Objective的Objective列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("aligned_objective_list")]
            public OkrObjectiveAlignedObjective[]? AlignedObjectiveList { get; set; }

            /// <summary>
            /// <para>该Objective对齐到的Objective列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("aligning_objective_list")]
            public OkrObjectiveAlignedObjective[]? AligningObjectiveList { get; set; }

            public record OkrObjectiveAlignedObjective
            {
                /// <summary>
                /// <para>Objective的ID</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>OKR的ID</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("okr_id")]
                public string? OkrId { get; set; }

                /// <summary>
                /// <para>该Objective的Owner</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("owner")]
                public OkrObjectiveAlignedObjectiveOwner? Owner { get; set; }
            }

            /// <summary>
            /// <para>该Objective的进度列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("progress_record_list")]
            public ProgressRecordSimplify[]? ProgressRecordList { get; set; }

            public record ProgressRecordSimplify
            {
                /// <summary>
                /// <para>OKR 进展记录ID</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("id")]
                public string? Id { get; set; }
            }

            /// <summary>
            /// <para>最后一次进度百分比更新时间 毫秒</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("progress_rate_percent_last_updated_time")]
            public string? ProgressRatePercentLastUpdatedTime { get; set; }

            /// <summary>
            /// <para>最后一次状态更新时间 毫秒</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("progress_rate_status_last_updated_time")]
            public string? ProgressRateStatusLastUpdatedTime { get; set; }

            /// <summary>
            /// <para>最后一次在侧边栏新增或者编辑进展的时间 毫秒</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("progress_record_last_updated_time")]
            public string? ProgressRecordLastUpdatedTime { get; set; }

            /// <summary>
            /// <para>最后一次编辑备注的时间 毫秒</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("progress_report_last_updated_time")]
            public string? ProgressReportLastUpdatedTime { get; set; }

            /// <summary>
            /// <para>最后一次打分更新时间 毫秒</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("score_last_updated_time")]
            public string? ScoreLastUpdatedTime { get; set; }

            /// <summary>
            /// <para>截止时间 毫秒</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("deadline")]
            public string? Deadline { get; set; }

            /// <summary>
            /// <para>该Objective提到的人员列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("mentioned_user_list")]
            public OkrObjectiveAlignedObjectiveOwner[]? MentionedUserList { get; set; }

            public record OkrObjectiveAlignedObjectiveOwner
            {
                /// <summary>
                /// <para>用户的 open_id</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("open_id")]
                public string? OpenId { get; set; }

                /// <summary>
                /// <para>用户的 user_id</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("user_id")]
                public string? UserId { get; set; }
            }
        }

        /// <summary>
        /// <para>OKR确认状态</para>
        /// <para>**可选值有**：</para>
        /// <para>0:初始状态,1:待提交/未提交,2:待处理/待确认,3:已拒绝/已建议,4:已通过/已确认</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：初始状态</item>
        /// <item>1：待提交/未提交</item>
        /// <item>2：待处理/待确认</item>
        /// <item>3：已拒绝/已建议</item>
        /// <item>4：已通过/已确认</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("confirm_status")]
        public int? ConfirmStatus { get; set; }
    }
}
