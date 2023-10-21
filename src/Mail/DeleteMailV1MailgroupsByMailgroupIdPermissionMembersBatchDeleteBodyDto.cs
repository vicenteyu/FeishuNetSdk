using Newtonsoft.Json;
namespace FeishuNetSdk.Mail;
/// <summary>
/// 批量删除邮件组权限成员 请求体
/// <para>一次请求可以删除一个邮件组中的多个权限成员。</para>
/// <para>接口ID：7187647376462905348</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/mail-group/mailgroup-permission_member/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fmailgroup-permission_member%2fbatch_delete</para>
/// </summary>
public record DeleteMailV1MailgroupsByMailgroupIdPermissionMembersBatchDeleteBodyDto
{
    /// <summary>
    /// <para>本次调用删除的权限成员ID列表</para>
    /// <para>必填：是</para>
    /// <para>示例值：["xxxxxxx","yyyyyyy"]</para>
    /// <para>最大长度：200</para>
    /// </summary>
    [JsonProperty("permission_member_id_list")]
    public string[] PermissionMemberIdList { get; set; } = Array.Empty<string>();
}
