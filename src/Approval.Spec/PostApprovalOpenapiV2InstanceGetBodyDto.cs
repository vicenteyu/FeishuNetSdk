namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 获取单个审批实例详情 请求体
/// <para>为了更好地提升接口文档的的易理解性，我们对文档进行了升级，请尽快迁移至[新版本&gt;&gt;](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/get)通过审批实例 Instance Code 获取审批实例详情。Instance Code 由 [批量获取审批实例](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/list) 接口获取。</para>
/// <para>接口ID：6907569524100497409</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/approval/v2/feishu-native-approval/obtain-single-approval-instance-details</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuEDNyUjLxQjM14SM0ITN</para>
/// </summary>
public record PostApprovalOpenapiV2InstanceGetBodyDto
{
    /// <summary>
    /// <para>审批实例 Code, 若在创建的时候传了uuid, 也可以通过传uuid获取</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("instance_code")]
    public string InstanceCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>zh-CN - 中文</para>
    /// <para>en-US - 英文</para>
    /// <para>ja-JP - 日文</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("locale")]
    public string? Locale { get; set; }

    /// <summary>
    /// <para>发起审批用户,平台级审批时使用</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; set; }

    /// <summary>
    /// <para>发起审批用户 open id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("open_id")]
    public string? OpenId { get; set; }
}
