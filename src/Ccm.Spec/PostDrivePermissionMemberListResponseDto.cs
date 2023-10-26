using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 获取协作者列表 响应体
/// <para>该接口用于根据 filetoken 查询协作者，目前包括人("user")和群("chat") 。</para>
/// <para>- 该接口为旧版接口。推荐你使用新版接口接入业务，详情参见[获取协作者列表（新版本）](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/permission-member/list)。</para>
/// <para>- 你能获取到协作者列表的前提是你对该文档有分享权限。</para>
/// <para>接口ID：6907569523177324545</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/permission/permission-member/obtain-a-collaborator-list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATN3UjLwUzN14CM1cTN</para>
/// </summary>
public record PostDrivePermissionMemberListResponseDto
{
    /// <summary>
    /// <para>协作者列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("members")]
    public Member[]? Members { get; set; }

    /// <summary></summary>
    public record Member
    {
        /// <summary>
        /// <para>协作者类型 "user" or "chat"</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("member_type")]
        public string? MemberType { get; set; }

        /// <summary>
        /// <para>协作者openid</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("member_open_id")]
        public string? MemberOpenId { get; set; }

        /// <summary>
        /// <para>协作者userid(仅当member_type="user"时有效)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("member_user_id")]
        public string? MemberUserId { get; set; }

        /// <summary>
        /// <para>协作者权限 (注意: **有"edit"权限的协作者一定有"view"权限**)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("perm")]
        public string? Perm { get; set; }
    }
}
