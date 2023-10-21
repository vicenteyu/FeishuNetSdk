using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 增加协作者权限 响应体
/// <para>该接口用于根据 filetoken 给用户增加文档的权限。</para>
/// <para>接口ID：6987581166854635521</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/permission/permission-member/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fpermission-member%2fcreate</para>
/// </summary>
public record PostDriveV1PermissionsByTokenMembersResponseDto
{
    /// <summary>
    /// <para>本次添加权限的用户信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("member")]
    public BaseMember? Member { get; set; }

    /// <summary>
    /// <para>本次添加权限的用户信息</para>
    /// </summary>
    public record BaseMember
    {
        /// <summary>
        /// <para>协作者 ID 类型，与协作者 ID 需要对应</para>
        /// <para>必填：是</para>
        /// <para>示例值：openid</para>
        /// <para>可选值：<list type="bullet">
        /// <item>email：飞书邮箱</item>
        /// <item>openid：开放平台ID</item>
        /// <item>openchat：开放平台群组ID</item>
        /// <item>opendepartmentid：开放平台部门ID</item>
        /// <item>userid：用户自定义ID</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("member_type")]
        public string MemberType { get; set; } = string.Empty;

        /// <summary>
        /// <para>协作者 ID，与协作者 ID 类型需要对应</para>
        /// <para>必填：是</para>
        /// <para>示例值：ou_67e5ecb64ce1c0bd94612c17999db411</para>
        /// </summary>
        [JsonProperty("member_id")]
        public string MemberId { get; set; } = string.Empty;

        /// <summary>
        /// <para>协作者对应的权限角色</para>
        /// <para>**注意：** 妙记还不支持可管理角色</para>
        /// <para>必填：是</para>
        /// <para>示例值：view</para>
        /// <para>可选值：<list type="bullet">
        /// <item>view：可阅读角色</item>
        /// <item>edit：可编辑角色</item>
        /// <item>full_access：可管理角色</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("perm")]
        public string Perm { get; set; } = string.Empty;
    }
}
