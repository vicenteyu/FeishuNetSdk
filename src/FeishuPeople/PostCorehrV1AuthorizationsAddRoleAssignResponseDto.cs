// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-12
//
// Last Modified By : yxr
// Last Modified On : 2024-07-12
// ************************************************************************
// <copyright file="PostCorehrV1AuthorizationsAddRoleAssignResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>为用户授权角色 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 为用户授权角色 响应体
/// <para>为用户授权角色及管理范围</para>
/// <para>对已被授权某个角色的用户继续授权，将在原授权的数据范围基础上追加数据范围。</para>
/// <para>接口ID：7361618338575794204</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/authorization/add_role_assign</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fauthorization%2fadd_role_assign</para>
/// </summary>
public record PostCorehrV1AuthorizationsAddRoleAssignResponseDto
{
    /// <summary>
    /// <para>授权id</para>
    /// <para>必填：否</para>
    /// <para>示例值：67489937334909845</para>
    /// </summary>
    [JsonPropertyName("assign_id")]
    public string? AssignId { get; set; }
}
