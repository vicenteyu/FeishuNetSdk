// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetVcV1ReserveConfigsByReserveConfigIdAdminResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询会议室预定管理员 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc;
/// <summary>
/// 查询会议室预定管理员 响应体
/// <para>查询会议室预定管理员。</para>
/// <para>接口ID：7194805625628131331</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/scope_config/get-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2freserve_config-admin%2fget</para>
/// </summary>
public record GetVcV1ReserveConfigsByReserveConfigIdAdminResponseDto
{
    /// <summary>
    /// <para>预定管理员/部门</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("reserve_admin_config")]
    public GetVcV1ReserveConfigsByReserveConfigIdAdminResponseDtoReserveAdminConfig ReserveAdminConfig { get; set; } = new();

    /// <summary>
    /// <para>预定管理员/部门</para>
    /// </summary>
    public record GetVcV1ReserveConfigsByReserveConfigIdAdminResponseDtoReserveAdminConfig
    {
        /// <summary>
        /// <para>预定管理部门</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("depts")]
        public SubscribeDepartment[]? Depts { get; set; }

        /// <summary>
        /// <para>预定管理部门</para>
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

        /// <summary>
        /// <para>预定管理员</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("users")]
        public SubscribeUser[]? Users { get; set; }

        /// <summary>
        /// <para>预定管理员</para>
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
    }
}
