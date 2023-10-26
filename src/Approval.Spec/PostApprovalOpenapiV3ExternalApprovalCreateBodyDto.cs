using Newtonsoft.Json;
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 三方审批定义创建 请求体
/// <para>为了更好地提升接口文档的的易理解性，我们对文档进行了升级，请尽快迁移至[新版本&gt;&gt;](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/external_approval/create)审批定义是审批的描述，包括审批名称、图标、描述等基础信息。创建好审批定义，用户就可以在审批应用的发起页中看到审批，如果用户点击发起，则会跳转到配置的发起三方系统地址去发起审批。</para>
/// <para>另外，审批定义还配置了审批操作时的回调地址：审批人在待审批列表中进行【同意】【拒绝】操作时，审批中心会调用回调地址通知三方系统。</para>
/// <para>注意，审批中心不负责审批流程的流转，只负责展示、操作、消息通知。因此审批定义创建时没有审批流程的信息。</para>
/// <para>接口ID：6907569744329883649</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/approval/v2/third-party-approval-integration/external-approval-create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuIDNyYjLyQjM24iM0IjN</para>
/// </summary>
public record PostApprovalOpenapiV3ExternalApprovalCreateBodyDto
{
    /// <summary>
    /// <para>审批定义名称， 创建审批定义返回的值，表示该实例属于哪个流程；该字段会影响到列表中该实例的标题，标题取自对应定义的 name 字段。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("approval_name")]
    public string ApprovalName { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批定义 code，用户自定义，定义的唯一标识，如果不存在该 code，则创建，否则更新</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("approval_code")]
    public string ApprovalCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批定义所属审批分组，用户自定义；</para>
    /// <para>如果group_code当前不存在，则会新建审批分组；</para>
    /// <para>如果group_code已经存在，则会使用group_name更新审批分组名称</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("group_code")]
    public string GroupCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>分组名称，值的格式是 i18n key，文案放在 i18n_resource；</para>
    /// <para>如果是 group_code 当前不存在，则该 group_name 必填，否则，如果填写了则会更新分组名称，不填则不更新分组名称；</para>
    /// <para>审批发起页 审批定义的分组名称来自该字段</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("group_name")]
    public string? GroupName { get; set; }

    /// <summary>
    /// <para>审批定义的说明，值的格式是 i18n key，文案放在 i18n_resource；</para>
    /// <para>审批发起页 审批定义的说明内容来自该字段</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("description")]
    public string? Description { get; set; }

    /// <summary>
    /// <para>三方审批相关</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("external")]
    public ExternalSuffix External { get; set; } = new();

    /// <summary></summary>
    public record ExternalSuffix
    {
        /// <summary>
        /// <para>列表中用于提示审批来自哪里，i18n key， 注意不需要“来自”前缀，审批中心会拼上前缀</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("biz_name")]
        public string? BizName { get; set; }

        /// <summary>
        /// <para>审批定义业务类别</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("biz_type")]
        public string? BizType { get; set; }

        /// <summary>
        /// <para>移动端发起链接，如果设置了该链接，则会在移动端审批发起页展示该审批，用户点击后会跳转到该链接进行发起；</para>
        /// <para>如果不填，则在mobile端不显示该审批</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("create_link_mobile")]
        public string CreateLinkMobile { get; set; } = string.Empty;

        /// <summary>
        /// <para>PC端发起链接，如果设置了该链接，则会在PC端审批发起页展示该审批，用户点击后会跳转到该链接进行发起；</para>
        /// <para>如果不填，则在PC端不显示该审批；</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("create_link_pc")]
        public string? CreateLinkPc { get; set; }

        /// <summary>
        /// <para>审批实例、审批任务、审批抄送是否要在PC端展示，如果为 true，则PC端列表会展示该定义下的实例信息，否则，不展示</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("support_pc")]
        public bool? SupportPc { get; set; }

        /// <summary>
        /// <para>审批实例、审批任务、审批抄送是否要在移动端展示，如果为 true，则移动端列表会展示该定义下的实例信息，否则，不展示；</para>
        /// <para>support_pc和support_mobile不可都为false，否则不展示</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("support_mobile")]
        public bool? SupportMobile { get; set; }

        /// <summary>
        /// <para>是否支持批量已读</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("support_batch_read")]
        public bool? SupportBatchRead { get; set; }

        /// <summary>
        /// <para>是否支持标注可读</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("enable_mark_readed")]
        public bool? EnableMarkReaded { get; set; }

        /// <summary>
        /// <para>是否支持快速操作</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("enable_quick_operate")]
        public bool? EnableQuickOperate { get; set; }

        /// <summary>
        /// <para>是否支持批量审批</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("allow_batch_operate")]
        public bool? AllowBatchOperate { get; set; }

        /// <summary>
        /// <para>三方系统的操作回调 url，【待审批】列表的任务审批人点同意或拒绝操作后，审批中心调用该地址通知三方系统，回调地址相关信息可参见：https://open.feishu.cn/document/ukTMukTMukTM/ukjNyYjL5YjM24SO2IjN/quick-approval-callback</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("action_callback_url")]
        public string? ActionCallbackUrl { get; set; }

        /// <summary>
        /// <para>回调时带的 token， 用于业务系统验证请求来自审批,具体参考 [开放平台文档](https://open.feishu.cn/document/ukTMukTMukTM/uUTNz4SN1MjL1UzM)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("action_callback_token")]
        public string? ActionCallbackToken { get; set; }

        /// <summary>
        /// <para>请求参数加密密钥，如果配置了该参数，则会对请求参数进行加密，业务需要对请求进行解密，加解密算法参考[关联外部选项说明](https://open.feishu.cn/document/ukTMukTMukTM/uADM4QjLwADO04CMwgDN)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("action_callback_key")]
        public string? ActionCallbackKey { get; set; }
    }

    /// <summary>
    /// <para>可见人列表，可通知配置多个可见人，只有在配置的范围内用户可以在审批发起也看到该审批，默认不传，则是任何人不可见</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("viewers")]
    public Viewer[]? Viewers { get; set; }

    /// <summary></summary>
    public record Viewer
    {
        /// <summary>
        /// <para>可见人类型</para>
        /// <para>**可选值有：**</para>
        /// <para>- `TENANT`：租户内可见</para>
        /// <para>- `DEPARTMENT`：指定部门</para>
        /// <para>- `USER`：指定用户</para>
        /// <para>- `NONE`：任何人都不可见</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("viewer_type")]
        public string? ViewerType { get; set; }

        /// <summary>
        /// <para>可见人 ID，如果 view_type 是 TENANT 和 NONE, viewer_id 可为空;</para>
        /// <para>如果 view_type 为DEPARTMENT，viewer_id 是 open_department_id;</para>
        /// <para>如果 view_type 是 USER，viewer_id 为 user_id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("viewer_id")]
        public string? ViewerId { get; set; }
    }

    /// <summary>
    /// <para>国际化文案</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("i18n_resources")]
    public I18nResource[] I18nResources { get; set; } = Array.Empty<I18nResource>();

    /// <summary></summary>
    public record I18nResource
    {
        /// <summary>
        /// <para>语言</para>
        /// <para>**可选值有：**</para>
        /// <para>- `zh-CN`：中文</para>
        /// <para>- `en-US`：英文</para>
        /// <para>- `ja-JP`：日文</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("locale")]
        public string Locale { get; set; } = string.Empty;

        /// <summary>
        /// <para>是否默认语言，默认语言需要包含所有key，非默认语言如果key不存在会使用默认语言代替</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("is_default")]
        public bool IsDefault { get; set; }

        /// <summary>
        /// <para>文案 key, value, i18n key 以 **@i18n@** 开头；</para>
        /// <para>该字段主要用于做国际化，允许用户同时传多个语言的文案，审批中心会根据用户当前的语音环境使用对应的文案，如果没有传用户当前的语音环境文案，则会使用默认的语言文案。</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("texts")]
        public object Texts { get; set; } = new();
    }
}
