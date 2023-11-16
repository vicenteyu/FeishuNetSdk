namespace FeishuNetSdk.Contact;
/// <summary>
/// 恢复已删除用户 请求体
/// <para>该接口用于恢复已删除用户（已离职的成员），仅自建应用可申请，应用商店应用无权调用接口。</para>
/// <para>接口ID：7122710137048399875</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/user/resurrect</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fuser%2fresurrect</para>
/// </summary>
public record PostContactV3UsersByUserIdResurrectBodyDto
{
    /// <summary>
    /// <para>部门</para>
    /// <para>必填：否</para>
    /// <para>最大长度：50</para>
    /// </summary>
    [JsonPropertyName("departments")]
    public UserDepartmentInfo[]? Departments { get; set; }

    /// <summary>
    /// <para>部门</para>
    /// </summary>
    public record UserDepartmentInfo
    {
        /// <summary>
        /// <para>对应的部门ID，需要与查询参数中的department_id_type类型保持一致。</para>
        /// <para>必填：是</para>
        /// <para>示例值：od-4e6ac4d14bcd5071a37a39de902c7141</para>
        /// </summary>
        [JsonPropertyName("department_id")]
        public string DepartmentId { get; set; } = string.Empty;

        /// <summary>
        /// <para>用户在部门内的排序</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("user_order")]
        public int? UserOrder { get; set; }

        /// <summary>
        /// <para>用户的部门间的排序</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("department_order")]
        public int? DepartmentOrder { get; set; }
    }

    /// <summary>
    /// <para>指定恢复后分配的席位，需开通“分配用户席位”权限</para>
    /// <para>必填：否</para>
    /// <para>示例值：["7179609168571645971"]</para>
    /// </summary>
    [JsonPropertyName("subscription_ids")]
    public string[]? SubscriptionIds { get; set; }
}
