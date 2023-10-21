using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 添加知识空间成员 响应体
/// <para>添加知识空间成员或管理员。</para>
/// <para>接口ID：7023947709203906564</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/wiki-v2/space-member/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fwiki-v2%2fspace-member%2fcreate</para>
/// </summary>
public record PostWikiV2SpacesBySpaceIdMembersResponseDto
{
    /// <summary>
    /// <para>知识空间成员</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("member")]
    public PostWikiV2SpacesBySpaceIdMembersResponseDtoMember? Member { get; set; }

    /// <summary>
    /// <para>知识空间成员</para>
    /// </summary>
    public record PostWikiV2SpacesBySpaceIdMembersResponseDtoMember
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
        /// <para>用户id，值的类型由上面的 member_type 参数决定</para>
        /// <para>必填：是</para>
        /// <para>示例值：1565676577122621</para>
        /// </summary>
        [JsonProperty("member_id")]
        public string MemberId { get; set; } = string.Empty;

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
}
