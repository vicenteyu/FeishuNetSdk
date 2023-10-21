using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 删除知识空间成员 请求体
/// <para>此接口用于删除知识空间成员或管理员。</para>
/// <para>接口ID：7041549010980651010</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/wiki-v2/space-member/delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fwiki-v2%2fspace-member%2fdelete</para>
/// </summary>
public record DeleteWikiV2SpacesBySpaceIdMembersByMemberIdBodyDto
{
    /// <summary>
    /// <para>“openchat” - 群id</para>
    /// <para>“userid” - 用户id</para>
    /// <para>“email” - 邮箱</para>
    /// <para>“opendepartmentid” - 部门id</para>
    /// <para>“openid” - 应用openid</para>
    /// <para>“unionid” - [unionid](/:ssltoken/home/user-identity-introduction/union-id</para>
    /// <para>)</para>
    /// <para>必填：是</para>
    /// <para>示例值：userid</para>
    /// </summary>
    [JsonProperty("member_type")]
    public string MemberType { get; set; } = string.Empty;

    /// <summary>
    /// <para>角色:</para>
    /// <para>“admin” - 管理员</para>
    /// <para>“member” - 成员</para>
    /// <para>必填：是</para>
    /// <para>示例值：admin</para>
    /// </summary>
    [JsonProperty("member_role")]
    public string MemberRole { get; set; } = string.Empty;
}
