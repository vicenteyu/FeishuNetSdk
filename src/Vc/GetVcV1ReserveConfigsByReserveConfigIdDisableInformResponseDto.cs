namespace FeishuNetSdk.Vc;
/// <summary>
/// 查询禁用状态变更通知 响应体
/// <para>查询禁用状态变更通知</para>
/// <para>接口ID：7211447510368534532</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/scope_config/get-4</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2freserve_config-disable_inform%2fget</para>
/// </summary>
public record GetVcV1ReserveConfigsByReserveConfigIdDisableInformResponseDto
{
    /// <summary>
    /// <para>会议室禁用通知配置</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("disable_inform")]
    public DisableInformConfig? DisableInform { get; set; }

    /// <summary>
    /// <para>会议室禁用通知配置</para>
    /// </summary>
    public record DisableInformConfig
    {
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
            /// <para>示例值：ou_e8bce6c3935ef1fc1b432992fd9d3db8</para>
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
            /// <para>示例值：od-5c07f0c117cf8795f25610a69363ce31</para>
            /// </summary>
            [JsonPropertyName("department_id")]
            public string DepartmentId { get; set; } = string.Empty;
        }
    }
}
