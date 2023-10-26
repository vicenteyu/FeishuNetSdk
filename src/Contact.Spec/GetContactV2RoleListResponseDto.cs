using Newtonsoft.Json;
namespace FeishuNetSdk.Contact.Spec;
/// <summary>
/// 获取角色列表 响应体
/// <para>该接口用于获取企业的用户角色列表。</para>
/// <para>接口ID：6907569744330391553</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version//user/obtain-a-role-list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuYzMwUjL2MDM14iNzATN</para>
/// </summary>
public record GetContactV2RoleListResponseDto
{
    /// <summary>
    /// <para>角色列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("role_list")]
    public Role[]? RoleList { get; set; }

    /// <summary></summary>
    public record Role
    {
        /// <summary>
        /// <para>角色 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>角色名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }
    }
}
