namespace FeishuNetSdk.Acs;
/// <summary>
/// 添加访客 响应体
/// <para>添加访客</para>
/// <para>接口ID：7321978105899057180</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/acs-v1/visitor/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2facs-v1%2fvisitor%2fcreate</para>
/// </summary>
public record PostAcsV1VisitorsResponseDto
{
    /// <summary>
    /// <para>访客的id</para>
    /// <para>必填：是</para>
    /// <para>示例值：6939433228970082568</para>
    /// </summary>
    [JsonPropertyName("visitor_id")]
    public string VisitorId { get; set; } = string.Empty;
}
