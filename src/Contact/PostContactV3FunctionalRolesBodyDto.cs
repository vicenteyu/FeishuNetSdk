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
/// <para>调用该接口创建一个角色。</para>
/// <para>## 使用限制</para>
/// <para>同一租户下，角色数量上限为 500。</para>
/// <para>接口ID：7200215886841135132</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/functional_role/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2ffunctional_role%2fcreate</para>
/// </summary>
public record PostContactV3FunctionalRolesBodyDto
{
    /// <summary>
    /// <para>角色名称。在同一租户下角色名称唯一，不能重复创建。</para>
    /// <para>必填：是</para>
    /// <para>示例值：考勤管理员</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("role_name")]
    public string RoleName { get; set; } = string.Empty;
}
