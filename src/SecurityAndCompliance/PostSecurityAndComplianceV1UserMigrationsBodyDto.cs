namespace FeishuNetSdk.SecurityAndCompliance;
/// <summary>
/// 迁移用户 请求体
/// <para>将用户的数据驻留位置迁移到目标地理位置。</para>
/// <para>接口ID：7202615512559026179</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/security_and_compliance-v1/user_migration/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsecurity_and_compliance-v1%2fuser_migration%2fcreate</para>
/// </summary>
public record PostSecurityAndComplianceV1UserMigrationsBodyDto
{
    /// <summary>
    /// <para>迁移用户 ID 列表，ID类型必须与查询参数user_id_type的取值一致</para>
    /// <para>必填：是</para>
    /// <para>示例值：123</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("user_ids")]
    public string[] UserIds { get; set; } = [];

    /// <summary>
    /// <para>迁移目标地理位置区域，参数长度2到10字符</para>
    /// <para>必填：是</para>
    /// <para>示例值：sg</para>
    /// </summary>
    [JsonPropertyName("dest_geo")]
    public string DestGeo { get; set; } = string.Empty;
}
