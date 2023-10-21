using Newtonsoft.Json;
namespace FeishuNetSdk.Contact;
/// <summary>
/// 查询指定用户组 响应体
/// <para>根据用户组 ID 查询某个用户组的基本信息，支持查询普通用户组和动态用户组。请确保应用的通讯录权限范围里包括该用户组或者是“全部员工”，[点击了解通讯录权限范围](https://open.feishu.cn/document/ukTMukTMukTM/uETNz4SM1MjLxUzM/v3/guides/scope_authority)。</para>
/// <para>接口ID：7008085931593023491</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/group/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fgroup%2fget</para>
/// </summary>
public record GetContactV3GroupByGroupIdResponseDto
{
    /// <summary>
    /// <para>用户组详情</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("group")]
    public GetContactV3GroupByGroupIdResponseDtoGroup Group { get; set; } = new();

    /// <summary>
    /// <para>用户组详情</para>
    /// </summary>
    public record GetContactV3GroupByGroupIdResponseDtoGroup
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
    }
}
