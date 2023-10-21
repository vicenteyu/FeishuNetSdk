using Newtonsoft.Json;
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 创建审批实例 响应体
/// <para>:::html为了更好地提升接口文档的的易理解性，我们对文档进行了升级，请尽快迁移至[新版本>>](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/create)创建一个审批实例，调用方需对审批定义的表单有详细了解，将按照定义的表单结构，将表单 Value 通过接口传入。</para>
/// <para>接口ID：6907569524100874241</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/approval/v2/feishu-native-approval/create-approval-instance</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuIDNyUjLyQjM14iM0ITN</para>
/// </summary>
public record PostApprovalOpenapiV2InstanceCreateResponseDto
{
    /// <summary>
    /// <para>审批实例 Code</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("instance_code")]
    public string InstanceCode { get; set; } = string.Empty;
}
