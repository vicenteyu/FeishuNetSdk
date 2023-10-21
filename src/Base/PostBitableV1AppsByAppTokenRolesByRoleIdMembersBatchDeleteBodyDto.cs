using Newtonsoft.Json;
namespace FeishuNetSdk.Base;
/// <summary>
/// 批量删除协作者 请求体
/// <para>批量删除自定义角色的协作者</para>
/// <para>接口ID：7111246853309071363</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/advanced-permission/app-role-member/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-role-member%2fbatch_delete</para>
/// </summary>
public record PostBitableV1AppsByAppTokenRolesByRoleIdMembersBatchDeleteBodyDto
{
    /// <summary>
    /// <para>协作者列表</para>
    /// <para>必填：是</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonProperty("member_list")]
    public AppRoleMemberId[] MemberLists { get; set; } = Array.Empty<AppRoleMemberId>();

    /// <summary>
    /// <para>协作者列表</para>
    /// </summary>
    public record AppRoleMemberId
    {
        /// <summary>
        /// <para>协作者 ID 类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：open_id</para>
        /// <para>可选值：<list type="bullet">
        /// <item>open_id：协作者ID类型为open_id</item>
        /// <item>union_id：协作者ID类型为union_id</item>
        /// <item>user_id：协作者ID类型为user_id</item>
        /// <item>chat_id：协作者ID类型为chat_id</item>
        /// <item>department_id：协作者ID类型为department_id</item>
        /// <item>open_department_id：协作者ID类型为open_department_id</item>
        /// </list></para>
        /// <para>默认值：open_id</para>
        /// </summary>
        [JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// <para>协作者 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：ou_35990a9d9052051a2fae9b2f1afabcef</para>
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;
    }
}
