namespace FeishuNetSdk.Contact;
/// <summary>
/// 删除角色下的成员 请求体
/// <para>通过本接口可以删除角色下的某个/些成员</para>
/// <para>接口ID：7200215886841102364</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/functional_role-member/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2ffunctional_role-member%2fbatch_delete</para>
/// </summary>
public record PatchContactV3FunctionalRolesByRoleIdMembersBatchDeleteBodyDto
{
    /// <summary>
    /// <para>角色删除的角色成员列表（一批用户的UserID列表)</para>
    /// <para>必填：否</para>
    /// <para>示例值：["qwer"]</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("members")]
    public string[]? Members { get; set; }
}
