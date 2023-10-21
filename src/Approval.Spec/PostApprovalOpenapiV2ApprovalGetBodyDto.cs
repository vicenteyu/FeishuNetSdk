using Newtonsoft.Json;
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 查看审批定义 请求体
/// <para>:::html为了更好地提升接口文档的的易理解性，我们对文档进行了升级，请尽快迁移至[新版本>>](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/approval/get)根据 Approval Code 获取某个审批定义的详情，用于构造创建审批实例的请求。</para>
/// <para>接口ID：6907569744330358785</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/approval/v2/feishu-native-approval/obtain-single-approval-form</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuADNyUjLwQjM14CM0ITN</para>
/// </summary>
public record PostApprovalOpenapiV2ApprovalGetBodyDto
{
    /// <summary>
    /// <para>审批定义 Code</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("approval_code")]
    public string ApprovalCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>zh-CN - 中文<br>en-US - 英文  <br>ja-JP - 日文</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("locale")]
    public string? Locale { get; set; }
}
