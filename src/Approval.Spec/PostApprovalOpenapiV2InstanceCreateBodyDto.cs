using Newtonsoft.Json;
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 创建审批实例 请求体
/// <para>为了更好地提升接口文档的的易理解性，我们对文档进行了升级，请尽快迁移至[新版本>>](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/create)创建一个审批实例，调用方需对审批定义的表单有详细了解，将按照定义的表单结构，将表单 Value 通过接口传入。</para>
/// <para>接口ID：6907569524100874241</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/approval/v2/feishu-native-approval/create-approval-instance</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuIDNyUjLyQjM14iM0ITN</para>
/// </summary>
public record PostApprovalOpenapiV2InstanceCreateBodyDto
{
    /// <summary>
    /// <para>审批定义 code</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("approval_code")]
    public string ApprovalCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>发起审批用户</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("user_id")]
    public string? UserId { get; set; }

    /// <summary>
    /// <para>发起审批用户 open id, 如果传了 user_id 则优先使用 user_id</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("open_id")]
    public string OpenId { get; set; } = string.Empty;

    /// <summary>
    /// <para>发起审批用户部门id，如果用户只属于一个部门，可以不填。如果属于多个部门，默认会选择部门列表第一个部门</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("department_id")]
    public string? DepartmentId { get; set; }

    /// <summary>
    /// <para>json 数组，**控件值**</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("form")]
    public string Form { get; set; } = string.Empty;

    public record FormSuffix
    {
        /// <summary>
        /// <para>控件 ID，也可以使用自定义 ID custom_id 的值</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>控件类型</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// <para>控件值，不同类型的值格式不一样</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>如果有发起人自选节点，则需要填写对应节点的审批人</para>
    /// <para>key:  node id 或 custom node id , 通过 [查看审批定义](https://open.feishu.cn/document/ukTMukTMukTM/uADNyUjLwQjM14CM0ITN) 获取</para>
    /// <para>value: 审批人列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("node_approver_user_id_list")]
    public object? NodeApproverUserIdList { get; set; }

    /// <summary>
    /// <para>审批人发起人自选 open id，与上述node_approver_user_id_list字段取并集</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("node_approver_open_id_list")]
    public object? NodeApproverOpenIdList { get; set; }

    /// <summary>
    /// <para>如果有发起人自选节点，则可填写对应节点的抄送人</para>
    /// <para>key:  node id 或 custom node id , 通过 [查看审批定义](https://open.feishu.cn/document/ukTMukTMukTM/uADNyUjLwQjM14CM0ITN) 获取</para>
    /// <para>value: 审批人列表</para>
    /// <para>单个节点最多选择20位抄送人</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("node_cc_user_id_list")]
    public object? NodeCcUserIdList { get; set; }

    /// <summary>
    /// <para>抄送人发起人自选 open id</para>
    /// <para>单个节点最多选择20位抄送人</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("node_cc_open_id_list")]
    public object? NodeCcOpenIdList { get; set; }

    /// <summary>
    /// <para>审批实例 uuid，用于幂等操作, 每个租户下面的唯一key，同一个 uuid 只能用于创建一个审批实例，如果冲突，返回错误码 60012 ，格式建议为 XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX，不区分大小写</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("uuid")]
    public string? Uuid { get; set; }
}
