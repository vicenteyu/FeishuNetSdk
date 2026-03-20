namespace FeishuNetSdk.SecurityAndCompliance;
/// <summary>
/// 获取单个用户迁移状态 响应体
/// <para>通过user_id获取指定用户当前的迁移状态</para>
/// <para>接口ID：7202615512559042563</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/security_and_compliance-v1/user_migration/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsecurity_and_compliance-v1%2fuser_migration%2fget</para>
/// </summary>
public record GetSecurityAndComplianceV1UserMigrationsByUserIdResponseDto
{
    /// <summary>
    /// <para>用户迁移</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("user_migration")]
    public UserMigrationSuffix? UserMigration { get; set; }

    /// <summary>
    /// <para>用户迁移</para>
    /// </summary>
    public record UserMigrationSuffix
    {
        /// <summary>
        /// <para>用户 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_1234567890abcdef1234567890abcdef</para>
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
        /// <para>示例值：task-id-360043495213</para>
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
        /// <para>示例值：100</para>
        /// <para>最大值：100</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("progress")]
        public int? Progress { get; set; }
    }
}
