using Newtonsoft.Json;
namespace FeishuNetSdk.Contact;
/// <summary>
/// 批量添加用户组成员 请求体
/// <para>向普通用户组中批量添加成员(目前仅支持添加用户，暂不支持添加部门），如果应用的通讯录权限范围是“全部员工”，则可将任何成员添加到任何用户组。如果应用的通讯录权限范围不是“全部员工”，则仅可将通讯录权限范围中的成员添加到通讯录权限范围的用户组中，[点击了解通讯录权限范围](https://open.feishu.cn/document/ukTMukTMukTM/uETNz4SM1MjLxUzM/v3/guides/scope_authority)。</para>
/// <para>接口ID：7106501358249852931</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/group-member/batch_add</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fgroup-member%2fbatch_add</para>
/// </summary>
public record PostContactV3GroupByGroupIdMemberBatchAddBodyDto
{
    /// <summary>
    /// <para>待添加成员</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonProperty("members")]
    public Memberlist[]? Members { get; set; }

    /// <summary>
    /// <para>待添加成员</para>
    /// </summary>
    public record Memberlist
    {
        /// <summary>
        /// <para>成员ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：u287xj12</para>
        /// </summary>
        [JsonProperty("member_id")]
        public string MemberId { get; set; } = string.Empty;

        /// <summary>
        /// <para>用户组成员的类型，取值为 user或department。</para>
        /// <para>必填：是</para>
        /// <para>示例值：user</para>
        /// </summary>
        [JsonProperty("member_type")]
        public string MemberType { get; set; } = string.Empty;

        /// <summary>
        /// <para>当member_type为user时，member_id_type表示user_id_type，可选值为open_id, union_id, user_id。仅在请求参数中有效，响应体中不会返回此参数。</para>
        /// <para>必填：否</para>
        /// <para>示例值：user_id</para>
        /// </summary>
        [JsonProperty("member_id_type")]
        public string? MemberIdType { get; set; }
    }
}
