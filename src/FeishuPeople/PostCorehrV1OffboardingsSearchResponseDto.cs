// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-01-08
// ************************************************************************
// <copyright file="PostCorehrV1OffboardingsSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索离职信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 搜索离职信息 响应体
/// <para>该接口支持根据员工ID、离职审批发起时间和离职日期等字段搜索离职信息，可获取包括离职日期、离职原因、离职状态和流程审批状态等信息。</para>
/// <para>接口ID：7211423970042183684</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/offboarding/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2foffboarding%2fsearch</para>
/// </summary>
public record PostCorehrV1OffboardingsSearchResponseDto : IPageableResponse<PostCorehrV1OffboardingsSearchResponseDto.Offboarding>
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
        /// <para>离职发起类型，可选项包括：</para>
        /// <para>-offboarding_initiated_by_self：员工申请离职</para>
        /// <para>-offboarding_initiated_by_others：代发起离职申请</para>
        /// <para>-offboarding_directly：直接离职</para>
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
            /// <para>离职审批发起人的雇佣 ID。ID 类型与查询参数 user_id_type 的取值一致。例如，当user_id_type为user_id时，该字段取员工的user_id，若user_id_type为people_corehr_id时，则取该员工的人事雇佣ID。</para>
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
            /// <para>流程 ID。可用于[查询流程相关信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/process/list)，例如：作为[获取单个流程详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/process/list)的process_id查询流程详情。</para>
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
            /// <para>离职员工的雇佣 ID，ID类型与查询参数 user_id_type取值一致：</para>
            /// <para>1、当user_id_type取值为open_id时，ID获取方式参考[如何获取自己的Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)。</para>
            /// <para>2、当user_id_type取值为user_id时，ID获取方式参考[如何获取自己的 User ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)。</para>
            /// <para>3、当user_id_type取值为union_id时，ID获取方式参考[如何获取自己的 Union ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)。</para>
            /// <para>4、当user_id_type取值为people_corehr_id时，先参考[如何获取自己的 User ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)获取User ID。然后通过[ID 转换](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/common_data-id/convert)获取雇佣ID。</para>
            /// <para>必填：否</para>
            /// <para>示例值：6893014062142064135</para>
            /// </summary>
            [JsonPropertyName("employment_id")]
            public string? EmploymentId { get; set; }

            /// <summary>
            /// <para>员工的 hrbp 列表，ID类型与查询参数 user_id_type取值一致：</para>
            /// <para>1、当user_id_type取值为open_id时，ID获取方式参考[如何获取自己的Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)。</para>
            /// <para>2、当user_id_type取值为user_id时，ID获取方式参考[如何获取自己的 User ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)。</para>
            /// <para>3、当user_id_type取值为union_id时，ID获取方式参考[如何获取自己的 Union ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)。</para>
            /// <para>4、当user_id_type取值为people_corehr_id时，先参考[如何获取自己的 User ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)获取User ID。然后通过[ID 转换](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/common_data-id/convert)获取雇佣ID。</para>
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
            /// <para>是否加入离职屏蔽名单。注意：该字段为字符类型。可选值有：</para>
            /// <para>-true：是</para>
            /// <para>-false：否</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("add_block_list")]
            public string? AddBlockList { get; set; }

            /// <summary>
            /// <para>屏蔽原因，枚举值可查询</para>
            /// <para>[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取,按如下参数查</para>
            /// <para>询即可:</para>
            /// <para>object_api_name= "offboarding_info"</para>
            /// <para>custom_api_name= "block_reason"</para>
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
                /// <para>自定义字段的唯一标识</para>
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
                /// <para>自定义字段类型。可选值有：</para>
                /// <para>-1：文本类型，包括超链接字段</para>
                /// <para>-2：布尔类型</para>
                /// <para>-3：数字类型</para>
                /// <para>-4：枚举类型</para>
                /// <para>-5：Lookup类型，如离职人员、竞业公司等</para>
                /// <para>-8：时间类型</para>
                /// <para>-9：附件类型</para>
                /// <para>注意：不支持的字段类型未给出说明。</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("type")]
                public int? Type { get; set; }

                /// <summary>
                /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同（如 123, 123.23, "true", ["id1","id2"], "2006-01-02 15:04:05"）</para>
                /// <para>必填：是</para>
                /// <para>示例值：231</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }

            /// <summary>
            /// <para>离职是否保留飞书账号</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("retain_account")]
            public bool? RetainAccount { get; set; }

            /// <summary>
            /// <para>社保停保年月，按YYYY-MM的日期格式返回</para>
            /// <para>必填：否</para>
            /// <para>示例值：2022-02</para>
            /// </summary>
            [JsonPropertyName("social_insurance_end_date")]
            public string? SocialInsuranceEndDate { get; set; }

            /// <summary>
            /// <para>公积金截止年月，按YYYY-MM的日期格式返回</para>
            /// <para>必填：否</para>
            /// <para>示例值：2022-02</para>
            /// </summary>
            [JsonPropertyName("provident_fund_end_date")]
            public string? ProvidentFundEndDate { get; set; }

            /// <summary>
            /// <para>是否启动竞业</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("enforce_noncompete_agreement")]
            public bool? EnforceNoncompeteAgreement { get; set; }

            /// <summary>
            /// <para>竞业合同ID，可以通过[查询单个合同](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/contract/get)获取详细的合同信息</para>
            /// <para>必填：否</para>
            /// <para>示例值：123</para>
            /// </summary>
            [JsonPropertyName("noncompete_agreement_id")]
            public string? NoncompeteAgreementId { get; set; }

            /// <summary>
            /// <para>竞业公司ID，可以通过[查询单个公司](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/company/get)获取详细的公司信息</para>
            /// <para>必填：否</para>
            /// <para>示例值：123</para>
            /// </summary>
            [JsonPropertyName("noncompete_agreement_company")]
            public string? NoncompeteAgreementCompany { get; set; }

            /// <summary>
            /// <para>竞业开始日期</para>
            /// <para>必填：否</para>
            /// <para>示例值：2022-02-08</para>
            /// </summary>
            [JsonPropertyName("noncompete_agreement_start_date")]
            public string? NoncompeteAgreementStartDate { get; set; }

            /// <summary>
            /// <para>竞业结束日期</para>
            /// <para>必填：否</para>
            /// <para>示例值：2022-02-08</para>
            /// </summary>
            [JsonPropertyName("noncompete_agreement_end_date")]
            public string? NoncompeteAgreementEndDate { get; set; }

            /// <summary>
            /// <para>签署方式，枚举值可查询</para>
            /// <para>[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取,按如下参数查</para>
            /// <para>询即可:</para>
            /// <para>object_api_name= "offboarding_info"</para>
            /// <para>custom_api_name= "sign_type"</para>
            /// <para>必填：否</para>
            /// <para>示例值：2022-02-08</para>
            /// </summary>
            [JsonPropertyName("sign_type")]
            public Enum? SignType { get; set; }

            /// <summary>
            /// <para>签署文件ID列表</para>
            /// <para>必填：否</para>
            /// <para>示例值：["123","456"]</para>
            /// </summary>
            [JsonPropertyName("signature_file")]
            public string? SignatureFile { get; set; }

            /// <summary>
            /// <para>最后出勤日</para>
            /// <para>必填：否</para>
            /// <para>示例值：2022-02-08</para>
            /// </summary>
            [JsonPropertyName("last_attendance_date")]
            public string? LastAttendanceDate { get; set; }

            /// <summary>
            /// <para>是否带编转移</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("is_transfer_with_workforce")]
            public bool? IsTransferWithWorkforce { get; set; }
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
            /// <para>离职流转流程实例 ID。可用于[查询流程相关信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/process/list)，例如：作为[获取单个流程详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/process/list)的process_id查询流程详情。</para>
            /// <para>必填：否</para>
            /// <para>示例值：6838119494196871234</para>
            /// </summary>
            [JsonPropertyName("checklist_process_id")]
            public string? ChecklistProcessId { get; set; }
        }

        /// <summary>
        /// <para>离职唯一标识</para>
        /// <para>必填：否</para>
        /// <para>示例值：7298499290417251879</para>
        /// </summary>
        [JsonPropertyName("offboarding_id")]
        public string? OffboardingId { get; set; }
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
