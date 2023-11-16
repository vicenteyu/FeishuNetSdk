namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 创建审批定义 请求体
/// <para>为了更好地提升接口文档的的易理解性，我们对文档进行了升级，请尽快迁移至[新版本&gt;&gt;](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/approval/create)用于通过接口创建简单的审批定义，可以灵活指定定义的基础信息、表单和流程等。创建成功后，不支持从审批管理后台删除该定义。不推荐企业自建应用使用，如有需要尽量联系管理员在审批管理后台创建定义。</para>
/// <para>接口谨慎调用，创建后的审批定义无法停用/删除</para>
/// <para>接口ID：6907569743420686338</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/approval/v2/feishu-store-app-integration/create-an-approval-definition</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUzNyYjL1cjM24SN3IjN</para>
/// </summary>
public record PostApprovalOpenapiV2ApprovalCreateBodyDto
{
    /// <summary>
    /// <para>审批名称的国际化文案 Key，以 @i18n@ 开头，长度不得少于 9 个字符</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("approval_name")]
    public string ApprovalName { get; set; } = string.Empty;

    /// <summary>
    /// <para>传空表示新建</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("approval_code")]
    public string? ApprovalCode { get; set; }

    /// <summary>
    /// <para>审批描述的国际化文案 Key，以 @i18n@ 开头，长度不得少于 9 个字符</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// <para>审批前台可见人范围，详见下方说明</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("viewers")]
    public Viewer[] Viewers { get; set; } = Array.Empty<Viewer>();

    /// <summary></summary>
    public record Viewer
    {
        /// <summary></summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary></summary>
        [JsonPropertyName("open_id")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary></summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>审批定义表单</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("form")]
    public FormSuffix Form { get; set; } = new();

    /// <summary></summary>
    public record FormSuffix
    {
        /// <summary>
        /// <para>审批定义表单内容，json 数组，详见下方说明</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("form_content")]
        public string FormContent { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>审批定义节点，map 数组，需要将开始节点作为 list 第一个元素，结束节点作为最后一个元素</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("node_list")]
    public Node[] NodeList { get; set; } = Array.Empty<Node>();

    /// <summary></summary>
    public record Node
    {
        /// <summary>
        /// <para>节点 ID，开始节点的 ID 为 START，结束节点的 ID 为 END，开始和结束节点不需要指定 name、node_type 以及 approver</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>节点名称的国际化文案 Key，以 @i18n@ 开头，长度不得少于 9 个字符</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>审批类型枚举</para>
        /// <para>- AND 会签</para>
        /// <para>- OR 或签</para>
        /// <para>- SEQUENTIAL 依次审批</para>
        /// <para>当 node_type 为依次审批时，审批人必须为『发起人自选』</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("node_type")]
        public string NodeType { get; set; } = string.Empty;

        /// <summary>
        /// <para>审批人列表，详见下方说明</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("approver")]
        public Viewer[] Approver { get; set; } = Array.Empty<Viewer>();

        /// <summary>
        /// <para>抄送人列表，详见下方说明</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("ccer")]
        public Viewer[]? Ccer { get; set; }
    }

    /// <summary>
    /// <para>审批定义其他设置</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("settings")]
    public Setting? Settings { get; set; }

    /// <summary></summary>
    public record Setting
    {
        /// <summary>
        /// <para>审批实例通过后允许撤回的时间，以秒为单位，默认 31 天，0 为不可撤回</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("revert_interval")]
        public int? RevertInterval { get; set; }

        /// <summary>
        /// <para>是否支持审批通过第一个节点后撤回，默认为1，0为不支持</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("revert_option")]
        public int? RevertOption { get; set; }
    }

    /// <summary>
    /// <para>审批定义配置项，用于配置对应审批定义是否可以由用户在审批后台进行修改</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("config")]
    public ConfigSuffix? Config { get; set; }

    /// <summary></summary>
    public record ConfigSuffix
    {
        /// <summary>
        /// <para>是否可以修改可见范围，默认 false</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("can_update_viewer")]
        public bool? CanUpdateViewer { get; set; }

        /// <summary>
        /// <para>是否可以修改表单内容，默认 false</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("can_update_form")]
        public bool? CanUpdateForm { get; set; }

        /// <summary>
        /// <para>是否可以修改流程节点，默认 false</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("can_update_process")]
        public bool? CanUpdateProcess { get; set; }

        /// <summary>
        /// <para>是否可以修改撤回时间，默认 false</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("can_update_revert")]
        public bool? CanUpdateRevert { get; set; }

        /// <summary>
        /// <para>用于配置帮助页链接，可以从审批后台跳转到该链接页面</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("help_url")]
        public string? HelpUrl { get; set; }
    }

    /// <summary>
    /// <para>审批图标枚举，详见下方说明，默认为 0</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("icon")]
    public int? Icon { get; set; }

    /// <summary>
    /// <para>国际化文案</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("i18n_resources")]
    public I18nResource[] I18nResources { get; set; } = Array.Empty<I18nResource>();

    /// <summary></summary>
    public record I18nResource
    {
        /// <summary>
        /// <para>语言：</para>
        /// <para>zh-CN - 中文</para>
        /// <para>en-US - 英文</para>
        /// <para>ja-JP - 日文</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("locale")]
        public string Locale { get; set; } = string.Empty;

        /// <summary>
        /// <para>是否默认语言，默认语言需要包含所有 key，非默认语言如果 key 不存在会使用默认语言代替</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("is_default")]
        public bool IsDefault { get; set; }

        /// <summary>
        /// <para>文案 key, value, i18n key 以 @i18n@ 开头</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("texts")]
        public object Texts { get; set; } = new();

        /// <summary></summary>
        public record Text
        {
            /// <summary>
            /// 审批名称
            /// </summary>
            [JsonPropertyName("@i18n@approval_name")]
            public string ApprovalName { get; set; } = string.Empty;

            /// <summary>
            /// 审批描述
            /// </summary>
            [JsonPropertyName("@i18n@description")]
            public string Description { get; set; } = string.Empty;

            /// <summary>
            /// 控件1
            /// </summary>
            [JsonPropertyName("@i18n@widget1")]
            public string Widget1 { get; set; } = string.Empty;

            /// <summary>
            /// 节点名称
            /// </summary>
            [JsonPropertyName("@i18n@node_name")]
            public string NodeName { get; set; } = string.Empty;
        }
    }
}
