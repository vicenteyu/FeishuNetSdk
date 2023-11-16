namespace FeishuNetSdk.Approval;
/// <summary>
/// 查看指定三方审批定义 响应体
/// <para>根据 Approval Code 获取之前同步的某个三方审批定义的详情数据</para>
/// <para>接口ID：7255160068449828892</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/external_approval/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2fexternal_approval%2fget</para>
/// </summary>
public record GetApprovalV4ExternalApprovalsByApprovalCodeResponseDto
{
    /// <summary>
    /// <para>审批定义名称</para>
    /// <para>必填：是</para>
    /// <para>示例值：@i18n@1</para>
    /// </summary>
    [JsonPropertyName("approval_name")]
    public string ApprovalName { get; set; } = string.Empty;

    /// <summary>
    /// <para>创建三方审批定义时传入的定义code</para>
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
    /// <para>分组名称</para>
    /// <para>必填：否</para>
    /// <para>示例值：@i18n@2</para>
    /// </summary>
    [JsonPropertyName("group_name")]
    public string? GroupName { get; set; }

    /// <summary>
    /// <para>审批定义的说明</para>
    /// <para>必填：否</para>
    /// <para>示例值：@i18n@2</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// <para>三方审批定义相关</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("external")]
    public ApprovalCreateExternal? External { get; set; }

    /// <summary>
    /// <para>三方审批定义相关</para>
    /// </summary>
    public record ApprovalCreateExternal
    {
        /// <summary>
        /// <para>列表中用于提示审批来自哪里，i18n key， 注意不需要“来自”前缀，审批中心会拼上前缀</para>
        /// <para>必填：否</para>
        /// <para>示例值：@i18n@3</para>
        /// </summary>
        [JsonPropertyName("biz_name")]
        public string? BizName { get; set; }

        /// <summary>
        /// <para>审批定义业务类别</para>
        /// <para>必填：否</para>
        /// <para>示例值：permission</para>
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string? BizType { get; set; }

        /// <summary>
        /// <para>移动端发起链接，如果设置了该链接，则会在移动端审批发起页展示该审批，用户点击后会跳转到该链接进行发起； 如果不填，则在mobile端不显示该审批</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://applink.feishu.cn/client/mini_program/open?appId=cli_9c90fc38e07a9101&amp;path=pages/approval-form/index?id=9999</para>
        /// </summary>
        [JsonPropertyName("create_link_mobile")]
        public string? CreateLinkMobile { get; set; }

        /// <summary>
        /// <para>PC端发起链接，如果设置了该链接，则会在PC端审批发起页展示该审批，用户点击后会跳转到该链接进行发起； 如果不填，则在PC端不显示该审批</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://applink.feishu.cn/client/mini_program/open?mode=appCenter&amp;appId=cli_9c90fc38e07a9101&amp;path=pc/pages/create-form/index?id=9999</para>
        /// </summary>
        [JsonPropertyName("create_link_pc")]
        public string? CreateLinkPc { get; set; }

        /// <summary>
        /// <para>审批实例、审批任务、审批抄送是否要在PC端展示，如果为 true，则PC端列表会展示该定义下的实例信息；否则，不展示</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("support_pc")]
        public bool? SupportPc { get; set; }

        /// <summary>
        /// <para>审批实例、审批任务、审批抄送是否要在移动端展示，如果为 true，则移动端列表会展示该定义下的实例信息；否则，不展示</para>
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
        /// <para>三方系统的操作回调 url，【待审批】列表的任务审批人点同意或拒绝操作后，审批中心调用该地址通知三方系统，回调地址相关信息可参考：[三方快捷审批回调</para>
        /// <para>](https://open.feishu.cn/document/ukTMukTMukTM/ukjNyYjL5YjM24SO2IjN/quick-approval-callback)</para>
        /// <para>必填：否</para>
        /// <para>示例值：http://www.feishu.cn/approval/openapi/instanceOperate</para>
        /// </summary>
        [JsonPropertyName("action_callback_url")]
        public string? ActionCallbackUrl { get; set; }

        /// <summary>
        /// <para>回调时带的 token， 用于业务系统验证请求来自审批,具体参考: [回调token部分](https://open.feishu.cn/document/ukTMukTMukTM/uUTNz4SN1MjL1UzM)</para>
        /// <para>必填：否</para>
        /// <para>示例值：sdjkljkx9lsadf110</para>
        /// </summary>
        [JsonPropertyName("action_callback_token")]
        public string? ActionCallbackToken { get; set; }

        /// <summary>
        /// <para>请求参数加密密钥，如果配置了该参数，则会对请求参数进行加密，业务需要对请求进行解密，加解密算法参考:[加密部分](https://open.feishu.cn/document/ukTMukTMukTM/uADM4QjLwADO04CMwgDN)</para>
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
    /// <para>可见人列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("viewers")]
    public ApprovalCreateViewers[]? Viewers { get; set; }

    /// <summary>
    /// <para>可见人列表</para>
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
        /// <para>当 viewer_type 是 USER，根据user_id_type返回用户id</para>
        /// <para>必填：否</para>
        /// <para>示例值：19a294c2</para>
        /// </summary>
        [JsonPropertyName("viewer_user_id")]
        public string? ViewerUserId { get; set; }

        /// <summary>
        /// <para>当 view_type 为DEPARTMENT，根据department_id_type返回部门id</para>
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
        /// <para>文案 key, value, i18n key 以 @i18n@ 开头； 该字段主要用于做国际化，允许用户同时传多个语言的文案，审批中心会根据用户当前的语音环境使用对应的文案，如果没有传用户当前的语音环境文案，则会使用默认的语言文案</para>
        /// <para>必填：是</para>
        /// <para>示例值：{"@i18n@1":"权限申请","@i18n@2":"OA审批","@i18n@3":"Permission"}</para>
        /// </summary>
        [JsonPropertyName("texts")]
        public I18nResourceText[] Texts { get; set; } = Array.Empty<I18nResourceText>();

        /// <summary>
        /// <para>文案 key, value, i18n key 以 @i18n@ 开头； 该字段主要用于做国际化，允许用户同时传多个语言的文案，审批中心会根据用户当前的语音环境使用对应的文案，如果没有传用户当前的语音环境文案，则会使用默认的语言文案</para>
        /// </summary>
        public record I18nResourceText
        {
            /// <summary>
            /// <para>文案key</para>
            /// <para>必填：是</para>
            /// <para>示例值：@i18n@1</para>
            /// </summary>
            [JsonPropertyName("key")]
            public string Key { get; set; } = string.Empty;

            /// <summary>
            /// <para>文案value</para>
            /// <para>必填：是</para>
            /// <para>示例值：审批定义</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>是否默认语言，默认语言需要包含所有key，非默认语言如果key不存在会使用默认语言代替</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_default")]
        public bool IsDefault { get; set; }
    }

    /// <summary>
    /// <para>流程管理员</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("managers")]
    public string[]? Managers { get; set; }
}
