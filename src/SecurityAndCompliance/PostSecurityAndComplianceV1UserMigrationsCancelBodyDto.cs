namespace FeishuNetSdk.SecurityAndCompliance;
/// <summary>
/// 取消用户迁移 请求体
/// <para>取消用户迁移任务，仅能对未启动迁移的用户做此操作。用户迁移状态可通过「获取单个用户迁移状态」查询。</para>
/// <para>接口ID：7202615512558977027</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/security_and_compliance-v1/user_migration/cancel</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsecurity_and_compliance-v1%2fuser_migration%2fcancel</para>
/// </summary>
public record PostSecurityAndComplianceV1UserMigrationsCancelBodyDto
{
    /// <summary>
    /// <para>取消迁移用户 ID 列表</para>
    /// <para>必填：是</para>
    /// <para>示例值：abcdefghi</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("user_ids")]
    public string[] UserIds { get; set; } = [];
}
