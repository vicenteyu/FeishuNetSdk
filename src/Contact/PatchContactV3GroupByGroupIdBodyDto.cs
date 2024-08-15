// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchContactV3GroupByGroupIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新用户组 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 更新用户组 请求体
/// <para>调用该接口更新指定用户组的名称或描述。</para>
/// <para>## 注意事项</para>
/// <para>- 应用的通讯录权限范围需要符合以下任一设置，才可以成功调用本接口。了解应用通讯录权限范围，可参见[权限范围资源介绍](https://open.feishu.cn/document/ukTMukTMukTM/uETNz4SM1MjLxUzM/v3/guides/scope_authority)。</para>
/// <para>- 通讯录权限范围设置为 **全部员工**。</para>
/// <para>- 由企业管理员在管理后台设置应用可见范围内包含当前待更新的用户组，然后应用的通讯录权限范围设置为 **与应用的可用范围一致**。</para>
/// <para>- API 方式暂不支持更新动态用户组。</para>
/// <para>接口ID：7008085931593007107</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/group/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fgroup%2fpatch</para>
/// </summary>
public record PatchContactV3GroupByGroupIdBodyDto
{
    /// <summary>
    /// <para>用户组名字，长度不能超过 100 字符。</para>
    /// <para>**说明**：用户组名称企业内唯一，如重复设置则会创建失败。</para>
    /// <para>**默认值**：空，表示不更新用户组名字。</para>
    /// <para>必填：否</para>
    /// <para>示例值：外包 IT 用户组</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// <para>用户组描述，长度不能超过 500 字符。</para>
    /// <para>**默认值**：空，表示不更新用户组描述。</para>
    /// <para>必填：否</para>
    /// <para>示例值：IT 外包用户组，需要进行细粒度权限管控</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }
}
