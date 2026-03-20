namespace FeishuNetSdk.SecurityAndCompliance;
/// <summary>
/// 批量获取用户迁移状态 请求体
/// <para>传入用户 ID 列表，批量获取用户迁移状态</para>
/// <para>接口ID：7202615512559058947</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/security_and_compliance-v1/user_migration/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsecurity_and_compliance-v1%2fuser_migration%2fsearch</para>
/// </summary>
public record PostSecurityAndComplianceV1UserMigrationsSearchBodyDto
{
    /// <summary>
    /// <para>用户 ID 列表</para>
    /// <para>必填：是</para>
    /// <para>示例值：123</para>
    /// <para>最大长度：500</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("user_ids")]
    public string[] UserIds { get; set; } = [];
}
