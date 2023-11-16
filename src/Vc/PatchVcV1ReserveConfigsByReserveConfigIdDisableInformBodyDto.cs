namespace FeishuNetSdk.Vc;
/// <summary>
/// 更新禁用状态变更通知 请求体
/// <para>更新禁用状态变更通知</para>
/// <para>接口ID：7211447510368550916</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/scope_config/patch-4</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2freserve_config-disable_inform%2fpatch</para>
/// </summary>
public record PatchVcV1ReserveConfigsByReserveConfigIdDisableInformBodyDto
{
    /// <summary>
    /// <para>1表示会议室层级，2表示会议室</para>
    /// <para>必填：是</para>
    /// <para>示例值：2</para>
    /// </summary>
    [JsonPropertyName("scope_type")]
    public int ScopeType { get; set; }

    /// <summary>
    /// <para>禁用通知配置</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("disable_inform")]
    public DisableInformConfig DisableInform { get; set; } = new();

    /// <summary>
    /// <para>禁用通知配置</para>
    /// </summary>
    public record DisableInformConfig
    {
        /// <summary>
        /// <para>是否覆盖子层级及会议室</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("if_cover_child_scope")]
        public bool? IfCoverChildScope { get; set; }

        /// <summary>
        /// <para>禁用状态变更通知开关</para>
        /// <para>必填：是</para>
        /// <para>示例值：false</para>
        /// <para>默认值：false</para>
        /// </summary>
        [JsonPropertyName("if_inform")]
        public bool IfInform { get; set; }

        /// <summary>
        /// <para>通知成员列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("informed_users")]
        public SubscribeUser[]? InformedUsers { get; set; }

        /// <summary>
        /// <para>通知成员列表</para>
        /// </summary>
        public record SubscribeUser
        {
            /// <summary>
            /// <para>预定管理员ID</para>
            /// <para>必填：是</para>
            /// <para>示例值：ou_a27b07a9071d90577c0177bcec98f856</para>
            /// </summary>
            [JsonPropertyName("user_id")]
            public string UserId { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>通知部门列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("informed_depts")]
        public SubscribeDepartment[]? InformedDepts { get; set; }

        /// <summary>
        /// <para>通知部门列表</para>
        /// </summary>
        public record SubscribeDepartment
        {
            /// <summary>
            /// <para>预定管理部门ID，使用open_department_id</para>
            /// <para>必填：是</para>
            /// <para>示例值：od-47d8b570b0a011e9679a755efcc5f61a</para>
            /// </summary>
            [JsonPropertyName("department_id")]
            public string DepartmentId { get; set; } = string.Empty;
        }
    }
}
