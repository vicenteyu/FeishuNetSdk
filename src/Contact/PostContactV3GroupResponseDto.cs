// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostContactV3GroupResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建用户组 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 创建用户组 响应体
/// <para>调用该接口创建一个用户组。用户组是飞书通讯录中基础实体之一，在用户组内可添加用户或部门资源。各类业务权限管控可以与用户组关联，从而实现高效便捷的成员权限管控。</para>
/// <para>## 注意事项</para>
/// <para>- 应用的通讯录权限范围必须为全部员工，否则会调用失败。了解应用通讯录权限范围，可参见[权限范围资源介绍](https://open.feishu.cn/document/ukTMukTMukTM/uETNz4SM1MjLxUzM/v3/guides/scope_authority)。</para>
/// <para>- 暂不支持通过该接口创建动态用户组。如需创建动态用户组参考[动态用户组](https://www.feishu.cn/hc/zh-CN/articles/360049067874)。</para>
/// <para>## 使用限制</para>
/// <para>单租户内用户组总数上限为 500（包含普通用户组和动态用户组）。</para>
/// <para>接口ID：7008085931593089027</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/group/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fgroup%2fcreate</para>
/// </summary>
public record PostContactV3GroupResponseDto
{
    /// <summary>
    /// <para>用户组 ID。后续可使用该 ID 更新、删除、查询用户组。</para>
    /// <para>必填：是</para>
    /// <para>示例值：g122817</para>
    /// </summary>
    [JsonPropertyName("group_id")]
    public string GroupId { get; set; } = string.Empty;
}
