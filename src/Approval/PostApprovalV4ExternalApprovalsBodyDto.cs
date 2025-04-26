// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostApprovalV4ExternalApprovalsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建三方审批定义 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval;
/// <summary>
/// 创建三方审批定义 请求体
/// <para>三方审批定义用于设置审批的名称、描述等基本信息，同时还需要设置三方审批系统的审批发起页、数据回调 URL 等信息，将飞书审批与三方审批系统关联起来，使企业员工在飞书审批内即可直接发起三方审批，且审批中心可以将审批数据回传给三方审批系统。</para>
/// <para>## 注意事项</para>
/// <para>飞书审批中心不负责审批流程的流转，只负责审批的展示、状态操作、消息通知。因此，创建三方审批定义时，没有审批流程的参数配置项。</para>
/// <para>接口ID：7114621541589794819</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/external_approval/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2fexternal_approval%2fcreate</para>
/// </summary>
public record PostApprovalV4ExternalApprovalsBodyDto
{
    /// <summary>
    /// <para>三方审批定义名称。</para>
    /// <para>- 这里传入的是国际化文案 Key（即 i18n_resources.texts 参数中的 Key），还需要在 i18n_resources.texts 参数中以 Key:Value 格式进行赋值。</para>
    /// <para>- 该参数需要以 @i18n@ 开头，长度不得少于 9 个字符。</para>
    /// <para>必填：是</para>
    /// <para>示例值：@i18n@demoname</para>
    /// </summary>
    [JsonPropertyName("approval_name")]
    public string ApprovalName { get; set; } = string.Empty;

    /// <summary>
    /// <para>该值用于判断调用当前接口是创建审批定义还是更新审批定义。具体说明：</para>
    /// <para>- 如果传入的值系统可以匹配到已存在的审批定义 approval_code，则调用该接口会更新相应的审批定义。</para>
    /// <para>- 如果传入的值系统匹配不到任何审批定义 approval_code，则会新建一个审批定义，并返回新建的审批定义真实的 approval_code（并非通过该参数传入的值）。</para>
    /// <para>必填：是</para>
    /// <para>示例值：F46EB460-9476-4789-9524-ECD564291234</para>
    /// </summary>
    [JsonPropertyName("approval_code")]
    public string ApprovalCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批定义所属审批分组，用户自定义。具体说明：</para>
    /// <para>- 如果传入的 group_code 当前不存在，则会新建审批分组。</para>
    /// <para>- 如果 group_code 已经存在，则会使用 group_name 更新审批分组名称。</para>
    /// <para>必填：是</para>
    /// <para>示例值：work_group</para>
    /// </summary>
    [JsonPropertyName("group_code")]
    public string GroupCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批分组名称，审批发起页的审批定义分组名称来自该字段。具体说明：</para>
    /// <para>- 这里传入的是国际化文案 Key（即 i18n_resources.texts 参数中的 Key），还需要在 i18n_resources.texts 参数中以 Key:Value 格式进行赋值。</para>
    /// <para>- 该参数需要以 @i18n@ 开头。</para>
    /// <para>- 如果 group_code 当前不存在，则该 group_name 必填，表示新建审批分组时设置分组名称。</para>
    /// <para>- 如果 group_code 存在，则会更新分组名称，不填则不更新分组名称。</para>
    /// <para>必填：否</para>
    /// <para>示例值：@i18n@2</para>
    /// </summary>
    [JsonPropertyName("group_name")]
    public string? GroupName { get; set; }

    /// <summary>
    /// <para>审批定义的说明，后续企业员工发起审批时，该说明会在审批发起页展示。</para>
    /// <para>- 这里传入的是国际化文案 Key（即 i18n_resources.texts 参数中的 Key），还需要在 i18n_resources.texts 参数中以 Key:Value 格式进行赋值。</para>
    /// <para>- 该参数需要以 @i18n@ 开头。</para>
    /// <para>必填：否</para>
    /// <para>示例值：@i18n@2</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// <para>三方审批相关信息。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("external")]
    public ApprovalCreateExternal External { get; set; } = new();

    /// <summary>
    /// <para>三方审批相关信息。</para>
    /// </summary>
    public record ApprovalCreateExternal
    {
        /// <summary>
        /// <para>列表中用于提示审批来自哪个三方系统。</para>
        /// <para>**注意**：</para>
        /// <para>- 这里传入的是国际化文案 Key（即 i18n_resources.texts 参数中的 Key），还需要在 i18n_resources.texts 参数中以 Key:Value 格式进行赋值。</para>
        /// <para>- 该参数需要以 @i18n@ 开头。</para>
        /// <para>- 在 i18n_resources 中为该参数赋值时，无需设置 **来自** 前缀，审批中心默认会拼接 **来自** 前缀。</para>
        /// <para>必填：否</para>
        /// <para>示例值：@i18n@3</para>
        /// </summary>
        [JsonPropertyName("biz_name")]
        public string? BizName { get; set; }

        /// <summary>
        /// <para>审批定义业务类别，自定义设置。</para>
        /// <para>必填：否</para>
        /// <para>示例值：permission</para>
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string? BizType { get; set; }

        /// <summary>
        /// <para>移动端发起三方审批的链接。</para>
        /// <para>- 如果设置了该链接，则在移动端发起审批时，会跳转到该链接对应的三方审批发起页。</para>
        /// <para>- 如果不设置该链接，则在移动端不显示该审批。</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://applink.feishu.cn/client/mini_program/open?appId=cli_9c90fc38e07a9101&amp;path=pages/approval-form/index?id=9999</para>
        /// </summary>
        [JsonPropertyName("create_link_mobile")]
        public string? CreateLinkMobile { get; set; }

        /// <summary>
        /// <para>PC端发起三方审批的链接。</para>
        /// <para>- 如果设置了该链接，则在 PC 端发起审批时，会跳转到该链接对应的三方审批发起页。</para>
        /// <para>- 如果不设置该链接，则在 PC 端不显示该审批。</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://applink.feishu.cn/client/mini_program/open?mode=appCenter&amp;appId=cli_9c90fc38e07a9101&amp;path=pc/pages/create-form/index?id=9999</para>
        /// </summary>
        [JsonPropertyName("create_link_pc")]
        public string? CreateLinkPc { get; set; }

        /// <summary>
        /// <para>审批定义是否要在 PC 端的发起审批页面展示，如果为 true 则展示，否则不展示。</para>
        /// <para>**注意**：support_pc 和 support_mobile 不可都为 false。</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("support_pc")]
        public bool? SupportPc { get; set; }

        /// <summary>
        /// <para>审批定义是否要在移动端的发起审批页面展示，如果为 true 则展示，否则不展示。</para>
        /// <para>**注意**：support_pc 和 support_mobile 不可都为 false。</para>
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
        /// <para>**注意**：该字段无效，暂不支持使用。</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("enable_mark_readed")]
        public bool? EnableMarkReaded { get; set; }

        /// <summary>
        /// <para>是否支持快速操作</para>
        /// <para>**注意**：该字段无效，暂不支持使用。</para>
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
        /// <para>是否支持批量审批。取值为 true 时，审批人在处理该定义下的审批任务时可以批量处理多个任务。</para>
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
    /// <para>审批可见人列表，列表长度上限 200，只有在审批可见人列表内的用户，才可以在审批发起页看到该审批。若该参数不传值，则表示任何人不可见。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("viewers")]
    public ApprovalCreateViewers[]? Viewers { get; set; }

    /// <summary>
    /// <para>审批可见人列表，列表长度上限 200，只有在审批可见人列表内的用户，才可以在审批发起页看到该审批。若该参数不传值，则表示任何人不可见。</para>
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
        /// <para>当 viewer_type 取值为 USER 时，需指定用户 ID。ID 类型与查询参数 user_id_type 取值保持一致。</para>
        /// <para>必填：否</para>
        /// <para>示例值：19a294c2</para>
        /// </summary>
        [JsonPropertyName("viewer_user_id")]
        public string? ViewerUserId { get; set; }

        /// <summary>
        /// <para>当 view_type 取值为 DEPARTMENT 时，需指定部门 ID。ID 类型与查询参数 department_id_type 取值保持一致。</para>
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
        /// <para>文案的 Key:Value。Key 需要以 @i18n@ 开头，并按照各个参数的要求传入 Value。</para>
        /// <para>**说明**：该字段主要用于适配国际化，允许同时设置多个语言的文案，审批中心会根据实际用户当前的语音环境使用匹配的文案。如果没有设置用户当前的语音环境文案，则会使用默认的语言文案。</para>
        /// <para>必填：是</para>
        /// <para>示例值：{ "@i18n@1": "权限申请", "@i18n@2": "OA审批", "@i18n@3": "Permission" }</para>
        /// </summary>
        [JsonPropertyName("texts")]
        public I18nResourceText[] Texts { get; set; } = Array.Empty<I18nResourceText>();

        /// <summary>
        /// <para>文案的 Key:Value。Key 需要以 @i18n@ 开头，并按照各个参数的要求传入 Value。</para>
        /// <para>**说明**：该字段主要用于适配国际化，允许同时设置多个语言的文案，审批中心会根据实际用户当前的语音环境使用匹配的文案。如果没有设置用户当前的语音环境文案，则会使用默认的语言文案。</para>
        /// </summary>
        public record I18nResourceText
        {
            /// <summary>
            /// <para>文案 Key，需要和各个参数 Key 相匹配。</para>
            /// <para>必填：是</para>
            /// <para>示例值：@i18n@2</para>
            /// </summary>
            [JsonPropertyName("key")]
            public string Key { get; set; } = string.Empty;

            /// <summary>
            /// <para>文案 Value，即文案 Key 对应的参数值。</para>
            /// <para>必填：是</para>
            /// <para>示例值：people</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>是否为默认语言。默认语言需要包含所有所需的文案 Key，非默认语言如果 Key 不存在，则会使用默认语言代替。</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_default")]
        public bool IsDefault { get; set; }
    }

    /// <summary>
    /// <para>设置审批流程管理员的用户 ID，最多支持设置 200 个。ID 类型与查询参数 user_id_type 取值一致。</para>
    /// <para>必填：否</para>
    /// <para>示例值：19a294c2</para>
    /// </summary>
    [JsonPropertyName("managers")]
    public string[]? Managers { get; set; }
}
