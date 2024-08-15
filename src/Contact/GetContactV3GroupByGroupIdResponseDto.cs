// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetContactV3GroupByGroupIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询指定用户组 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 查询指定用户组 响应体
/// <para>调用该接口通过用户组 ID 查询指定用户组的基本信息，包括用户组名称、成员数量和类型等。</para>
/// <para>## 注意事项</para>
/// <para>- 应用的通讯录权限范围需要符合以下任一设置，才可以成功调用本接口。了解应用通讯录权限范围，可参见[权限范围资源介绍](https://open.feishu.cn/document/ukTMukTMukTM/uETNz4SM1MjLxUzM/v3/guides/scope_authority)。</para>
/// <para>- 通讯录权限范围设置为 **全部员工**。</para>
/// <para>- 由企业管理员在管理后台设置应用可见范围内包含当前待查询的用户组，然后应用的通讯录权限范围设置为 **与应用的可用范围一致**。</para>
/// <para>- 支持查询普通用户组和动态用户组。</para>
/// <para>接口ID：7008085931593023491</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/group/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fgroup%2fget</para>
/// </summary>
public record GetContactV3GroupByGroupIdResponseDto
{
    /// <summary>
    /// <para>用户组详情。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("group")]
    public GetContactV3GroupByGroupIdResponseDtoGroup Group { get; set; } = new();

    /// <summary>
    /// <para>用户组详情。</para>
    /// </summary>
    public record GetContactV3GroupByGroupIdResponseDtoGroup
    {
        /// <summary>
        /// <para>用户组 ID。</para>
        /// <para>必填：是</para>
        /// <para>示例值：g193821</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>用户组名字。</para>
        /// <para>必填：是</para>
        /// <para>示例值：IT 外包组</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>用户组描述。</para>
        /// <para>必填：否</para>
        /// <para>示例值：IT 外包组，需要对该组人群进行细颗粒度权限管控。</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>用户组成员中的用户数量。</para>
        /// <para>必填：否</para>
        /// <para>示例值：2</para>
        /// </summary>
        [JsonPropertyName("member_user_count")]
        public int? MemberUserCount { get; set; }

        /// <summary>
        /// <para>普通用户组内成员中的部门数量。</para>
        /// <para>**说明**：动态用户组成员中没有部门。</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("member_department_count")]
        public int? MemberDepartmentCount { get; set; }

        /// <summary>
        /// <para>用户组的类型。</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：普通用户组</item>
        /// <item>2：动态用户组</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("type")]
        public int? Type { get; set; }
    }
}
