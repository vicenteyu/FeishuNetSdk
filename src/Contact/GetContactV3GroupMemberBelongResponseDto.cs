using Newtonsoft.Json;
namespace FeishuNetSdk.Contact;
/// <summary>
/// 查询用户所属用户组 响应体
/// <para>通过该接口可查询该用户所属的用户组列表，可分别查询普通用户组和动态用户组。如果应用的通讯录权限范围是“全部员工”，则可获取该员工所属的全部用户组列表。如果应用的通讯录权限范围不是“全部员工”，则仅可获取通讯录权限范围内该员工所属的用户组。[点击了解通讯录权限范围](https://open.feishu.cn/document/ukTMukTMukTM/uETNz4SM1MjLxUzM/v3/guides/scope_authority)。</para>
/// <para>接口ID：7106501358249885699</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/group/member_belong</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fgroup%2fmember_belong</para>
/// </summary>
public record GetContactV3GroupMemberBelongResponseDto
{
    /// <summary>
    /// <para>用户组ID列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("group_list")]
    public string[]? GroupList { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：AQD9/Rn9eij9Pm39ED40/dk53s4Ebp882DYfFaPFbz00L4CMZJrqGdzNyc8BcZtDbwVUvRmQTvyMYicnGWrde9X56TgdBuS+JKiSIkdexPw=</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonProperty("has_more")]
    public bool? HasMore { get; set; }
}
