using Newtonsoft.Json;
namespace FeishuNetSdk.Approval;
/// <summary>
/// 创建审批定义 请求体
/// <para>用于通过接口创建简单的审批定义，可以灵活指定定义的基础信息、表单和流程等。创建成功后，不支持从审批管理后台删除该定义。不推荐企业自建应用使用，如有需要尽量联系管理员在审批管理后台创建定义。</para>
/// <para>接口ID：7114621541589712899</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/approval/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2fapproval%2fcreate</para>
/// </summary>
public record PostApprovalV4ApprovalsBodyDto
{
    /// <summary>
    /// <para>审批名称的国际化文案 Key，以 @i18n@ 开头，长度不得少于 9 个字符</para>
    /// <para>必填：是</para>
    /// <para>示例值：@i18n@approval_name</para>
    /// </summary>
    [JsonProperty("approval_name")]
    public string ApprovalName { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批定义 Code。不传值表示新建；传入指定 Code 表示覆盖原定义内容进行全量更新</para>
    /// <para>必填：否</para>
    /// <para>示例值：7C468A54-8745-2245-9675-08B7C63E7A85</para>
    /// </summary>
    [JsonProperty("approval_code")]
    public string? ApprovalCode { get; set; }

    /// <summary>
    /// <para>审批描述的国际化文案 Key，以 @i18n@ 开头，长度不得少于 9 个字符</para>
    /// <para>必填：否</para>
    /// <para>示例值：@i18n@description</para>
    /// </summary>
    [JsonProperty("description")]
    public string? Description { get; set; }

    /// <summary>
    /// <para>viewers 字段指定了哪些人能从审批应用的前台发起该审批。</para>
    /// <para>1. 当 viewer_type 为 USER，需要填写viewer_user_id；</para>
    /// <para>2. 当 viewer_type 为DEPARTMENT，需要填写viewer_department_id；</para>
    /// <para>3. 当 viewer_type 为TENANT或NONE时，viewer_user_id和viewer_department_id无需填写</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("viewers")]
    public ApprovalCreateViewers[] Viewers { get; set; } = Array.Empty<ApprovalCreateViewers>();

    /// <summary>
    /// <para>viewers 字段指定了哪些人能从审批应用的前台发起该审批。</para>
    /// <para>1. 当 viewer_type 为 USER，需要填写viewer_user_id；</para>
    /// <para>2. 当 viewer_type 为DEPARTMENT，需要填写viewer_department_id；</para>
    /// <para>3. 当 viewer_type 为TENANT或NONE时，viewer_user_id和viewer_department_id无需填写</para>
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
        [JsonProperty("viewer_type")]
        public string? ViewerType { get; set; }

        /// <summary>
        /// <para>当 viewer_type 是 USER，根据user_id_type填写用户id</para>
        /// <para>必填：否</para>
        /// <para>示例值：19a294c2</para>
        /// </summary>
        [JsonProperty("viewer_user_id")]
        public string? ViewerUserId { get; set; }

        /// <summary>
        /// <para>当 viewer_type 为DEPARTMENT，根据department_id_type填写部门id</para>
        /// <para>必填：否</para>
        /// <para>示例值：od-ac9d697abfa990b715dcc33d58a62a9d</para>
        /// </summary>
        [JsonProperty("viewer_department_id")]
        public string? ViewerDepartmentId { get; set; }
    }

    /// <summary>
    /// <para>审批定义表单</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("form")]
    public ApprovalForm Form { get; set; } = new();

    /// <summary>
    /// <para>审批定义表单</para>
    /// </summary>
    public record ApprovalForm
    {
        /// <summary>
        /// <para>审批定义表单，json 数组，见下方form_content字段说明</para>
        /// <para>必填：是</para>
        /// <para>示例值：[{\"id\":\"user_name\", \"type\": \"input\", \"required\":true, \"name\":\"@i18n@widget1\"}]</para>
        /// </summary>
        [JsonProperty("form_content")]
        public string FormContent { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>审批定义节点，需要将开始节点作为 list 第一个元素，结束节点作为最后一个元素</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("node_list")]
    public ApprovalNode[] NodeLists { get; set; } = Array.Empty<ApprovalNode>();

    /// <summary>
    /// <para>审批定义节点，需要将开始节点作为 list 第一个元素，结束节点作为最后一个元素</para>
    /// </summary>
    public record ApprovalNode
    {
        /// <summary>
        /// <para>节点 ID，开始节点的 ID 为 START，结束节点的 ID 为 END，开始和结束节点不需要指定 name、node_type 以及 approver</para>
        /// <para>必填：是</para>
        /// <para>示例值：START</para>
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>节点名称的国际化文案 Key，以 @i18n@ 开头，长度不得少于 9 个字符</para>
        /// <para>必填：否</para>
        /// <para>示例值：@i18n@node_name</para>
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>审批类型枚举,当 node_type 为依次审批时，审批人必须为『发起人自选』</para>
        /// <para>必填：否</para>
        /// <para>示例值：AND</para>
        /// <para>可选值：<list type="bullet">
        /// <item>AND：会签</item>
        /// <item>OR：或签</item>
        /// <item>SEQUENTIAL：依次审批</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("node_type")]
        public string? NodeType { get; set; }

        /// <summary>
        /// <para>审批人列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("approver")]
        public ApprovalApproverCcer[]? Approvers { get; set; }

        /// <summary>
        /// <para>审批人列表</para>
        /// </summary>
        public record ApprovalApproverCcer
        {
            /// <summary>
            /// <para>审批/抄送人类型，</para>
            /// <para>1. 当 type 为 Supervisor、SupervisorTopDown、DepartmentManager 、DepartmentManagerTopDown 这 4 种时，需要在 level 中填写对应的级数，例如：由下往上三级主管审批，level = 3；</para>
            /// <para>2. 当 type 为 Personal 时，需要填写对应的user_id ，用于指定用户；</para>
            /// <para>3. 当 approver 为 Free 发起人自选时，不需要指定 user_id 和level；</para>
            /// <para>4. ccer不支持 Free 发起人自选</para>
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
            [JsonProperty("type")]
            public string Type { get; set; } = string.Empty;

            /// <summary>
            /// <para>用户id，根据user_id_type填写</para>
            /// <para>必填：否</para>
            /// <para>示例值：f7cb567e</para>
            /// </summary>
            [JsonProperty("user_id")]
            public string? UserId { get; set; }

            /// <summary>
            /// <para>审批级数，当 type 为 Supervisor、SupervisorTopDown、DepartmentManager 、DepartmentManagerTopDown 这 4 种时，需要在 level 中填写对应的级数，例如：由下往上三级主管审批，level = 3</para>
            /// <para>必填：否</para>
            /// <para>示例值：3</para>
            /// </summary>
            [JsonProperty("level")]
            public string? Level { get; set; }
        }

        /// <summary>
        /// <para>抄送人列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("ccer")]
        public ApprovalApproverCcer[]? Ccers { get; set; }

        /// <summary>
        /// <para>表单项的控件权限</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("privilege_field")]
        public FieldGroup? PrivilegeField { get; set; }

        /// <summary>
        /// <para>表单项的控件权限</para>
        /// </summary>
        public record FieldGroup
        {
            /// <summary>
            /// <para>可写权限的表单项的 id列表</para>
            /// <para>必填：是</para>
            /// <para>示例值：9293493</para>
            /// </summary>
            [JsonProperty("writable")]
            public string[] Writable { get; set; } = Array.Empty<string>();

            /// <summary>
            /// <para>可读权限的表单项的 id列表</para>
            /// <para>必填：是</para>
            /// <para>示例值：9293493</para>
            /// </summary>
            [JsonProperty("readable")]
            public string[] Readable { get; set; } = Array.Empty<string>();
        }

        /// <summary>
        /// <para>自选审批人是否允许多选</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonProperty("approver_chosen_multi")]
        public bool? ApproverChosenMulti { get; set; }

        /// <summary>
        /// <para>自选审批人选择范围</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("approver_chosen_range")]
        public ApproverRange[]? ApproverChosenRanges { get; set; }

        /// <summary>
        /// <para>自选审批人选择范围</para>
        /// </summary>
        public record ApproverRange
        {
            /// <summary>
            /// <para>审批人类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：ALL</para>
            /// <para>可选值：<list type="bullet">
            /// <item>ALL：全租户</item>
            /// <item>PERSONAL：指定审批人</item>
            /// <item>ROLE：指定角色</item>
            /// </list></para>
            /// </summary>
            [JsonProperty("type")]
            public string? Type { get; set; }

            /// <summary>
            /// <para>审批人id</para>
            /// <para>必填：否</para>
            /// <para>示例值：f7cb567e</para>
            /// </summary>
            [JsonProperty("id_list")]
            public string[]? IdList { get; set; }
        }

        /// <summary>
        /// <para>审批人为提交人时的操作</para>
        /// <para>必填：否</para>
        /// <para>示例值：STARTER</para>
        /// <para>可选值：<list type="bullet">
        /// <item>STARTER：发起人本人审批</item>
        /// <item>AUTO_PASS：自动通过</item>
        /// <item>SUPERVISOR：直属上级审批</item>
        /// <item>DEPARTMENT_MANAGER：直属部门负责人审批</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("starter_assignee")]
        public string? StarterAssignee { get; set; }
    }

    /// <summary>
    /// <para>审批定义其他设置</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("settings")]
    public ApprovalSetting? Settings { get; set; }

    /// <summary>
    /// <para>审批定义其他设置</para>
    /// </summary>
    public record ApprovalSetting
    {
        /// <summary>
        /// <para>审批实例通过后允许撤回的时间，以秒为单位，默认 31 天，0 为不可撤回</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonProperty("revert_interval")]
        public int? RevertInterval { get; set; }

        /// <summary>
        /// <para>是否支持审批通过第一个节点后撤回，默认为1，0为不支持</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonProperty("revert_option")]
        public int? RevertOption { get; set; }

        /// <summary>
        /// <para>拒绝设置</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：默认设置，流程被终止</item>
        /// <item>1：退回至发起人，发起人可编辑流程后重新提交</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("reject_option")]
        public int? RejectOption { get; set; }

        /// <summary>
        /// <para>快捷审批配置项，开启后可在卡片上直接审批。默认值1为启用， 0为禁用</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：禁用</item>
        /// <item>1：启用</item>
        /// </list></para>
        /// <para>默认值：1</para>
        /// </summary>
        [JsonProperty("quick_approval_option")]
        public int? QuickApprovalOption { get; set; }
    }

    /// <summary>
    /// <para>审批定义配置项，用于配置对应审批定义是否可以由用户在审批后台进行修改</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("config")]
    public ApprovalConfig? Config { get; set; }

    /// <summary>
    /// <para>审批定义配置项，用于配置对应审批定义是否可以由用户在审批后台进行修改</para>
    /// </summary>
    public record ApprovalConfig
    {
        /// <summary>
        /// <para>允许用户修改可见范围</para>
        /// <para>必填：是</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonProperty("can_update_viewer")]
        public bool CanUpdateViewer { get; set; }

        /// <summary>
        /// <para>允许用户更新表单</para>
        /// <para>必填：是</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonProperty("can_update_form")]
        public bool CanUpdateForm { get; set; }

        /// <summary>
        /// <para>允许用户更新流程定义</para>
        /// <para>必填：是</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonProperty("can_update_process")]
        public bool CanUpdateProcess { get; set; }

        /// <summary>
        /// <para>允许用户更新撤回设置</para>
        /// <para>必填：是</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonProperty("can_update_revert")]
        public bool CanUpdateRevert { get; set; }

        /// <summary>
        /// <para>帮助文档链接</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://xxx.xxx.xxx</para>
        /// </summary>
        [JsonProperty("help_url")]
        public string? HelpUrl { get; set; }
    }

    /// <summary>
    /// <para>审批图标枚举，详见下方说明，默认为 0</para>
    /// <para>必填：否</para>
    /// <para>示例值：0</para>
    /// <para>默认值：0</para>
    /// </summary>
    [JsonProperty("icon")]
    public int? Icon { get; set; }

    /// <summary>
    /// <para>国际化文案</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("i18n_resources")]
    public I18nResource[] I18nResources { get; set; } = Array.Empty<I18nResource>();

    /// <summary>
    /// <para>国际化文案</para>
    /// </summary>
    public record I18nResource
    {
        /// <summary>
        /// <para>语言可选值有： zh-CN：中文 en-US：英文 ja-JP：日文</para>
        /// <para>必填：是</para>
        /// <para>示例值：zh-CN</para>
        /// <para>可选值：<list type="bullet">
        /// <item>zh-CN：中文</item>
        /// <item>en-US：英文</item>
        /// <item>ja-JP：日文</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("locale")]
        public string Locale { get; set; } = string.Empty;

        /// <summary>
        /// <para>文案 key, value, i18n key 以 @i18n@ 开头； 该字段主要用于做国际化，允许用户同时传多个语言的文案，审批中心会根据用户当前的语音环境使用对应的文案，如果没有传用户当前的语音环境文案，则会使用默认的语言文案。</para>
        /// <para>必填：是</para>
        /// <para>示例值：{ "@i18n@1": "权限申请", "@i18n@2": "OA审批", "@i18n@3": "Permission" }</para>
        /// </summary>
        [JsonProperty("texts")]
        public I18nResourceText[] Texts { get; set; } = Array.Empty<I18nResourceText>();

        /// <summary>
        /// <para>文案 key, value, i18n key 以 @i18n@ 开头； 该字段主要用于做国际化，允许用户同时传多个语言的文案，审批中心会根据用户当前的语音环境使用对应的文案，如果没有传用户当前的语音环境文案，则会使用默认的语言文案。</para>
        /// </summary>
        public record I18nResourceText
        {
            /// <summary>
            /// <para>文案key</para>
            /// <para>必填：是</para>
            /// <para>示例值：@i18n@1</para>
            /// </summary>
            [JsonProperty("key")]
            public string Key { get; set; } = string.Empty;

            /// <summary>
            /// <para>文案</para>
            /// <para>必填：是</para>
            /// <para>示例值：people</para>
            /// </summary>
            [JsonProperty("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>是否默认语言，默认语言需要包含所有key，非默认语言如果key不存在会使用默认语言代替</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonProperty("is_default")]
        public bool IsDefault { get; set; }
    }

    /// <summary>
    /// <para>根据user_id_type填写流程管理员的用户id</para>
    /// <para>必填：否</para>
    /// <para>示例值：["1c5ea995"]</para>
    /// </summary>
    [JsonProperty("process_manager_ids")]
    public string[]? ProcessManagerIds { get; set; }
}
