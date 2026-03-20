namespace FeishuNetSdk.SecurityAndCompliance;
/// <summary>
/// 获取地理位置列表 响应体
/// <para>获取租户可用的数据驻留地理位置列表</para>
/// <para>接口ID：7202615512559009795</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/security_and_compliance-v1/user_migration/get-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsecurity_and_compliance-v1%2fmulti_geo_entity-tenant%2fget</para>
/// </summary>
public record GetSecurityAndComplianceV1MultiGeoEntityTenantResponseDto
{
    /// <summary>
    /// <para>数据驻留租户信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("tenant")]
    public TenantSuffix? Tenant { get; set; }

    /// <summary>
    /// <para>数据驻留租户信息</para>
    /// </summary>
    public record TenantSuffix
    {
        /// <summary>
        /// <para>可选地理位置列表</para>
        /// <para>必填：是</para>
        /// <para>示例值：["cn", "sg", "us", "jp"]</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("available_geo_locations")]
        public string[] AvailableGeoLocations { get; set; } = [];
    }
}
