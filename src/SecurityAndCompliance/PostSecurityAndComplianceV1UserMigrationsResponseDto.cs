namespace FeishuNetSdk.SecurityAndCompliance;
/// <summary>
/// 迁移用户 响应体
/// <para>将用户的数据驻留位置迁移到目标地理位置。</para>
/// <para>接口ID：7202615512559026179</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/security_and_compliance-v1/user_migration/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsecurity_and_compliance-v1%2fuser_migration%2fcreate</para>
/// </summary>
public record PostSecurityAndComplianceV1UserMigrationsResponseDto
{
    /// <summary>
    /// <para>用户迁移列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("user_migrations")]
    public UserMigration[]? UserMigrations { get; set; }

    /// <summary>
    /// <para>用户迁移列表</para>
    /// </summary>
    public record UserMigration
    {
        /// <summary>
        /// <para>用户 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：123165707875</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>目标地理位置区域</para>
        /// <para>必填：否</para>
        /// <para>示例值：us</para>
        /// </summary>
        [JsonPropertyName("dest_geo")]
        public string? DestGeo { get; set; }

        /// <summary>
        /// <para>迁移任务 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：task_1234567890abcdef</para>
        /// </summary>
        [JsonPropertyName("task_id")]
        public string? TaskId { get; set; }

        /// <summary>
        /// <para>用户迁移状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：用户迁移进行中</item>
        /// <item>1：用户迁移已完成</item>
        /// <item>2：用户迁移已取消</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// <para>迁移进度百分比，取值 0-100</para>
        /// <para>必填：否</para>
        /// <para>示例值：20</para>
        /// <para>最大值：100</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("progress")]
        public int? Progress { get; set; }
    }
}
