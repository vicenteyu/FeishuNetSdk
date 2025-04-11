// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-01
//
// Last Modified By : yxr
// Last Modified On : 2024-07-01
// ************************************************************************
// <copyright file="PostCorehrV1AuthorizationsRemoveRoleAssignResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>移除用户被授权的角色 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 移除用户被授权的角色 响应体
/// <para>移除用户被授权的指定角色及授权范围，已经存在授权可通过[查询单个用户授权](https://lark-oapi-tools-console.bytedance.net/document-mod/index?fullPath=%2FuAjLw4CM%2FukTMukTMukTM%2Freference%2Fcorehr-v1%2Fauthorization%2Fget_by_param)获得。或者在[飞书人事管理后台](https://people.feishu.cn/people/)里 -「设置」-「权限设置」中的查看已有用户授权信息。</para>
/// <para>接口ID：7361618338575777820</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/authorization/remove_role_assign</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fauthorization%2fremove_role_assign</para>
/// </summary>
public record PostCorehrV1AuthorizationsRemoveRoleAssignResponseDto
{
    /// <summary>
    /// <para>授权id</para>
    /// <para>必填：否</para>
    /// <para>示例值：67489937334909845</para>
    /// </summary>
    [JsonPropertyName("assign_id")]
    public string? AssignId { get; set; }
}
