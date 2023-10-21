using Newtonsoft.Json;
namespace FeishuNetSdk.Contact;
/// <summary>
/// 查询用户组列表 响应体
/// <para>通过该接口可查询企业的用户组列表，可分别查询普通用户组或动态用户组。如果应用的通讯录权限范围是“全部员工”，则可获取企业全部用户组列表。如果应用的通讯录权限范围不是“全部员工”，则仅可获取通讯录权限范围内的用户组。[点击了解通讯录权限范围](https://open.feishu.cn/document/ukTMukTMukTM/uETNz4SM1MjLxUzM/v3/guides/scope_authority)。</para>
/// <para>接口ID：7008085931593039875</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/group/simplelist</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fgroup%2fsimplelist</para>
/// </summary>
public record GetContactV3GroupSimplelistResponseDto
{
    /// <summary>
    /// <para>用户组列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("grouplist")]
    public Group[] Grouplists { get; set; } = Array.Empty<Group>();

    /// <summary>
    /// <para>用户组列表</para>
    /// </summary>
    public record Group
    {
        /// <summary>
        /// <para>用户组ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：g193821</para>
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>用户组名字</para>
        /// <para>必填：是</para>
        /// <para>示例值：IT外包组</para>
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>用户组描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：IT外包组，需要对该组人群进行细颗粒度权限管控。</para>
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>用户组成员中用户的数量</para>
        /// <para>必填：否</para>
        /// <para>示例值：2</para>
        /// </summary>
        [JsonProperty("member_user_count")]
        public int? MemberUserCount { get; set; }

        /// <summary>
        /// <para>普通用户组成员中部门的数量，动态用户组成员中没有部门。</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonProperty("member_department_count")]
        public int? MemberDepartmentCount { get; set; }

        /// <summary>
        /// <para>用户组的类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：普通用户组</item>
        /// <item>2：动态用户组</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("type")]
        public int? Type { get; set; }

        /// <summary>
        /// <para>部门范围</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("department_scope_list")]
        public string[]? DepartmentScopeList { get; set; }

        /// <summary>
        /// <para>自定义用户组ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：4ba51ab38648f9cd</para>
        /// </summary>
        [JsonProperty("group_id")]
        public string? GroupId { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：是</para>
    /// <para>示例值：AQD9/Rn9556539ED40/dk53s4Ebp882DYfFaPFbz00L4CMZJrqGdzNyc8BcZtDbwVUvRmQTvyMYicnGWrde9X56TgdBuS+JDTJJDDPw=</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string PageToken { get; set; } = string.Empty;

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonProperty("has_more")]
    public bool HasMore { get; set; }
}
