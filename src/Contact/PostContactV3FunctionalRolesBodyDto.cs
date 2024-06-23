// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostContactV3FunctionalRolesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建角色 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 创建角色 请求体
/// <para>通过”创建角色“接口可批量完成角色创建，新增角色同步展示至租户的管理后台-角色管理模块。</para>
/// <para>接口ID：7200215886841135132</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/functional_role/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2ffunctional_role%2fcreate</para>
/// </summary>
public record PostContactV3FunctionalRolesBodyDto
{
    /// <summary>
    /// <para>角色名称，在单租户下唯一</para>
    /// <para>必填：是</para>
    /// <para>示例值：考勤管理员</para>
    /// <para>最大长度：50</para>
    /// </summary>
    [JsonPropertyName("role_name")]
    public string RoleName { get; set; } = string.Empty;
}
