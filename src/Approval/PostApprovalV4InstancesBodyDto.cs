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
/// <para>创建一个审批实例，调用方需对审批定义的表单有详细了解，将按照定义的表单结构，将表单 Value 通过接口传入。</para>
/// <para>接口ID：7114621541589827587</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/instance/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2finstance%2fcreate</para>
/// </summary>
public record PostApprovalV4InstancesBodyDto
{
    /// <summary>
    /// <para>审批定义 code</para>
    /// <para>必填：是</para>
    /// <para>示例值：7C468A54-8745-2245-9675-08B7C63E7A85</para>
    /// </summary>
    [JsonPropertyName("approval_code")]
    public string ApprovalCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>发起审批用户的 user_id，与 open_id 必须传入其中一个。如果传入了 user_id 则优先使用 user_id。</para>
    /// <para>必填：否</para>
    /// <para>示例值：f7cb567e</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; set; }

    /// <summary>
    /// <para>发起审批用户的 open_id，与 user_id 必须传入其中一个。如果传入了 user_id 则优先使用 user_id。</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_3cda9c969f737aaa05e6915dce306cb9</para>
    /// </summary>
    [JsonPropertyName("open_id")]
    public string? OpenId { get; set; }

    /// <summary>
    /// <para>发起审批用户部门id，如果用户只属于一个部门，可以不填。如果属于多个部门，默认会选择部门列表第一个部门</para>
    /// <para>必填：否</para>
    /// <para>示例值：9293493ccacbdb9a</para>
    /// </summary>
    [JsonPropertyName("department_id")]
    public string? DepartmentId { get; set; }

    /// <summary>
    /// <para>json 数组（需压缩转义成string），控件值</para>
    /// <para>必填：是</para>
    /// <para>示例值：[{\"id\":\"111\", \"type\": \"input\", \"value\":\"test\"}]</para>
    /// </summary>
    [JsonPropertyName("form")]
    public string Form { get; set; } = string.Empty;

    /// <summary>
    /// <para>如果有发起人自选节点，则需要填写对应节点的审批人</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("node_approver_user_id_list")]
    public NodeApprover[]? NodeApproverUserIdLists { get; set; }

    /// <summary>
    /// <para>如果有发起人自选节点，则需要填写对应节点的审批人</para>
    /// </summary>
    public record NodeApprover
    {
        /// <summary>
        /// <para>node id 或 custom node id，通过 [查看审批定义](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/approval/get) 获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：46e6d96cfa756980907209209ec03b64</para>
        /// </summary>
        [JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// <para>value: 审批人列表</para>
        /// <para>必填：否</para>
        /// <para>示例值：["f7cb567e"]</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string[]? Value { get; set; }
    }

    /// <summary>
    /// <para>审批人发起人自选 open id，与上述node_approver_user_id_list字段取并集</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("node_approver_open_id_list")]
    public NodeApprover[]? NodeApproverOpenIdLists { get; set; }

    /// <summary>
    /// <para>如果有发起人自选节点，则可填写对应节点的抄送人，单个节点最多选择20位抄送人</para>
    /// <para>必填：否</para>
    /// <para>最大长度：20</para>
    /// </summary>
    [JsonPropertyName("node_cc_user_id_list")]
    public NodeCc[]? NodeCcUserIdLists { get; set; }

    /// <summary>
    /// <para>如果有发起人自选节点，则可填写对应节点的抄送人，单个节点最多选择20位抄送人</para>
    /// </summary>
    public record NodeCc
    {
        /// <summary>
        /// <para>node id ，通过 [查看审批定义](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/approval/get) 获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：46e6d96cfa756980907209209ec03b75</para>
        /// </summary>
        [JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// <para>value: 审批人列表</para>
        /// <para>必填：否</para>
        /// <para>示例值：["f7cb567e"]</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string[]? Value { get; set; }
    }

    /// <summary>
    /// <para>抄送人发起人自选 open id 单个节点最多选择20位抄送人</para>
    /// <para>必填：否</para>
    /// <para>最大长度：20</para>
    /// </summary>
    [JsonPropertyName("node_cc_open_id_list")]
    public NodeCc[]? NodeCcOpenIdLists { get; set; }

    /// <summary>
    /// <para>审批实例 uuid，用于幂等操作, 每个租户下面的唯一key，同一个 uuid 只能用于创建一个审批实例，如果冲突，返回错误码 60012 ，格式建议为 XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX，不区分大小写</para>
    /// <para>必填：否</para>
    /// <para>示例值：7C468A54-8745-2245-9675-08B7C63E7A87</para>
    /// <para>最大长度：64</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }

    /// <summary>
    /// <para>可配置“提交”按钮，该操作适用于审批人退回场景，提单人在同一实例提交单据</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("allow_resubmit")]
    public bool? AllowResubmit { get; set; }

    /// <summary>
    /// <para>可配置是否可以再次提交，适用于周期性提单场景，按照当前表单内容再次发起一个新实例</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("allow_submit_again")]
    public bool? AllowSubmitAgain { get; set; }

    /// <summary>
    /// <para>取消指定的 bot 推送通知。可选值:</para>
    /// <para>- 1：取消通过推送。</para>
    /// <para>- 2：取消拒绝推送。</para>
    /// <para>- 4：取消实例取消推送。</para>
    /// <para>支持同时取消多个 bot 推送通知。位运算，即如需取消 1 和 2 两种通知，则需要传入加和值 3。</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("cancel_bot_notification")]
    public string? CancelBotNotification { get; set; }

    /// <summary>
    /// <para>配置是否可以禁止撤销</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// <para>默认值：false</para>
    /// </summary>
    [JsonPropertyName("forbid_revoke")]
    public bool? ForbidRevoke { get; set; }

    /// <summary>
    /// <para>国际化文案。目前只支单行、多行文本的值。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("i18n_resources")]
    public I18nResource[]? I18nResources { get; set; }

    /// <summary>
    /// <para>国际化文案。目前只支单行、多行文本的值。</para>
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
        /// <para>文案 key, value, i18n key 以 @i18n@ 开头； 该字段主要用于做国际化，允许用户同时传多个语言的文案，审批中心会根据用户当前的语音环境使用对应的文案，如果没有传用户当前的语音环境文案，则会使用默认的语言文案。</para>
        /// <para>必填：是</para>
        /// <para>示例值：{ "@i18n@1": "权限申请", "@i18n@2": "OA审批", "@i18n@3": "Permission" }</para>
        /// </summary>
        [JsonPropertyName("texts")]
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
            [JsonPropertyName("key")]
            public string Key { get; set; } = string.Empty;

            /// <summary>
            /// <para>文案</para>
            /// <para>必填：是</para>
            /// <para>示例值：people</para>
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
    /// <para>审批展示名称，如果填写了该字段，则审批列表中的审批名称使用该字段，如果不填该字段，则审批名称使用审批定义的名称</para>
    /// <para>必填：否</para>
    /// <para>示例值：@i18n@1</para>
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// <para>详情页title展示模式</para>
    /// <para>必填：否</para>
    /// <para>示例值：0</para>
    /// <para>可选值：<list type="bullet">
    /// <item>0：如果都有title，展示approval 和instance的title，竖线分割。</item>
    /// <item>1：如果都有title，只展示instance的title</item>
    /// </list></para>
    /// <para>默认值：0</para>
    /// </summary>
    [JsonPropertyName("title_display_method")]
    public int? TitleDisplayMethod { get; set; }

    /// <summary>
    /// <para>自动通过节点ID</para>
    /// <para>必填：否</para>
    /// <para>最大长度：10</para>
    /// </summary>
    [JsonPropertyName("node_auto_approval_list")]
    public NodeAutoApproval[]? NodeAutoApprovalLists { get; set; }

    /// <summary>
    /// <para>自动通过节点ID</para>
    /// </summary>
    public record NodeAutoApproval
    {
        /// <summary>
        /// <para>节点id的类型</para>
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
        /// <para>节点id</para>
        /// <para>必填：否</para>
        /// <para>示例值：manager_node_id</para>
        /// </summary>
        [JsonPropertyName("node_id")]
        public string? NodeId { get; set; }
    }
}
