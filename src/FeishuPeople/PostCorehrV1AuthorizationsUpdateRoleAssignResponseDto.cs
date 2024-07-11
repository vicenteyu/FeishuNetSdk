// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-12
//
// Last Modified By : yxr
// Last Modified On : 2024-07-12
// ************************************************************************
// <copyright file="PostCorehrV1AuthorizationsUpdateRoleAssignResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新用户被授权的数据范围 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 更新用户被授权的数据范围 响应体
/// <para>更新角色被授权的管理范围</para>
/// <para>更新后的数据范围，以本次提交的数据范围为准，本次未提交的部分将被移除。</para>
/// <para>接口ID：7361618338575810588</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/authorization/update_role_assign</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fauthorization%2fupdate_role_assign</para>
/// </summary>
public record PostCorehrV1AuthorizationsUpdateRoleAssignResponseDto
{
    /// <summary>
    /// <para>授权id</para>
    /// <para>必填：否</para>
    /// <para>示例值：67489937334909845</para>
    /// </summary>
    [JsonPropertyName("assign_id")]
    public string? AssignId { get; set; }
}
