// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetApprovalV4ExternalApprovalsByApprovalCodeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查看指定三方审批定义 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval;
/// <summary>
/// 查看指定三方审批定义 响应体
/// <para>调用该接口通过三方审批定义 Code 获取审批定义的详细数据，包括三方审批定义的名称、说明、三方审批发起链接、回调 URL 以及审批定义可见人列表等信息。</para>
/// <para>接口ID：7255160068449828892</para>
/// <para>文档地址：https://open.feishu.cn/document/approval-v4/external_approval/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2fexternal_approval%2fget</para>
/// </summary>
public record GetApprovalV4ExternalApprovalsByApprovalCodeResponseDto
{
    /// <summary>
    /// <para>审批定义名称。当前参数返回的是 @i18n@ 开头的 key，需要通过 i18n_resources.texts 参数值查阅当前 key 对应的取值（value）。</para>
    /// <para>必填：是</para>
    /// <para>示例值：@i18n@1</para>
    /// </summary>
    [JsonPropertyName("approval_name")]
    public string ApprovalName { get; set; } = string.Empty;

    /// <summary>
    /// <para>创建三方审批定义时传入的 approval_code。</para>
    /// <para>**注意**：[创建三方审批定义](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/external_approval/create)接口的请求参数 approval_code 与响应参数 approval_code 不一定相同，当前参数所返回的是作为请求参数的 approval_code 的值。</para>
    /// <para>必填：是</para>
    /// <para>示例值：permission_test</para>
    /// </summary>
    [JsonPropertyName("approval_code")]
    public string ApprovalCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批定义所属分组</para>
    /// <para>必填：是</para>
    /// <para>示例值：work_group</para>
    /// </summary>
    [JsonPropertyName("group_code")]
    public string GroupCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>分组名称。当前参数返回的是 @i18n@ 开头的 key，需要通过 i18n_resources.texts 参数值查阅当前 key 对应的取值（value）。</para>
    /// <para>必填：否</para>
    /// <para>示例值：@i18n@2</para>
    /// </summary>
    [JsonPropertyName("group_name")]
    public string? GroupName { get; set; }

    /// <summary>
    /// <para>审批定义的说明。当前参数返回的是 @i18n@ 开头的 key，需要通过 i18n_resources.texts 参数值查阅当前 key 对应的取值（value）。</para>
    /// <para>必填：否</para>
    /// <para>示例值：@i18n@2</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// <para>三方审批定义相关信息。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("external")]
    public ApprovalCreateExternal? External { get; set; }

    /// <summary>
    /// <para>三方审批定义相关信息。</para>
    /// </summary>
    public record ApprovalCreateExternal
    {
        /// <summary>
        /// <para>列表中用于提示审批来自哪里。当前参数返回的是 @i18n@ 开头的 key，需要通过 i18n_resources.texts 参数值查阅当前 key 对应的取值（value）。</para>
        /// <para>必填：否</para>
        /// <para>示例值：@i18n@3</para>
        /// </summary>
        [JsonPropertyName("biz_name")]
        public string? BizName { get; set; }

        /// <summary>
        /// <para>审批定义业务类别，可由用户自定义，用于分类审批定义。</para>
        /// <para>必填：否</para>
        /// <para>示例值：permission</para>
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string? BizType { get; set; }

        /// <summary>
        /// <para>移动端发起三方审批的链接。如果没有配置移动端链接，则返回空值。</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://applink.feishu.cn/client/mini_program/open?appId=cli_9c90fc38e07a9101&amp;path=pages/approval-form/index?id=9999</para>
        /// </summary>
        [JsonPropertyName("create_link_mobile")]
        public string? CreateLinkMobile { get; set; }

        /// <summary>
        /// <para>PC 端发起三方审批的链接。如果没有配置 PC 端链接，则返回空值。</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://applink.feishu.cn/client/mini_program/open?mode=appCenter&amp;appId=cli_9c90fc38e07a9101&amp;path=pc/pages/create-form/index?id=9999</para>
        /// </summary>
        [JsonPropertyName("create_link_pc")]
        public string? CreateLinkPc { get; set; }

        /// <summary>
        /// <para>审批实例、审批任务、审批抄送是否在 PC 端展示。</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("support_pc")]
        public bool? SupportPc { get; set; }

        /// <summary>
        /// <para>审批实例、审批任务、审批抄送是否在移动端展示。</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("support_mobile")]
        public bool? SupportMobile { get; set; }

        /// <summary>
        /// <para>是否支持批量已读</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("support_batch_read")]
        public bool? SupportBatchRead { get; set; }

        /// <summary>
        /// <para>是否支持标注可读</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("enable_mark_readed")]
        public bool? EnableMarkReaded { get; set; }

        /// <summary>
        /// <para>是否支持快速操作</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("enable_quick_operate")]
        public bool? EnableQuickOperate { get; set; }

        /// <summary>
        /// <para>三方系统的操作回调 URL，**待审批** 实例的任务审批人点击同意或拒绝操作后，审批中心调用该 URL 通知三方系统，回调地址相关信息可参见[三方审批快捷审批回调](https://open.feishu.cn/document/ukTMukTMukTM/ukjNyYjL5YjM24SO2IjN/quick-approval-callback)。</para>
        /// <para>必填：否</para>
        /// <para>示例值：http://www.feishu.cn/approval/openapi/instanceOperate</para>
        /// </summary>
        [JsonPropertyName("action_callback_url")]
        public string? ActionCallbackUrl { get; set; }

        /// <summary>
        /// <para>回调时带的 token，用于业务系统验证请求来自审批中心。</para>
        /// <para>必填：否</para>
        /// <para>示例值：sdjkljkx9lsadf110</para>
        /// </summary>
        [JsonPropertyName("action_callback_token")]
        public string? ActionCallbackToken { get; set; }

        /// <summary>
        /// <para>请求参数加密密钥。如果配置了该参数，则会对请求参数进行加密，接收请求后需要对请求进行解密。加解密算法参考[关联外部选项说明](https://open.feishu.cn/document/ukTMukTMukTM/uADM4QjLwADO04CMwgDN)。</para>
        /// <para>必填：否</para>
        /// <para>示例值：gfdqedvsadfgfsd</para>
        /// </summary>
        [JsonPropertyName("action_callback_key")]
        public string? ActionCallbackKey { get; set; }

        /// <summary>
        /// <para>是否支持批量审批</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("allow_batch_operate")]
        public bool? AllowBatchOperate { get; set; }

        /// <summary>
        /// <para>审批流程数据是否不纳入效率统计</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("exclude_efficiency_statistics")]
        public bool? ExcludeEfficiencyStatistics { get; set; }
    }

    /// <summary>
    /// <para>可见人列表，在可见范围内的用户可在审批发起页看到当前审批。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("viewers")]
    public ApprovalCreateViewers[]? Viewers { get; set; }

    /// <summary>
    /// <para>可见人列表，在可见范围内的用户可在审批发起页看到当前审批。</para>
    /// </summary>
    public record ApprovalCreateViewers
    {
        /// <summary>
        /// <para>可见人类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：USER</para>
        /// <para>可选值：<list type="bullet">
        /// <item>TENANT：租户内可见</item>
        /// <item>DEPARTMENT：指定部门</item>
        /// <item>USER：指定用户</item>
        /// <item>NONE：任何人都不可见</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("viewer_type")]
        public string? ViewerType { get; set; }

        /// <summary>
        /// <para>当 viewer_type 取值为 USER 时，该参数有返回值，返回的是指定用户的 ID，ID类型与查询参数 user_id_type 取值一致。</para>
        /// <para>必填：否</para>
        /// <para>示例值：19a294c2</para>
        /// </summary>
        [JsonPropertyName("viewer_user_id")]
        public string? ViewerUserId { get; set; }

        /// <summary>
        /// <para>当 viewer_type 取值为 DEPARTMENT 时，该参数有返回值，返回的是指定部门的 ID。</para>
        /// <para>必填：否</para>
        /// <para>示例值：od-ac9d697abfa990b715dcc33d58a62a9d</para>
        /// </summary>
        [JsonPropertyName("viewer_department_id")]
        public string? ViewerDepartmentId { get; set; }
    }

    /// <summary>
    /// <para>国际化文案</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("i18n_resources")]
    public I18nResource[]? I18nResources { get; set; }

    /// <summary>
    /// <para>国际化文案</para>
    /// </summary>
    public record I18nResource
    {
        /// <summary>
        /// <para>语言</para>
        /// <para>必填：是</para>
        /// <para>示例值：zh-CN</para>
        /// <para>可选值：<list type="bullet">
        /// <item>zh-CN：中文</item>
        /// <item>en-US：英文</item>
        /// <item>ja-JP：日文</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("locale")]
        public string Locale { get; set; } = string.Empty;

        /// <summary>
        /// <para>文案的 Key:Value。Key 以 @i18n@ 开头，并匹配其他各个参数 Key。</para>
        /// <para>**说明**：该字段主要用于适配国际化，允许同时设置多个语言的文案，审批中心会根据实际用户当前的语音环境使用匹配的文案。如果没有设置用户当前的语音环境文案，则会使用默认的语言文案。</para>
        /// <para>必填：是</para>
        /// <para>示例值：{ "@i18n@1": "权限申请", "@i18n@2": "OA审批", "@i18n@3": "Permission" }</para>
        /// </summary>
        [JsonPropertyName("texts")]
        public I18nResourceText[] Texts { get; set; } = [];

        /// <summary>
        /// <para>文案的 Key:Value。Key 以 @i18n@ 开头，并匹配其他各个参数 Key。</para>
        /// <para>**说明**：该字段主要用于适配国际化，允许同时设置多个语言的文案，审批中心会根据实际用户当前的语音环境使用匹配的文案。如果没有设置用户当前的语音环境文案，则会使用默认的语言文案。</para>
        /// </summary>
        public record I18nResourceText
        {
            /// <summary>
            /// <para>文案 key</para>
            /// <para>必填：是</para>
            /// <para>示例值：@i18n@1</para>
            /// </summary>
            [JsonPropertyName("key")]
            public string Key { get; set; } = string.Empty;

            /// <summary>
            /// <para>文案 value</para>
            /// <para>必填：是</para>
            /// <para>示例值：审批定义</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>是否为默认语言。</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_default")]
        public bool IsDefault { get; set; }
    }

    /// <summary>
    /// <para>审批流程管理员列表，列表内包含的是用户 ID，ID 类型与查询参数 user_id_type 取值一致。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("managers")]
    public string[]? Managers { get; set; }
}
