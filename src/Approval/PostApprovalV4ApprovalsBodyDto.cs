// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="PostApprovalV4ApprovalsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建审批定义 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval;
/// <summary>
/// 创建审批定义 请求体
/// <para>该接口用于创建审批定义，可以灵活指定审批定义的基础信息、表单和流程等。</para>
/// <para>## 使用限制</para>
/// <para>通过该 API 创建的审批定义，无法从审批管理后台或以 API 方式停用、删除，请谨慎调用。不推荐企业自建应用使用该 API 创建审批定义，如有需要，尽量联系企业管理员[在审批管理后台创建定义](https://www.feishu.cn/hc/zh-CN/articles/360040241113-%E7%AE%A1%E7%90%86%E5%91%98%E5%88%9B%E5%BB%BA%E5%AE%A1%E6%89%B9)。</para>
/// <para>接口ID：7114621541589712899</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/approval/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2fapproval%2fcreate</para>
/// </summary>
public record PostApprovalV4ApprovalsBodyDto
{
    /// <summary>
    /// <para>审批名称的国际化文案 Key，以 `@i18n@` 开头，长度不得少于 9 个字符。</para>
    /// <para>必填：是</para>
    /// <para>示例值：@i18n@approval_name</para>
    /// </summary>
    [JsonPropertyName("approval_name")]
    public string ApprovalName { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批定义 Code。使用说明：</para>
    /// <para>- 该参数不传值时，表示新建审批定义，最终响应结果会返回由系统自动生成的审批定义 Code。</para>
    /// <para>- 该参数传入指定审批定义 Code 时，表示调用该接口更新该审批定义内容，更新方式为覆盖原定义内容的全量更新。</para>
    /// <para>审批定义 Code。获取方式：</para>
    /// <para>- 调用[创建审批定义](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/approval/create)接口后，从响应参数 approval_code 获取。</para>
    /// <para>- 登录审批管理后台，在指定审批定义的 URL 中获取，具体操作参见[什么是 Approval Code](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/approval/overview-of-approval-resources#8151e0ae)。</para>
    /// <para>必填：否</para>
    /// <para>示例值：7C468A54-8745-2245-9675-08B7C63E7A85</para>
    /// </summary>
    [JsonPropertyName("approval_code")]
    public string? ApprovalCode { get; set; }

    /// <summary>
    /// <para>审批描述的国际化文案 Key，以 `@i18n@` 开头，长度不得少于 9 个字符。</para>
    /// <para>必填：否</para>
    /// <para>示例值：@i18n@description</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// <para>viewers 字段指定了哪些人能从审批应用的前台发起该审批。使用说明：</para>
    /// <para>- 当 viewer_type 为 USER，需要填写 viewer_user_id</para>
    /// <para>- 当 viewer_type 为 DEPARTMENT，需要填写 viewer_department_id</para>
    /// <para>- 当 viewer_type 为 TENANT 或 NONE 时，无需填写 viewer_user_id 和 viewer_department_id</para>
    /// <para>**注意**：列表最大长度为 200。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("viewers")]
    public ApprovalCreateViewers[] Viewers { get; set; } = Array.Empty<ApprovalCreateViewers>();

    /// <summary>
    /// <para>viewers 字段指定了哪些人能从审批应用的前台发起该审批。使用说明：</para>
    /// <para>- 当 viewer_type 为 USER，需要填写 viewer_user_id</para>
    /// <para>- 当 viewer_type 为 DEPARTMENT，需要填写 viewer_department_id</para>
    /// <para>- 当 viewer_type 为 TENANT 或 NONE 时，无需填写 viewer_user_id 和 viewer_department_id</para>
    /// <para>**注意**：列表最大长度为 200。</para>
    /// </summary>
    public record ApprovalCreateViewers
    {
        /// <summary>
        /// <para>审批定义的可见范围</para>
        /// <para>必填：否</para>
        /// <para>示例值：USER</para>
        /// <para>可选值：<list type="bullet">
        /// <item>TENANT：当前企业内可见</item>
        /// <item>DEPARTMENT：指定部门可见</item>
        /// <item>USER：指定用户可见</item>
        /// <item>NONE：任何人都不可见</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("viewer_type")]
        public string? ViewerType { get; set; }

        /// <summary>
        /// <para>当 viewer_type 是 USER 时，需要通过该参数传入用户 ID，ID 类型与查询参数 user_id_type 取值一致。</para>
        /// <para>必填：否</para>
        /// <para>示例值：19a294c2</para>
        /// </summary>
        [JsonPropertyName("viewer_user_id")]
        public string? ViewerUserId { get; set; }

        /// <summary>
        /// <para>当 viewer_type 为DEPARTMENT，需要通过该参数传入部门 ID，ID 类型与查询参数 department_id_type 取值一致。</para>
        /// <para>必填：否</para>
        /// <para>示例值：od-ac9d697abfa990b715dcc33d58a62a9d</para>
        /// </summary>
        [JsonPropertyName("viewer_department_id")]
        public string? ViewerDepartmentId { get; set; }
    }

    /// <summary>
    /// <para>审批定义表单</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("form")]
    public ApprovalForm Form { get; set; } = new();

    /// <summary>
    /// <para>审批定义表单</para>
    /// </summary>
    public record ApprovalForm
    {
        /// <summary>
        /// <para>审批定义表单。表单格式为 JSON 数组，实际传值时需要将 JSON 压缩转义为 String 类型。表单内各个控件的 JSON 字段说明参见[审批定义表单控件参数](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/approval/approval-definition-form-control-parameters)。</para>
        /// <para>**注意**：以下示例值未转义，你可以参考下文**请求示例**章节的示例代码。</para>
        /// <para>必填：是</para>
        /// <para>示例值：[{\"id\":\"user_name\", \"type\": \"input\", \"required\":true, \"name\":\"@i18n@widget1\"}]</para>
        /// </summary>
        [JsonPropertyName("form_content")]
        public string FormContent { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>审批定义节点列表，用于设置审批流程所需要的各个节点，审批流程的始末固定为开始节点和结束节点，因此传值时需要将开始节点作为 list 第一个元素，结束节点作为 list 最后一个元素。</para>
    /// <para>**说明**：API 方式不支持设置条件分支，如需设置条件分支请前往[飞书审批后台](https://www.feishu.cn/approval/admin/approvalList?devMode=on)创建审批定义。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("node_list")]
    public ApprovalNode[] NodeLists { get; set; } = Array.Empty<ApprovalNode>();

    /// <summary>
    /// <para>审批定义节点列表，用于设置审批流程所需要的各个节点，审批流程的始末固定为开始节点和结束节点，因此传值时需要将开始节点作为 list 第一个元素，结束节点作为 list 最后一个元素。</para>
    /// <para>**说明**：API 方式不支持设置条件分支，如需设置条件分支请前往[飞书审批后台](https://www.feishu.cn/approval/admin/approvalList?devMode=on)创建审批定义。</para>
    /// </summary>
    public record ApprovalNode
    {
        /// <summary>
        /// <para>节点 ID。</para>
        /// <para>- 开始节点的 ID 为 START</para>
        /// <para>- 结束节点的 ID 为 END</para>
        /// <para>开始和结束节点不需要指定 name、node_type 以及 approver。</para>
        /// <para>必填：是</para>
        /// <para>示例值：START</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>节点名称的国际化文案 Key，以 `@i18n@` 开头，长度不得少于 9 个字符。</para>
        /// <para>必填：否</para>
        /// <para>示例值：@i18n@node_name</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>当前节点的审批方式。</para>
        /// <para>**注意**：当该参数取值为依次审批（SEQUENTIAL）时，审批人类型（approver.type）必须为发起人自选（Free）。</para>
        /// <para>必填：否</para>
        /// <para>示例值：AND</para>
        /// <para>可选值：<list type="bullet">
        /// <item>AND：会签，需要所有审批人同意才会通过审批</item>
        /// <item>OR：或签，一名审批人同意即可通过审批</item>
        /// <item>SEQUENTIAL：依次审批，按照审批人顺序依次进行审批</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("node_type")]
        public string? NodeType { get; set; }

        /// <summary>
        /// <para>审批人列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("approver")]
        public ApprovalApproverCcer[]? Approvers { get; set; }

        /// <summary>
        /// <para>审批人列表</para>
        /// </summary>
        public record ApprovalApproverCcer
        {
            /// <summary>
            /// <para>审批人类型。使用说明：</para>
            /// <para>- 该参数取值为 Supervisor、SupervisorTopDown、DepartmentManager 、DepartmentManagerTopDown 这 4 种时，需要在 level 参数中填写对应的级数。例如：由下往上三级主管审批，该参数取值 Supervisor 、level 参数取值 3。</para>
            /// <para>- 该参数取值为 Personal 时，需要填写对应的 user_id ，用于指定用户。</para>
            /// <para>- 该参数取值为 Free 时，无需指定 user_id 和 level。</para>
            /// <para>必填：是</para>
            /// <para>示例值：Supervisor</para>
            /// <para>可选值：<list type="bullet">
            /// <item>Supervisor：主管审批（由下往上）</item>
            /// <item>SupervisorTopDown：主管审批（从上往下）</item>
            /// <item>DepartmentManager：部门负责人审批（由下往上）</item>
            /// <item>DepartmentManagerTopDown：部门负责人审批（从上往下）</item>
            /// <item>Personal：指定成员</item>
            /// <item>Free：发起人自选</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("type")]
            public string Type { get; set; } = string.Empty;

            /// <summary>
            /// <para>用户 ID。</para>
            /// <para>- type 取值 Personal 时需要通过该参数设置指定的用户。</para>
            /// <para>- ID 类型与查询参数 user_id_type 取值一致。</para>
            /// <para>必填：否</para>
            /// <para>示例值：f7cb567e</para>
            /// </summary>
            [JsonPropertyName("user_id")]
            public string? UserId { get; set; }

            /// <summary>
            /// <para>审批级数。当 type 取值为 Supervisor、SupervisorTopDown、DepartmentManager、DepartmentManagerTopDown 这 4 种时，需要在 level 中填写对应的级数。例如：由下往上三级主管审批，level 取值 3。</para>
            /// <para>必填：否</para>
            /// <para>示例值：3</para>
            /// </summary>
            [JsonPropertyName("level")]
            public string? Level { get; set; }
        }

        /// <summary>
        /// <para>抄送人列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("ccer")]
        public ApprovalApproverCcer[]? Ccers { get; set; }

        /// <summary>
        /// <para>表单内的控件权限</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("privilege_field")]
        public FieldGroup? PrivilegeField { get; set; }

        /// <summary>
        /// <para>表单内的控件权限</para>
        /// </summary>
        public record FieldGroup
        {
            /// <summary>
            /// <para>可写权限的表单控件项的 ID 列表，ID 需要与表单参数（form）内传入的控件 ID 值保持一致。</para>
            /// <para>必填：是</para>
            /// <para>示例值：9293493</para>
            /// </summary>
            [JsonPropertyName("writable")]
            public string[] Writable { get; set; } = Array.Empty<string>();

            /// <summary>
            /// <para>可读权限的表单控件项的 ID 列表，ID 需要与表单参数（form）内传入的控件 ID 值保持一致。</para>
            /// <para>必填：是</para>
            /// <para>示例值：9293493</para>
            /// </summary>
            [JsonPropertyName("readable")]
            public string[] Readable { get; set; } = Array.Empty<string>();
        }

        /// <summary>
        /// <para>发起人自选审批人时，是否允许多选。</para>
        /// <para>- true：允许</para>
        /// <para>- false：不允许</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("approver_chosen_multi")]
        public bool? ApproverChosenMulti { get; set; }

        /// <summary>
        /// <para>发起人自选审批人时，可选择的范围。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("approver_chosen_range")]
        public ApproverRange[]? ApproverChosenRanges { get; set; }

        /// <summary>
        /// <para>发起人自选审批人时，可选择的范围。</para>
        /// </summary>
        public record ApproverRange
        {
            /// <summary>
            /// <para>审批人类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：ALL</para>
            /// <para>可选值：<list type="bullet">
            /// <item>ALL：全企业</item>
            /// <item>PERSONAL：指定审批人</item>
            /// <item>ROLE：指定角色</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("type")]
            public string? Type { get; set; }

            /// <summary>
            /// <para>ID 列表。</para>
            /// <para>- 当 type 取值 ALL 时，无需传值。</para>
            /// <para>- 当 type 取值 PERSONAL 时，传入用户 ID，ID 类型与 user_id_type 取值一致。</para>
            /// <para>- 当 type 取值 ROLE 时，传入角色 ID。获取方式：成功[创建角色](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/functional_role/create)后，在返回结果中可获取角色 ID。</para>
            /// <para>必填：否</para>
            /// <para>示例值：f7cb567e</para>
            /// </summary>
            [JsonPropertyName("id_list")]
            public string[]? IdList { get; set; }
        }

        /// <summary>
        /// <para>审批人为提交人本人时的操作</para>
        /// <para>必填：否</para>
        /// <para>示例值：STARTER</para>
        /// <para>可选值：<list type="bullet">
        /// <item>STARTER：提交人本人进行审批</item>
        /// <item>AUTO_PASS：自动通过</item>
        /// <item>SUPERVISOR：提交人的直属上级进行审批</item>
        /// <item>DEPARTMENT_MANAGER：提交人的直属部门负责人进行审批</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("starter_assignee")]
        public string? StarterAssignee { get; set; }
    }

    /// <summary>
    /// <para>审批定义其他设置</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("settings")]
    public ApprovalSetting? Settings { get; set; }

    /// <summary>
    /// <para>审批定义其他设置</para>
    /// </summary>
    public record ApprovalSetting
    {
        /// <summary>
        /// <para>审批实例通过后允许撤回的时间，以秒为单位，默认 31 天，取值 0 为不可撤回。</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("revert_interval")]
        public int? RevertInterval { get; set; }

        /// <summary>
        /// <para>是否支持审批通过第一个节点后撤回，默认为 1 表示支持，取值为 0 表示不支持。</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("revert_option")]
        public int? RevertOption { get; set; }

        /// <summary>
        /// <para>审批被拒绝后的设置</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：默认设置，流程被终止</item>
        /// <item>1：退回至发起人，发起人可编辑流程后重新提交</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("reject_option")]
        public int? RejectOption { get; set; }

        /// <summary>
        /// <para>快捷审批配置项，开启后可在卡片上直接审批。</para>
        /// <para>**默认值**：1</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：禁用</item>
        /// <item>1：启用</item>
        /// </list></para>
        /// <para>默认值：1</para>
        /// </summary>
        [JsonPropertyName("quick_approval_option")]
        public int? QuickApprovalOption { get; set; }
    }

    /// <summary>
    /// <para>审批定义配置项，用于配置对应审批定义是否可以由用户在[审批后台](https://www.feishu.cn/approval/admin)进行修改。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("config")]
    public ApprovalConfig? Config { get; set; }

    /// <summary>
    /// <para>审批定义配置项，用于配置对应审批定义是否可以由用户在[审批后台](https://www.feishu.cn/approval/admin)进行修改。</para>
    /// </summary>
    public record ApprovalConfig
    {
        /// <summary>
        /// <para>是否允许用户修改可见范围</para>
        /// <para>**默认值**：false</para>
        /// <para>必填：是</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("can_update_viewer")]
        public bool CanUpdateViewer { get; set; }

        /// <summary>
        /// <para>是否允许用户更新表单</para>
        /// <para>**默认值**：false</para>
        /// <para>必填：是</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("can_update_form")]
        public bool CanUpdateForm { get; set; }

        /// <summary>
        /// <para>是否允许用户更新流程定义</para>
        /// <para>**默认值**：false</para>
        /// <para>必填：是</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("can_update_process")]
        public bool CanUpdateProcess { get; set; }

        /// <summary>
        /// <para>是否允许用户更新撤回设置</para>
        /// <para>**默认值**：false</para>
        /// <para>必填：是</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("can_update_revert")]
        public bool CanUpdateRevert { get; set; }

        /// <summary>
        /// <para>审批定义的帮助文档链接</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://xxx.xxx.xxx</para>
        /// </summary>
        [JsonPropertyName("help_url")]
        public string? HelpUrl { get; set; }
    }

    /// <summary>
    /// <para>审批图标枚举，默认为 0。下图从左至右，从上到下依次为 0~24 号图标。</para>
    /// <para>![icon.png](//sf3-cn.feishucdn.com/obj/open-platform-opendoc/2c60da4397e18c0ae1fdf6bf50b36ad4_tQc0Lfgx4D.png?height=1080&amp;lazyload=true&amp;width=1066)</para>
    /// <para>必填：否</para>
    /// <para>示例值：0</para>
    /// <para>默认值：0</para>
    /// </summary>
    [JsonPropertyName("icon")]
    public int? Icon { get; set; }

    /// <summary>
    /// <para>国际化文案</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("i18n_resources")]
    public I18nResource[] I18nResources { get; set; } = Array.Empty<I18nResource>();

    /// <summary>
    /// <para>国际化文案</para>
    /// </summary>
    public record I18nResource
    {
        /// <summary>
        /// <para>语言。</para>
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
        /// <para>文案的 key、value。</para>
        /// <para>必填：是</para>
        /// <para>示例值：{ "@i18n@1": "权限申请", "@i18n@2": "OA审批", "@i18n@3": "Permission" }</para>
        /// </summary>
        [JsonPropertyName("texts")]
        public I18nResourceText[] Texts { get; set; } = Array.Empty<I18nResourceText>();

        /// <summary>
        /// <para>文案的 key、value。</para>
        /// </summary>
        public record I18nResourceText
        {
            /// <summary>
            /// <para>文案 key。key 以 `@i18n@` 开头，该字段主要用于做国际化，允许用户同时传多个语言的文案，审批中心会根据用户当前的语音环境使用对应的文案，如果没有传用户当前的语音环境文案，则会使用默认的语言文案。</para>
            /// <para>必填：是</para>
            /// <para>示例值：@i18n@1</para>
            /// </summary>
            [JsonPropertyName("key")]
            public string Key { get; set; } = string.Empty;

            /// <summary>
            /// <para>文案内容</para>
            /// <para>必填：是</para>
            /// <para>示例值：people</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>是否为默认语言。默认语言需要包含所有 key，非默认语言如果 key 不存在会使用默认语言代替。</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_default")]
        public bool IsDefault { get; set; }
    }

    /// <summary>
    /// <para>审批流程管理员的用户 ID 列表。</para>
    /// <para>- ID 类型与查询参数 user_id_type 取值一致</para>
    /// <para>- 列表最大长度为 200</para>
    /// <para>必填：否</para>
    /// <para>示例值：["1c5ea995"]</para>
    /// </summary>
    [JsonPropertyName("process_manager_ids")]
    public string[]? ProcessManagerIds { get; set; }
}
