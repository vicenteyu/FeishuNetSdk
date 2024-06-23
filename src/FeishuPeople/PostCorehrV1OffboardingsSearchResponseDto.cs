// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV1OffboardingsSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索离职信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 搜索离职信息 响应体
/// <para>搜索离职信息，该接口会按照应用拥有的「员工数据」的权限范围返回数据，请确定在「开发者后台 - 权限管理 - 数据权限」中申请了「员工资源」权限范围。</para>
/// <para>接口ID：7211423970042183684</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/offboarding/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2foffboarding%2fsearch</para>
/// </summary>
public record PostCorehrV1OffboardingsSearchResponseDto
{
    /// <summary>
    /// <para>查询的员工离职信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Offboarding[]? Items { get; set; }

    /// <summary>
    /// <para>查询的员工离职信息</para>
    /// </summary>
    public record Offboarding
    {
        /// <summary>
        /// <para>离职发起类型，包括：</para>
        /// <para>必填：否</para>
        /// <para>示例值：offboarding_directly</para>
        /// </summary>
        [JsonPropertyName("initiating_type")]
        public string? InitiatingType { get; set; }

        /// <summary>
        /// <para>离职状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：Approving</para>
        /// <para>可选值：<list type="bullet">
        /// <item>Approving：审批中</item>
        /// <item>Approved：审批通过</item>
        /// <item>Offboarded：已离职</item>
        /// <item>Rejected：已拒绝</item>
        /// <item>Withdrawn：已撤销</item>
        /// <item>NoNeedApproval：无需审批</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// <para>离职审批信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("application_info")]
        public OffboardingApplicationInfo? ApplicationInfo { get; set; }

        /// <summary>
        /// <para>离职审批信息</para>
        /// </summary>
        public record OffboardingApplicationInfo
        {
            /// <summary>
            /// <para>离职审批发起人的雇佣 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6838119494196871234</para>
            /// </summary>
            [JsonPropertyName("apply_initiator_id")]
            public string? ApplyInitiatorId { get; set; }

            /// <summary>
            /// <para>离职申请流程发起时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：2022-02-03 11:22:33</para>
            /// </summary>
            [JsonPropertyName("apply_initiating_time")]
            public string? ApplyInitiatingTime { get; set; }

            /// <summary>
            /// <para>离职申请流程结束时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：2022-02-03 11:22:33</para>
            /// </summary>
            [JsonPropertyName("apply_finish_time")]
            public string? ApplyFinishTime { get; set; }

            /// <summary>
            /// <para>流程 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6838119494196871234</para>
            /// </summary>
            [JsonPropertyName("process_id")]
            public string? ProcessId { get; set; }
        }

        /// <summary>
        /// <para>员工离职信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("offboarding_info")]
        public OffboardingOffboardingInfo? OffboardingInfo { get; set; }

        /// <summary>
        /// <para>员工离职信息</para>
        /// </summary>
        public record OffboardingOffboardingInfo
        {
            /// <summary>
            /// <para>离职员工的雇佣 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6893014062142064135</para>
            /// </summary>
            [JsonPropertyName("employment_id")]
            public string? EmploymentId { get; set; }

            /// <summary>
            /// <para>员工的 hrbp 列表，所有的 hrbp</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("hrbp_id")]
            public string[]? HrbpId { get; set; }

            /// <summary>
            /// <para>期望离职日期</para>
            /// <para>必填：否</para>
            /// <para>示例值：2022-02-08</para>
            /// </summary>
            [JsonPropertyName("expected_offboarding_date")]
            public string? ExpectedOffboardingDate { get; set; }

            /// <summary>
            /// <para>离职日期</para>
            /// <para>必填：否</para>
            /// <para>示例值：2022-02-08</para>
            /// </summary>
            [JsonPropertyName("offboarding_date")]
            public string? OffboardingDate { get; set; }

            /// <summary>
            /// <para>离职原因</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("reason")]
            public Enum? Reason { get; set; }

            /// <summary>
            /// <para>离职原因</para>
            /// </summary>
            public record Enum
            {
                /// <summary>
                /// <para>枚举值</para>
                /// <para>必填：是</para>
                /// <para>示例值：phone_type</para>
                /// </summary>
                [JsonPropertyName("enum_name")]
                public string EnumName { get; set; } = string.Empty;

                /// <summary>
                /// <para>枚举多语展示</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("display")]
                public I18n[]? Displies { get; set; }

                /// <summary>
                /// <para>枚举多语展示</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>语言</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：zh-CN</para>
                    /// </summary>
                    [JsonPropertyName("lang")]
                    public string Lang { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>内容</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：刘梓新</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string Value { get; set; } = string.Empty;
                }
            }

            /// <summary>
            /// <para>离职原因说明</para>
            /// <para>必填：否</para>
            /// <para>示例值：升学</para>
            /// </summary>
            [JsonPropertyName("reason_explanation")]
            public string? ReasonExplanation { get; set; }

            /// <summary>
            /// <para>离职原因（员工）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("employee_reason")]
            public Enum? EmployeeReason { get; set; }

            /// <summary>
            /// <para>离职原因说明（员工）</para>
            /// <para>必填：否</para>
            /// <para>示例值：升学</para>
            /// </summary>
            [JsonPropertyName("employee_reason_explanation")]
            public string? EmployeeReasonExplanation { get; set; }

            /// <summary>
            /// <para>是否加入离职屏蔽名单</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("add_block_list")]
            public string? AddBlockList { get; set; }

            /// <summary>
            /// <para>屏蔽原因</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("block_reason")]
            public Enum? BlockReason { get; set; }

            /// <summary>
            /// <para>屏蔽原因说明</para>
            /// <para>必填：否</para>
            /// <para>示例值：xx 年 xx 月 xx 日因 xx 原因红线</para>
            /// </summary>
            [JsonPropertyName("block_reason_explanation")]
            public string? BlockReasonExplanation { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("custom_fields")]
            public CustomFieldData[]? CustomFields { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// </summary>
            public record CustomFieldData
            {
                /// <summary>
                /// <para>自定义字段 apiname，即自定义字段的唯一标识</para>
                /// <para>必填：是</para>
                /// <para>示例值：name</para>
                /// </summary>
                [JsonPropertyName("custom_api_name")]
                public string CustomApiName { get; set; } = string.Empty;

                /// <summary>
                /// <para>自定义字段名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public CustomName? Name { get; set; }

                /// <summary>
                /// <para>自定义字段名称</para>
                /// </summary>
                public record CustomName
                {
                    /// <summary>
                    /// <para>中文</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：自定义姓名</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>英文</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：Custom Name</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }

                /// <summary>
                /// <para>自定义字段类型</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("type")]
                public int? Type { get; set; }

                /// <summary>
                /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同（如 123, 123.23, "true", ["id1","id2"], "2006-01-02 15:04:05"）</para>
                /// <para>必填：是</para>
                /// <para>示例值："231"</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// <para>离职办理流程信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("offboarding_checklist")]
        public OffboardingOffboardingChecklist? OffboardingChecklist { get; set; }

        /// <summary>
        /// <para>离职办理流程信息</para>
        /// </summary>
        public record OffboardingOffboardingChecklist
        {
            /// <summary>
            /// <para>离职办理状态，可选值有：</para>
            /// <para>- AntiBegin：未发起</para>
            /// <para>- Approving：审批中</para>
            /// <para>- Finished：完成办理</para>
            /// <para>- Rejected：已拒绝</para>
            /// <para>- Withdrawn：已撤销</para>
            /// <para>必填：否</para>
            /// <para>示例值：AntiBegin</para>
            /// </summary>
            [JsonPropertyName("checklist_status")]
            public string? ChecklistStatus { get; set; }

            /// <summary>
            /// <para>离职流转开始时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：2022-02-03 11:22:33</para>
            /// </summary>
            [JsonPropertyName("checklist_start_time")]
            public string? ChecklistStartTime { get; set; }

            /// <summary>
            /// <para>离职流转结束时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：2022-02-03 11:22:33</para>
            /// </summary>
            [JsonPropertyName("checklist_finish_time")]
            public string? ChecklistFinishTime { get; set; }

            /// <summary>
            /// <para>离职流转流程实例 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6838119494196871234</para>
            /// </summary>
            [JsonPropertyName("checklist_process_id")]
            public string? ChecklistProcessId { get; set; }
        }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eyJldV9uYyI6IlswLFwiNjk2MTI4Njg0NjA5Mzc4ODY4MC03MjExMDM0ODcxMjA3OTUzOTc1XCJdIn0=</para>
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
