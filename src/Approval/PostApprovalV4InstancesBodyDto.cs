// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-09-18
// ************************************************************************
// <copyright file="PostApprovalV4InstancesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建审批实例 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval;
/// <summary>
/// 创建审批实例 请求体
/// <para>调用本接口使用指定审批定义 Code 创建一个审批实例，接口调用者需对审批定义的表单有详细了解，按照定义的表单结构，将表单 Value 通过本接口传入。</para>
/// <para>接口ID：7114621541589827587</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/instance/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2finstance%2fcreate</para>
/// </summary>
public record PostApprovalV4InstancesBodyDto
{
    /// <summary>
    /// <para>审批定义 Code。获取方式：</para>
    /// <para>- 调用[创建审批定义](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/approval/create)接口后，从响应参数 approval_code 获取。</para>
    /// <para>- 登录审批管理后台，在指定审批定义的 URL 中获取，具体操作参见[什么是 Approval Code](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/approval/overview-of-approval-resources#8151e0ae)。</para>
    /// <para>必填：是</para>
    /// <para>示例值：7C468A54-8745-2245-9675-08B7C63E7A85</para>
    /// </summary>
    [JsonPropertyName("approval_code")]
    public string ApprovalCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批发起人的 user_id，与 open_id 必须传入其中一个。如果传入了 user_id 则优先使用 user_id。获取方式参考[如何获取用户的 User ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)。</para>
    /// <para>必填：否</para>
    /// <para>示例值：f7cb567e</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; set; }

    /// <summary>
    /// <para>审批发起人的 open_id，与 user_id 必须传入其中一个。如果传入了 user_id 则优先使用 user_id。获取方式参考[如何获取用户的 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_3cda9c969f737aaa05e6915dce306cb9</para>
    /// </summary>
    [JsonPropertyName("open_id")]
    public string? OpenId { get; set; }

    /// <summary>
    /// <para>审批发起人所属部门 ID。如果用户只属于一个部门，可以不填。如果用户属于多个部门，不填值则默认选择部门列表第一个部门。获取方式参见[部门 ID](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/field-overview#9c02ed7a)。</para>
    /// <para>**说明**：</para>
    /// <para>- 不支持填写根部门。</para>
    /// <para>- 需填写 open_department_id 类型的部门 ID。</para>
    /// <para>必填：否</para>
    /// <para>示例值：9293493ccacbdb9a</para>
    /// </summary>
    [JsonPropertyName("department_id")]
    public string? DepartmentId { get; set; }

    /// <summary>
    /// <para>填写的审批表单控件值，JSON 数组，传值时需要压缩转义为字符串。各控件值的参数说明参考[审批实例表单控件参数](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/approval-instance-form-control-parameters)。</para>
    /// <para>必填：是</para>
    /// <para>示例值：[{\"id\":\"111\", \"type\": \"input\", \"value\":\"test\"}]</para>
    /// </summary>
    [JsonPropertyName("form")]
    public string Form { get; set; } = string.Empty;

    /// <summary>
    /// <para>如果审批定义的流程中，有节点需要发起人自选审批人，则需要通过本参数填写对应节点的审批人（通过用户 user_id 指定审批人）。</para>
    /// <para>**说明**：如果同时传入了 node_approver_user_id_list、node_approver_open_id_list，则取两个参数的并集生效审批人。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("node_approver_user_id_list")]
    public NodeApprover[]? NodeApproverUserIdLists { get; set; }

    /// <summary>
    /// <para>如果审批定义的流程中，有节点需要发起人自选审批人，则需要通过本参数填写对应节点的审批人（通过用户 user_id 指定审批人）。</para>
    /// <para>**说明**：如果同时传入了 node_approver_user_id_list、node_approver_open_id_list，则取两个参数的并集生效审批人。</para>
    /// </summary>
    public record NodeApprover
    {
        /// <summary>
        /// <para>节点的 node_id 或 custom_node_id，可调用 [查看指定审批定义](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/approval/get) 接口，从接口返回的 node_list 参数中获取。</para>
        /// <para>必填：否</para>
        /// <para>示例值：46e6d96cfa756980907209209ec03b64</para>
        /// </summary>
        [JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// <para>审批人列表，需传入用户 user_id。获取方式参考[如何获取用户的 User ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)。</para>
        /// <para>必填：否</para>
        /// <para>示例值：["f7cb567e"]</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string[]? Value { get; set; }
    }

    /// <summary>
    /// <para>如果审批定义的流程中，有节点需要发起人自选审批人，则需要通过本参数填写对应节点的审批人（通过用户 open_id 指定审批人）。</para>
    /// <para>**说明**：如果同时传入了 node_approver_user_id_list、node_approver_open_id_list，则取两个参数的并集生效审批人。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("node_approver_open_id_list")]
    public NodeApprover[]? NodeApproverOpenIdLists { get; set; }

    /// <summary>
    /// <para>如果审批定义的流程中，有节点需要发起人自选抄送人，则需要通过本参数填写对应节点的抄送人（通过用户 user_id 指定审批人）。</para>
    /// <para>**说明**：如果同时传入了 node_cc_user_id_list、node_cc_open_id_list，则取两个参数的并集生效抄送人。</para>
    /// <para>必填：否</para>
    /// <para>最大长度：20</para>
    /// </summary>
    [JsonPropertyName("node_cc_user_id_list")]
    public NodeCc[]? NodeCcUserIdLists { get; set; }

    /// <summary>
    /// <para>如果审批定义的流程中，有节点需要发起人自选抄送人，则需要通过本参数填写对应节点的抄送人（通过用户 user_id 指定审批人）。</para>
    /// <para>**说明**：如果同时传入了 node_cc_user_id_list、node_cc_open_id_list，则取两个参数的并集生效抄送人。</para>
    /// </summary>
    public record NodeCc
    {
        /// <summary>
        /// <para>节点的 node_id，可调用 [查看指定审批定义](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/approval/get) 接口，从接口返回的 node_list 参数中获取。</para>
        /// <para>必填：否</para>
        /// <para>示例值：46e6d96cfa756980907209209ec03b75</para>
        /// </summary>
        [JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// <para>抄送人列表，需传入用户 user_id。获取方式参考[如何获取用户的 User ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)。</para>
        /// <para>必填：否</para>
        /// <para>示例值：["f7cb567e"]</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string[]? Value { get; set; }
    }

    /// <summary>
    /// <para>如果审批定义的流程中，有节点需要发起人自选抄送人，则需要通过本参数填写对应节点的抄送人（通过用户 open_id 指定审批人）。</para>
    /// <para>**说明**：如果同时传入了 node_cc_user_id_list、node_cc_open_id_list，则取两个参数的并集生效抄送人。</para>
    /// <para>必填：否</para>
    /// <para>最大长度：20</para>
    /// </summary>
    [JsonPropertyName("node_cc_open_id_list")]
    public NodeCc[]? NodeCcOpenIdLists { get; set; }

    /// <summary>
    /// <para>审批实例 uuid，用于幂等操作，单个企业内的唯一 key。同一个 uuid 只能用于创建一个审批实例，如果冲突则创建失败并返回错误码 60012 ，格式建议为 XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX，不区分大小写。</para>
    /// <para>必填：否</para>
    /// <para>示例值：7C468A54-8745-2245-9675-08B7C63E7A87</para>
    /// <para>最大长度：64</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }

    /// <summary>
    /// <para>是否配置 **提交** 按钮，适用于任务的审批人退回审批单据后，审批提交人可以在同一个审批实例内点击 **提交**，提交单据。</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("allow_resubmit")]
    public bool? AllowResubmit { get; set; }

    /// <summary>
    /// <para>是否配置 **再次提交** 按钮，适用于周期性提单场景，按照当前表单内容再次发起一个新审批实例。</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("allow_submit_again")]
    public bool? AllowSubmitAgain { get; set; }

    /// <summary>
    /// <para>取消指定的 Bot 推送通知。可选值有：</para>
    /// <para>- 1：取消审批实例通过推送。</para>
    /// <para>- 2：取消审批实例拒绝推送。</para>
    /// <para>- 4：取消审批实例取消推送。</para>
    /// <para>支持同时取消多个 bot 推送通知。位运算，即如需取消 1 和 2 两种通知，则需要传入加和值 3。</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("cancel_bot_notification")]
    public string? CancelBotNotification { get; set; }

    /// <summary>
    /// <para>是否禁止撤销审批实例</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// <para>默认值：false</para>
    /// </summary>
    [JsonPropertyName("forbid_revoke")]
    public bool? ForbidRevoke { get; set; }

    /// <summary>
    /// <para>国际化文案。目前只支持为表单的单行、多行文本控件赋值。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("i18n_resources")]
    public I18nResource[]? I18nResources { get; set; }

    /// <summary>
    /// <para>国际化文案。目前只支持为表单的单行、多行文本控件赋值。</para>
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
            /// <para>示例值：@i18n@1</para>
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
    /// <para>审批实例的展示名称。如果填写了该参数，则审批列表中的审批名称使用该参数，如果不填该参数，则审批名称使用审批定义的名称。</para>
    /// <para>**说明**：这里传入的是国际化文案 Key（即 i18n_resources.texts 参数中的 Key），必须以 @i18n@ 开头，还需要在 i18n_resources.texts 参数中以 Key:Value 格式进行赋值。</para>
    /// <para>必填：否</para>
    /// <para>示例值：@i18n@1</para>
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// <para>审批详情页 title 展示模式。</para>
    /// <para>必填：否</para>
    /// <para>示例值：0</para>
    /// <para>可选值：<list type="bullet">
    /// <item>0：如果审批定义和审批实例都有 title，则全部展示，通过竖线分割。</item>
    /// <item>1：如果审批定义和审批实例都有 title，只展示审批实例的 title。</item>
    /// </list></para>
    /// <para>默认值：0</para>
    /// </summary>
    [JsonPropertyName("title_display_method")]
    public int? TitleDisplayMethod { get; set; }

    /// <summary>
    /// <para>设置自动通过的节点。</para>
    /// <para>必填：否</para>
    /// <para>最大长度：10</para>
    /// </summary>
    [JsonPropertyName("node_auto_approval_list")]
    public NodeAutoApproval[]? NodeAutoApprovalLists { get; set; }

    /// <summary>
    /// <para>设置自动通过的节点。</para>
    /// </summary>
    public record NodeAutoApproval
    {
        /// <summary>
        /// <para>节点 ID 类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：NON_CUSTOM</para>
        /// <para>可选值：<list type="bullet">
        /// <item>CUSTOM：自定义节点ID</item>
        /// <item>NON_CUSTOM：非自定义节点ID</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("node_id_type")]
        public string? NodeIdType { get; set; }

        /// <summary>
        /// <para>节点 ID 值，可调用 [查看指定审批定义](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/approval/get) 接口，从接口返回的 node_list 参数中获取。</para>
        /// <para>必填：否</para>
        /// <para>示例值：manager_node_id</para>
        /// </summary>
        [JsonPropertyName("node_id")]
        public string? NodeId { get; set; }
    }
}
